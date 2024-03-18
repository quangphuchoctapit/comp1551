using comp1551.Student;
using System;
using System.Data;
using System.Windows.Forms;
using static comp1551.utils;

namespace comp1551
{
    public partial class Login : Form
    {
        private Database db;

        public Login()
        {
            InitializeComponent();
            db = new Database();
            db.OpenConnection();
        }


        // this function will be executed when the button 'Login' is clicked
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // query to get all users from table user
                string query = "SELECT * FROM user";
                DataTable result = db.ExecuteQuery(query);

                bool userFound = false;
                foreach (DataRow row in result.Rows)
                {
                    // assign some variables to retreive user inputs
                    string telephone = row["telephone"].ToString();
                    string role = row["role"].ToString();
                    string password = row["password"].ToString();
                    string userID = row["id"].ToString();

                    // if the user inputs (telephone and password) match the database result, assign the global vairables: GlobalVariables.UserId and GlobalVariables.UserRole to later on identify the current logged in user
                    if (txtTelephone.Text == telephone && txtPassword.Text == password)
                    {
                        userFound = true;

                        // Set the GlobalVariables.UserId and GlobalVariables.UserRole 
                        GlobalVariables.UserId = int.Parse(userID);
                        GlobalVariables.UserRole = role;
                        // after setting above variables, end the foreach loop
                        break;
                    }
                }

                // if there is result from that query, this if condition will be executed, otherwise, the code will execute the else condition
                if (userFound)
                {
                    // Open the MainPage form when login is successful
                    MainPage home = new MainPage();
                    this.Hide();
                    home.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect phone or password. Please try again...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error logging in: {ex.Message}");
            }
        }


        // if the user click the link label 'Sign Up', this function will be executed to close 'Login' form and open 'Sign Up' form
        private void linkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hide the current Login window and open the Signup form
            this.Hide();
            using (Signup signUp = new Signup())
            {
                signUp.ShowDialog();
            }
        }
    }
}

