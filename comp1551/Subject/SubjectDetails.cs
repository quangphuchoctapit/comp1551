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

namespace comp1551.Subject
{
    public partial class SubjectDetails : Form
    {
        public SubjectDetails()
        {
            InitializeComponent();
        }

        // Define user role variable
        string userRole = GlobalVariables.UserRole;

        // Instantiate Database class
        private Database db = new Database();

        // Event handler for 'Add' button click
        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            // Open AddSubject form to add a new subject
            using (AddSubject s = new AddSubject())
            {
                s.lbl = "Add New Subject"; // Set label text
                s.ShowDialog();
            }
        }

        // Event handler for 'Edit' button click
        private void btnEditSubject_Click(object sender, EventArgs e)
        {
            // Open AddSubject form to edit an existing subject
            using (AddSubject ac = new AddSubject())
            {
                ac.lbl = "Update Subject"; // Set label text

                // Check if any cell is selected in the DataGridView
                if (tableSubject.CurrentCell != null)
                {
                    int rowIndex = tableSubject.CurrentCell.RowIndex;
                    DataGridViewRow selectedRow = tableSubject.Rows[rowIndex];

                    // Get the DataRow associated with the selected DataGridViewRow
                    DataRowView selectedRowView = selectedRow.DataBoundItem as DataRowView;
                    if (selectedRowView != null)
                    {
                        // Retrieve the ID value from the DataRow
                        int subjectId = Convert.ToInt32(selectedRowView.Row["Id"]);

                        // Pass the subjectID to the AddSubject form
                        ac.subjectID = subjectId;
                    }
                    else
                    {
                        MessageBox.Show("The selected row does not contain an ID value.", "Invalid Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please select a cell to edit.", "No Cell Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ac.ShowDialog();
            }
        }

        // Function to load subject data & display to datagridview
        public void LoadSubjectData()
        {
            try
            {
                db.OpenConnection();

                // Query to retrieve all subjects data
                string query = "SELECT * from Subject";

                DataTable subjectTable = db.ExecuteQuery(query);

                // Check if there is any data
                if (subjectTable.Rows.Count > 0)
                {
                    // Set DataGridView properties
                    tableSubject.AutoGenerateColumns = false;
                    tableSubject.DataSource = subjectTable;
                    tableSubject.Columns.Clear();

                    // Add DataGridView columns
                    DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
                    idColumn.DataPropertyName = "Id";
                    idColumn.HeaderText = "ID";

                    DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
                    nameColumn.DataPropertyName = "Name"; // Column for subject name
                    nameColumn.HeaderText = "Name";

                    DataGridViewTextBoxColumn subjectIdColumn = new DataGridViewTextBoxColumn();
                    subjectIdColumn.DataPropertyName = "SubjectId"; // Column for subject ID
                    subjectIdColumn.HeaderText = "SubjectID";

                    DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn();
                    descriptionColumn.DataPropertyName = "Description"; // Column for subject description
                    descriptionColumn.HeaderText = "Description";

                    // Add columns to the DataGridView
                    tableSubject.Columns.Add(idColumn);
                    tableSubject.Columns.Add(nameColumn);
                    tableSubject.Columns.Add(subjectIdColumn);
                    tableSubject.Columns.Add(descriptionColumn);
                }
                else
                {
                    MessageBox.Show("No subject data found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // event handler for form load
        private void SubjectDetails_Load(object sender, EventArgs e)
        {
            LoadSubjectData();
            btnAddSubject.Enabled = false;
            btnEditSubject.Enabled = false;
            btnDeleteSubject.Enabled = false;
            // check if the current user role is admin, if not, disable them, otherwise, enable them (buttons)
            if (userRole == "admin")
            {
                btnAddSubject.Enabled = true;
                btnEditSubject.Enabled = true;
                btnDeleteSubject.Enabled = true;
            }
        }

        // Event handler for 'Search' button click
        private void btnSearchSubject_Click(object sender, EventArgs e)
        {
            HandleSearchSubject();
        }

        // function to handle subject search
        private void HandleSearchSubject()
        {
            try
            {
                db.OpenConnection();
                tableSubject.Columns.Clear();

                // Query to retrieve subjects data based on search text
                string query = $"SELECT * FROM Subject WHERE name LIKE '%{txtSearchSubject.Text}%' OR subjectId LIKE '%{txtSearchSubject.Text}%'";

                DataTable subjectTable = db.ExecuteQuery(query);

                // Check if there is any data
                if (subjectTable.Rows.Count > 0)
                {
                    // Set DataGridView properties
                    tableSubject.AutoGenerateColumns = false;
                    tableSubject.DataSource = subjectTable;

                    // Add DataGridView columns
                    DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
                    idColumn.DataPropertyName = "Id";
                    idColumn.HeaderText = "ID";

                    DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
                    nameColumn.DataPropertyName = "Name"; // Column for subject name
                    nameColumn.HeaderText = "Name";

                    DataGridViewTextBoxColumn subjectIdColumn = new DataGridViewTextBoxColumn();
                    subjectIdColumn.DataPropertyName = "SubjectId"; // Column for subject ID
                    subjectIdColumn.HeaderText = "SubjectID";

                    DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn();
                    descriptionColumn.DataPropertyName = "Description"; // Column for subject description
                    descriptionColumn.HeaderText = "Description";

                    // Add columns to the DataGridView
                    tableSubject.Columns.Add(idColumn);
                    tableSubject.Columns.Add(nameColumn);
                    tableSubject.Columns.Add(subjectIdColumn);
                    tableSubject.Columns.Add(descriptionColumn);
                }
                else
                {
                    MessageBox.Show("No subject data found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading subject data: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // event handler for 'Delete' button click
        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();

                if (tableSubject.CurrentCell != null)
                {
                    int rowIndex = tableSubject.CurrentCell.RowIndex;
                    DataGridViewRow selectedRow = tableSubject.Rows[rowIndex];

                    DataRowView selectedRowView = selectedRow.DataBoundItem as DataRowView;
                    if (selectedRowView != null)
                    {
                        int subjectId = Convert.ToInt32(selectedRowView.Row["Id"]);

                        string querySubject = $"DELETE FROM subject WHERE id = {subjectId}";
                        db.ExecuteNonQuery(querySubject);
                        db.CloseConnection();

                        LoadSubjectData(); // Reload subject data after deletion
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

        // Event handler for search button picturebox in the search btn click
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HandleSearchSubject();
        }
    }
}
