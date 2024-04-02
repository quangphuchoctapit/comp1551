using comp1551.ExtensionWinform;
using comp1551.Student;
using comp1551.Teacher;
using static comp1551.utils;
using System;
using System.Windows.Forms;

namespace comp1551
{
    public partial class Signup : Form
    {
        private Database db;

        // create a variable, this will be used later to check which dropdown item that the user chose
        private string selectedRole;

        public Signup()
        {
            InitializeComponent();
            db = new Database();
            db.OpenConnection();
            // Add items to the ComboBox
            dropdownRole.Items.Add("Student");
            dropdownRole.Items.Add("Teacher");

            // Set the default selected item
            dropdownRole.SelectedIndex = 0;
            selectedRole = dropdownRole.Items[0].ToString();

            // Wire up the event handler
            dropdownRole.SelectedIndexChanged += dropdownRole_SelectedIndexChanged;
        }


        // this function is executed when the user click the button 'Sign Up'
        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                // define some variables for retreiving user inputs
                string telephone = txtTelephone.Text;
                string password = txtPassword.Text;
                string name = txtName.Text;
                string email = txtEmail.Text;

                // Check if the telephone, email, or password is empty
                if (string.IsNullOrEmpty(telephone) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(name))
                {
                    // if the user not enter one of the above, a messagebox will pop up to indicate the user to enter all inputs, then end the function by the keyword return
                    MessageBox.Show("Please enter telephone, email, name, and password.");
                    return;
                }
                if (!IsValidPhoneNumber(telephone))
                {
                    MessageBox.Show("Please Enter a valid Telephone Number");
                    return;
                }
                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Please Enter a valid Email");
                    return;
                }

                // Check if the telephone already exists in the database
                string checkTelephoneQuery = $"SELECT COUNT(*) FROM user WHERE telephone = '{telephone}'";
                int telephoneCount = db.GetCount(checkTelephoneQuery);

                if (telephoneCount > 0)
                {
                    MessageBox.Show("Telephone already exists. Please choose a different one.");
                    return;
                }

                // Check if the email already exists in the database
                string checkEmailQuery = $"SELECT COUNT(*) FROM user WHERE email = '{email}'";
                int emailCount = db.GetCount(checkEmailQuery);

                if (emailCount > 0)
                {
                    MessageBox.Show("Email already exists. Please choose a different one.");
                    return;
                }

                // Insert new user into the database with selected role
                string role = GetRoleFromSelectedOption(selectedRole);
                string insertQuery = $"INSERT INTO user (telephone, email, password, role, name, image) " +
                    $"VALUES ('{telephone}', '{email}', '{password}', '{role}', '{name}', '')";

                // Execute the insert query
                db.ExecuteNonQuery(insertQuery);

                // Get the ID of the newly inserted user
                string getUserIdQuery = $"SELECT id FROM user WHERE telephone = '{telephone}'";
                int userId = db.GetUserId(getUserIdQuery);
                // if there is result from the above query:  string getUserIdQuery = $"SELECT id FROM user WHERE telephone = '{telephone}'";, the below condition will be executed
                if (userId > 0)
                {
                    // Hide the current Signup window
                  /*  this.Hide();*/

                    // based on the selected role, open the respective Signup form
                    if (selectedRole == "Student")
                    {
                        using (StudentSignup ss = new StudentSignup())
                        {
                            ss.userId = userId;
                            ss.ShowDialog();
                        }
                    }
                    else if (selectedRole == "Teacher")
                    {
                        using (TeacherSignup ts = new TeacherSignup())
                        {
                            ts.userId = userId;
                            ts.ShowDialog();
                        }
                    }
                }

                //otherwise, a messagebox error will pop up
                else
                {
                    MessageBox.Show("Error creating user. User ID not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating user: {ex.Message}");
            }
        }

        private string GetRoleFromSelectedOption(string selectedRole)
        {
            switch (selectedRole)
            {
                case "Student":
                    return "student";
                case "Teacher":
                    return "teacher";
                default:
                    return "student"; // Default to student if no match
            }
        }



        // this function will be executed when the user select a dropdown item, then assign the global selectedRole variable as the selected dropdown item
        private void dropdownRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item
            selectedRole = dropdownRole.SelectedItem.ToString();
        }


        // this function is executed when the form is initially opened
        private void Signup_Load(object sender, EventArgs e)
        {
            
        }


        // when the user clicks the label Login, this fucntion will be activated => close this Signup form, and open Login form
        private void linkLabelLogin_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hide the current Signup window and open the Login form
            this.Hide();
            using (Login login = new Login())
            {
                login.ShowDialog();
            }
        }
    }
}
