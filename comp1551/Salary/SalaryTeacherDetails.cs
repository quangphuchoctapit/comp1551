using comp1551.Teacher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp1551.Salary
{
    public partial class SalaryTeacherDetails : Form
    {
        public SalaryTeacherDetails()
        {
            InitializeComponent();
        }

        private Database db = new Database();

        // add a new salary record for a teacher when the user clicks the edit btn
        private void btnAddSalary_Click(object sender, EventArgs e)
        {
            // open the AddSalaryTeacher form to add a new salary
            using (AddSalaryTeacher ast = new AddSalaryTeacher())
            {
                ast.lbl = "Add New Salary";
                ast.ShowDialog(); // show the AddSalaryTeacher form as a dialog
            }
        }

        // edit an existing salary record for a teacher when the user clicks the edit btn
        private void btnEditSalary_Click(object sender, EventArgs e)
        {
            // open the AddSalaryTeacher form to edit salary for an existing teacher
            using (AddSalaryTeacher ast = new AddSalaryTeacher())
            {
                ast.lbl = "Update Salary"; // set the label text for Update Salary

                // check if any row is selected in the DataGridView
                if (tableSalary.CurrentRow != null)
                {
                    DataRowView selectedRowView = tableSalary.CurrentRow.DataBoundItem as DataRowView;

                    // check if the selectedRowView is not null
                    if (selectedRowView != null)
                    {
                        // retrieve the ID value from the DataRow
                        if (selectedRowView.Row.Table.Columns.Contains("Id"))
                        {
                            int teacherId = Convert.ToInt32(selectedRowView.Row["Id"]);
                            ast.userID = teacherId; // pass the teacherId to the AddSalaryTeacher form
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

                    ast.ShowDialog(); // show the AddSalaryTeacher form as a dialog
                }
                else
                {
                    MessageBox.Show("Please select a teacher to edit salary.", "No Teacher Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        // load salary data when the form is initially loaded
        private void SalaryTeacherDetails_Load(object sender, EventArgs e)
        {
            LoadSalaryData();
        }

        // load salary data from the database and display to datagridview
        public void LoadSalaryData()
        {
            try
            {
                db.OpenConnection();
                // query to get all salary from table user where the role equals 'teacher'
                string query = "SELECT u.Id, u.Name, t.Salary " +
                               "FROM User u " +
                               "JOIN Teacher t ON u.Id = t.UserId " +
                               "WHERE u.Role = 'teacher'";

                DataTable dataTable = db.ExecuteQuery(query);

                if (dataTable.Rows.Count > 0)
                {
                    // clear existing columns if any
                    tableSalary.Columns.Clear();

                    // add DataGridView columns
                    DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
                    idColumn.DataPropertyName = "Id";
                    idColumn.HeaderText = "ID";

                    DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
                    nameColumn.DataPropertyName = "Name";
                    nameColumn.HeaderText = "Name";

                    DataGridViewTextBoxColumn salaryColumn = new DataGridViewTextBoxColumn();
                    salaryColumn.DataPropertyName = "Salary";
                    salaryColumn.HeaderText = "Salary";

                    // add columns to the DataGridView
                    tableSalary.Columns.Add(idColumn);
                    tableSalary.Columns.Add(nameColumn);
                    tableSalary.Columns.Add(salaryColumn);

                    // set DataGridView properties
                    tableSalary.AutoGenerateColumns = false;
                    tableSalary.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No teacher data found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading salary data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}
