using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static comp1551.utils;

namespace comp1551.Class
{
    public partial class ClassDetails : Form
    {
        public ClassDetails()
        {
            InitializeComponent();
        }
        private Database db = new Database();
        string userRole = GlobalVariables.UserRole;


        private void btnAddClass_Click(object sender, EventArgs e)
        {
            using (AddClass ac = new AddClass())
            {
                // ac.lbl is put before ac.ShowDialog() because it must be set before the dialog appear, else it won't have any data in ac.lbl
                ac.lbl = "Add New Class"; // because lbl is public, I can use it here to reuse AddClass Design, and modify text of header and text in button
                ac.ShowDialog();
            }
        }

        private void btnEditClass_Click(object sender, EventArgs e)
        {
            using (AddClass ac = new AddClass())
            {
                // Set the label text for Update Class
                ac.lbl = "Update Class";

                // Check if any row is selected in the DataGridView
                if (tableClass.CurrentRow != null)
                {
                    // Get the selected class from the DataGridView
                    DataRowView selectedRowView = tableClass.CurrentRow.DataBoundItem as DataRowView;

                    // Check if the selectedRowView is not null
                    if (selectedRowView != null)
                    {
                        // Retrieve the ID value from the DataRow
                        if (selectedRowView.Row.Table.Columns.Contains("Id"))
                        {
                            int classId = Convert.ToInt32(selectedRowView.Row["Id"]);

                            // Pass the classId to the AddClass form
                            ac.classID = classId;
                        }
                        else
                        {
                            MessageBox.Show("The selected row does not contain an ID value.", "Invalid Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data associated with the selected row.", "Invalid Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    ac.ShowDialog(); // Show the AddClass form as a dialog
                }
                else
                {
                    MessageBox.Show("Please select a class to edit.", "No Class Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }


        public void LoadClassData()
        {
            try
            {
                db.OpenConnection();

                // Query to retrieve student data based on the role "student" with corresponding faculty and class names
                string query = "SELECT * from Class";

                DataTable classTable = db.ExecuteQuery(query);

                // Check if there is any data
                if (classTable.Rows.Count > 0)
                {
                    tableClass.Columns.Clear();

                    // Set DataGridView properties
                    tableClass.AutoGenerateColumns = false;
                    tableClass.DataSource = classTable;

                    // Add DataGridView columns
                    DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
                    idColumn.DataPropertyName = "Id";
                    idColumn.HeaderText = "ID";

                    DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
                    nameColumn.DataPropertyName = "Name";
                    nameColumn.HeaderText = "Name";

                    DataGridViewTextBoxColumn maxCapacityColumn = new DataGridViewTextBoxColumn();
                    maxCapacityColumn.DataPropertyName = "maxCapacity";
                    maxCapacityColumn.HeaderText = "Max Capacity";

                    // Add columns to the DataGridView
                    tableClass.Columns.Add(idColumn);
                    tableClass.Columns.Add(nameColumn);
                    tableClass.Columns.Add(maxCapacityColumn);
                }
                else
                {
                    MessageBox.Show("No class data found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading class data: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }
        }


        // whenever this form is loaded, thsi func will be executed
        private void ClassDetails_Load(object sender, EventArgs e)
        {
            // first it call LoadClassData the display data to user interface, then, it check the current user role, if the user is not admin, some buttons will be disabled
            LoadClassData();
            btnAddClass.Enabled = false;
            btnEditClass.Enabled = false;
            btnDeleteClass.Enabled = false;
            if (userRole == "admin")
            {
                btnAddClass.Enabled = true;
                btnEditClass.Enabled = true;
                btnDeleteClass.Enabled = true;
            }
        }


        // this func will be used like LoadClassData, but it run different mysql query and display different result depends on the user input in the txtSearch
        private void HandleSearchClass()
        {
            try
            {
                db.OpenConnection();

                // Query to retrieve all Classes
                string query = $"SELECT * FROM Class where name like '%{txtSearchClass.Text}%'";
                tableClass.Columns.Clear();


                DataTable classTable = db.ExecuteQuery(query);

                // Check if there is any data
                if (classTable.Rows.Count > 0)
                {
                    // Set DataGridView properties
                    tableClass.AutoGenerateColumns = false;
                    tableClass.DataSource = classTable;

                    // Add DataGridView columns
                    DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
                    idColumn.DataPropertyName = "Id";
                    idColumn.HeaderText = "ID";

                    DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
                    nameColumn.DataPropertyName = "Name";
                    nameColumn.HeaderText = "Name";

                    // Add columns to the DataGridView
                    tableClass.Columns.Add(idColumn);
                    tableClass.Columns.Add(nameColumn);
                }
                else
                {
                    MessageBox.Show("No class data found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading class data: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();  // Closing the database connection after operations
            }
        }


        // because I put the picturebox icon Search within the button, it won't do anything if i click the picturebox, unless I handle the event click on the picturebox as can be seen in this func
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HandleSearchClass();
        }

        // when the user clicks the search btn, this func will be executed
        private void btnSearchClass_Click(object sender, EventArgs e)
        {
            HandleSearchClass();

        }

        // when the user clicks the delete btn, this func will be executed

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();

                // Check if any cell is selected
                if (tableClass.CurrentCell != null)
                {
                    int rowIndex = tableClass.CurrentCell.RowIndex;
                    DataGridViewRow selectedRow = tableClass.Rows[rowIndex];

                    // Get the DataRow associated with the selected DataGridViewRow
                    DataRowView selectedRowView = selectedRow.DataBoundItem as DataRowView;
                    if (selectedRowView != null)
                    {
                        int classId = Convert.ToInt32(selectedRowView.Row["Id"]);
                        string queryClass = $"DELETE FROM class WHERE id = {classId}";
                        db.ExecuteNonQuery(queryClass);
                        // I have to close connection right here because in LoadClassData func, it will use db.OpenConnection again, which cause error if I don't do that
                        db.CloseConnection();

                        LoadClassData(); // Reload class data after deletion
                    }
                    else
                    {
                        MessageBox.Show("The selected row does not contain an ID value.", "Invalid Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    db.CloseConnection();

                }
                else
                {
                    MessageBox.Show("Please select a cell to delete.", "No Cell Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    db.CloseConnection();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
                db.CloseConnection();

            }
        }
    }
}
