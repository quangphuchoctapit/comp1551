using comp1551.Subject;
using System.Data;
using static comp1551.UserClass;

namespace comp1551.Salary
{
    public partial class AddSalaryTeacher : Form
    {
        public AddSalaryTeacher()
        {
            InitializeComponent();
            listBoxAddSalaryTeacherTeacherId.SelectedIndexChanged += listBoxAddSalaryTeacherTeacherId_SelectedIndexChanged;

        }
        private Database db = new Database(); // Database object for handling database operations
        public string lbl;
        private KeyValuePair<int, string> selectedTeacher; // Selected class (key-value pair of teacherId and name)
        public int userID;


        // this func will be executed when the form is first loaded
        private void AddSalaryTeacher_Load(object sender, EventArgs e)
        {
            lblAddSalaryTeacher.Text = lbl; // Set the label text based on the provided label

            // condition to check
            if (lblAddSalaryTeacher.Text == "Add New Salary") // Check if the label text is "Add New Teacher"
            {
                PopulateTeachersListBox();
                btnAddSalaryTeacher.Text = "Add"; // Set the button text to "Add"
            }
            else if (lblAddSalaryTeacher.Text == "Update Salary") // Check if the label text is "Update Teacher"
            {
                btnAddSalaryTeacher.Text = "Update"; // Set the button text to "Update"
                // Open database connection
                db.OpenConnection();

                // Query to get classes
                string getTeachersQuery = "SELECT u.Id AS Id, u.Name AS Name, u.Email, u.Telephone " +
                          "FROM User u " +
                          "JOIN Teacher t ON u.Id = t.UserId " +
                          $"WHERE u.Role = 'teacher' AND u.Id={userID}";

                UoGSystem system = new UoGSystem();
                decimal salary = system.TeacherManage.GetTeacherSalary(userID);
                txtAddSalaryTeacherSalary.Text = salary.ToString();
                // Execute the query and get the DataTable
                DataTable teacherTable = db.ExecuteQuery(getTeachersQuery);

                // Iterate through each row and add to the ListBox as a key-value pair
                foreach (DataRow row in teacherTable.Rows)
                {
                    int teacherId = Convert.ToInt32(row["Id"]);
                    string Name = row["Name"].ToString();
                    listBoxAddSalaryTeacherTeacherId.Items.Add(new KeyValuePair<int, string>(teacherId, Name));
                }

                // Close database connection
                db.CloseConnection();
            }
        }

        // Method to populate the Classes ListBox
        private void PopulateTeachersListBox()
        {
            try
            {
                // Open database connection
                db.OpenConnection();

                // Query to get classes
                string getTeachersQuery = "SELECT u.Id AS Id, u.Name AS Name, u.Email, u.Telephone, t.salary AS Salary " +
                          "FROM User u " +
                          "JOIN Teacher t ON u.Id = t.UserId " +
                          "WHERE u.Role = 'teacher'";


                // Execute the query and get the DataTable
                DataTable teacherTable = db.ExecuteQuery(getTeachersQuery);

                // Iterate through each row and add to the ListBox as a key-value pair
                foreach (DataRow row in teacherTable.Rows)
                {
                    int teacherId = Convert.ToInt32(row["Id"]);
                    string Name = row["Name"].ToString();
                    listBoxAddSalaryTeacherTeacherId.Items.Add(new KeyValuePair<int, string>(teacherId, Name));
                }

                // Close database connection
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                // Show error message if an exception occurs
                MessageBox.Show($"Error loading classes: {ex.Message}");
            }
        }

        private void listBoxAddSalaryTeacherTeacherId_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (listBoxAddSalaryTeacherTeacherId.SelectedItem != null)
            {
                // Get the selected class
                selectedTeacher = (KeyValuePair<int, string>)listBoxAddSalaryTeacherTeacherId.SelectedItem;
                int teacherId = selectedTeacher.Key;
                string teacherName = selectedTeacher.Value;
            }
        }

        // this func will be executed when the user clicks Add btn
        private void btnAddSalaryTeacher_Click(object sender, EventArgs e)
        {
            db.OpenConnection();
            try
            {
                // Check if Salary is a valid double
                if (!double.TryParse(txtAddSalaryTeacherSalary.Text, out double Salary))
                {
                    MessageBox.Show("Please enter a valid salary.");
                    return;
                }

                int teacherId = selectedTeacher.Key;
                // Update existing salary in the database
                string updateSalaryQuery = $"UPDATE Teacher SET Salary = {Salary} WHERE UserId = {teacherId}";

                // Execute the update query
                db.ExecuteNonQuery(updateSalaryQuery);

                MessageBox.Show("Salary updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                // reload SalaryTeacherDetails
                SalaryTeacherDetails studentDetailsForm = Application.OpenForms["SalaryTeacherDetails"] as SalaryTeacherDetails;
                studentDetailsForm?.LoadSalaryData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

    }
}
