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

namespace comp1551.Faculty
{
    public partial class FacultyDetails : Form
    {
        public FacultyDetails()
        {
            InitializeComponent();
        }
        string userRole = GlobalVariables.UserRole;

        private Database db = new Database();  // creating an instance of the Database class for database operations

        // method to load faculty data into the DataGridView
        public void LoadFacultyData()
        {
            try
            {
                db.OpenConnection();

                // query to retrieve all faculties
                string query = "SELECT * FROM faculty";

                DataTable facultyTable = db.ExecuteQuery(query);

                // check if there is any data
                if (facultyTable.Rows.Count > 0)
                {

                    // set DataGridView properties
                    tableFaculty.AutoGenerateColumns = false;
                    tableFaculty.DataSource = facultyTable;
                    tableFaculty.Columns.Clear();

                    // add DataGridView columns
                    DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
                    idColumn.DataPropertyName = "Id";  // binding to the 'Id' column in the DataTable
                    idColumn.HeaderText = "ID";

                    DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
                    nameColumn.DataPropertyName = "Name";  // binding to the 'Name' column in the DataTable
                    nameColumn.HeaderText = "Name";

                    DataGridViewTextBoxColumn facultyIdColumn = new DataGridViewTextBoxColumn();
                    facultyIdColumn.DataPropertyName = "FacultyId";  // binding to the 'FacultyId' column in the DataTable
                    facultyIdColumn.HeaderText = "FacultyId";

                    DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn();
                    descriptionColumn.DataPropertyName = "Description";  // binding to the 'Description' column in the DataTable
                    descriptionColumn.HeaderText = "Description";

                    // add columns to the DataGridView
                    tableFaculty.Columns.Add(idColumn);
                    tableFaculty.Columns.Add(nameColumn);
                    tableFaculty.Columns.Add(facultyIdColumn);
                    tableFaculty.Columns.Add(descriptionColumn);
                }
                else
                {
                    MessageBox.Show("No faculty data found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading faculty data: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();  // closing the database connection after operations
            }
        }

        // event handler when the form is loaded
        private void FacultyDetails_Load(object sender, EventArgs e)
        {

            // laod faculty data and display to datagridview, then depend if the user is admin or not, enable some button or not
            LoadFacultyData();
            btnAddFaculty.Enabled = false;
            btnEditFaculty.Enabled = false;
            btnDeleteFaculty.Enabled = false;
            if (userRole == "admin")
            {
                btnAddFaculty.Enabled = true;
                btnEditFaculty.Enabled = true;
                btnDeleteFaculty.Enabled = true;
            }
        }

        // event handler when the 'Add Faculty' button is clicked
        private void btnAddFaculty_Click(object sender, EventArgs e)
        {
            using (AddFaculty af = new AddFaculty())
            {
                // set the label text for AddFaculty form
                af.lbl = "Add New Faculty";
                af.ShowDialog();  // displaying the AddFaculty form as a dialog
            }
        }

        // this func will be executed when the user clicks edit btn

        private void btnEditFaculty_Click(object sender, EventArgs e)
        {
            // open the AddFaculty form to edit an existing faculty
            using (AddFaculty af = new AddFaculty())
            {
                // set the label text for Update Faculty
                af.lbl = "Update Faculty";

                // check if any row is selected in the DataGridView
                if (tableFaculty.CurrentRow != null)
                {
                    // get the selected faculty from the DataGridView
                    DataRowView selectedRowView = tableFaculty.CurrentRow.DataBoundItem as DataRowView;

                    // check if the selectedRowView is not null
                    if (selectedRowView != null)
                    {
                        // retrieve the ID value from the DataRow
                        if (selectedRowView.Row.Table.Columns.Contains("Id"))
                        {
                            int facultyId = Convert.ToInt32(selectedRowView.Row["Id"]);

                            // pass the facultyID to the AddFaculty form
                            af.facultyID = facultyId;
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

                    af.ShowDialog(); // show the AddFaculty form as a dialog
                }
                else
                {
                    MessageBox.Show("Please select a faculty to edit.", "No Faculty Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        // this func will be executed when the user clicks search btn

        private void btnSearchFaculty_Click(object sender, EventArgs e)
        {
            HandleSearchFaculty();
        }

        private void HandleSearchFaculty()
        {
            try
            {
                db.OpenConnection();

                // query to retrieve all faculties
                string query = $"SELECT * FROM faculty where name like '%{txtSearchFaculty.Text}%' or facultyId like '%{txtSearchFaculty.Text}%'";
                tableFaculty.Columns.Clear();


                DataTable facultyTable = db.ExecuteQuery(query);

                // check if there is any data
                if (facultyTable.Rows.Count > 0)
                {
                    // set DataGridView properties
                    tableFaculty.AutoGenerateColumns = false;
                    tableFaculty.DataSource = facultyTable;

                    // add DataGridView columns
                    DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
                    idColumn.DataPropertyName = "Id";  // binding to the 'Id' column in the DataTable
                    idColumn.HeaderText = "ID";

                    DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
                    nameColumn.DataPropertyName = "Name";  // binding to the 'Name' column in the DataTable
                    nameColumn.HeaderText = "Name";

                    DataGridViewTextBoxColumn facultyIdColumn = new DataGridViewTextBoxColumn();
                    facultyIdColumn.DataPropertyName = "FacultyId";  // binding to the 'FacultyId' column in the DataTable
                    facultyIdColumn.HeaderText = "FacultyId";

                    DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn();
                    descriptionColumn.DataPropertyName = "Description";  // binding to the 'Description' column in the DataTable
                    descriptionColumn.HeaderText = "Description";

                    // add columns to the DataGridView
                    tableFaculty.Columns.Add(idColumn);
                    tableFaculty.Columns.Add(nameColumn);
                    tableFaculty.Columns.Add(facultyIdColumn);
                    tableFaculty.Columns.Add(descriptionColumn);
                }
                else
                {
                    MessageBox.Show("No faculty data found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading faculty data: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();  // closing the database connection after operations
            }
        }


        // this func will be executed when the user clicks delete btn
        private void btnDeleteFaculty_Click(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();

                // check if any cell is selected
                if (tableFaculty.CurrentCell != null)
                {
                    int rowIndex = tableFaculty.CurrentCell.RowIndex;
                    DataGridViewRow selectedRow = tableFaculty.Rows[rowIndex];

                    // get the DataRow associated with the selected DataGridViewRow
                    DataRowView selectedRowView = selectedRow.DataBoundItem as DataRowView;
                    if (selectedRowView != null)
                    {
                        int facultyId = Convert.ToInt32(selectedRowView.Row["Id"]);
                        // delete from faculty_subjects table
                        string deleteFacultySubjectsQuery = $"DELETE FROM faculty_subjects WHERE facultyId = {facultyId}";
                        db.ExecuteNonQuery(deleteFacultySubjectsQuery);
                        string queryFaculty = $"DELETE FROM faculty WHERE id = {facultyId}";
                        db.ExecuteNonQuery(deleteFacultySubjectsQuery);
                        db.ExecuteNonQuery(queryFaculty);
                        db.CloseConnection();
                        LoadFacultyData(); // reload faculty data after deletion
                    }
                    else
                    {
                        MessageBox.Show("The selected row does not contain an ID value.", "Invalid Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a cell to delete.", "No Cell Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                db.CloseConnection(); // ensure the connection is closed even in case of exception
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // call func HandleSearchFaculty
            HandleSearchFaculty();
        }
    }
}
