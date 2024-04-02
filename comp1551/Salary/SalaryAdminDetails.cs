using Microsoft.VisualBasic.ApplicationServices;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static comp1551.UserClass;

namespace comp1551.Salary
{
    public partial class SalaryAdminDetails : Form
    {
        public SalaryAdminDetails()
        {
            InitializeComponent();
        }
        private Database db = new Database(); // database object for handling database operations


        // this func will be executed when the form is first loaded
        private void SalaryAdminDetails_Load(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();

                UoGSystem system = new UoGSystem();
                decimal salary = system.AdminManage.GetAdminSalary();
                txtAdminSalary.Text = salary.ToString();
                // Query to get admin salary
                string getSalaryQuery = "SELECT u.Id AS Id, a.salary AS Salary " +
                                        "FROM User u " +
                                        "JOIN admin a ON u.Id = a.UserId " +
                                        "WHERE u.Role = 'admin'";

                // execute the query and get the DataTable
                DataTable salaryTable = db.ExecuteQuery(getSalaryQuery);

                // check if the DataTable contains any rows
                if (salaryTable.Rows.Count > 0)
                {
                    // Retrieve the salary from the first row and display it in the text box
                    txtAdminSalary.Text = salaryTable.Rows[0]["Salary"].ToString();
                }
                else
                {
                    MessageBox.Show("No admin salary data found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close database connection
                db.CloseConnection();
            }
        }

        // this func will be executed when the user clicks confirm btn
        private void btnConfirmAdminSalary_Click(object sender, EventArgs e)
        {
            // Check if Salary textbox is empty
            if (string.IsNullOrWhiteSpace(txtAdminSalary.Text))
            {
                MessageBox.Show("Please enter a salary.");
                return;
            }

            // Parse the salary value
            if (!decimal.TryParse(txtAdminSalary.Text, out decimal salary))
            {
                MessageBox.Show("Please enter a valid salary.");
                return;
            }

            // Check if the entered salary is negative
            if (salary < 0)
            {
                MessageBox.Show("Salary cannot be negative. Please enter a positive value.");
                return;
            }

            try
            {
                db.OpenConnection();

                // update the salary of the admin
                string updateSalaryQuery = $"UPDATE admin SET salary = {salary}";

                // Execute the update query
                db.ExecuteNonQuery(updateSalaryQuery);

                // display success message
                MessageBox.Show("Admin salary updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // handling exceptions, e.g., display error message
                MessageBox.Show($"Error updating admin salary: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }



    }
}
