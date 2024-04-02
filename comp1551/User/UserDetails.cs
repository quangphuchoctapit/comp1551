using comp1551.Student;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static comp1551.UserClass;
using static comp1551.utils;
using static comp1551.utils;
using comp1551.Student;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using comp1551.Teacher;

namespace comp1551.User
{
    public partial class UserDetails : Form
    {
        public UserDetails()
        {
            InitializeComponent();
            // add items in combo box filter
            comboBoxFilter.Items.Add("User");
            comboBoxFilter.Items.Add("Student");
            comboBoxFilter.Items.Add("Teacher");
            LoadUserData("user");

            // This sets the default selected item to "User" but only once, when the form is loaded
            comboBoxFilter.SelectedIndex = 0;
        }

        public string userRole = GlobalVariables.UserRole;


        // this function will be executed when the window is loaded
        private void UserDetails_Load(object sender, EventArgs e)
        {
            // call LoadUserData function in this
            LoadUserData("user");
        }


        // this function is used for loading user data 
        public void LoadUserData(string roleInput)
        {
            // define a variable with the class 'UserClass'

            try
            {

                // define a variable with the class 'UoGSystem'
                UoGSystem system = new UoGSystem();
                // condition to check if the roleInput is user or student or admin to use different UoGSystem methods to retreive information of users
                if (roleInput == "student")
                {
                    List<StudentClass> users = new List<StudentClass>();

                    users = system.StudentManage.GetAllStudents();
                    // if there is more than 0 result, execute this func
                    if (users.Count > 0)
                    {
                        // clear existing columns if any
                        tableUser.Columns.Clear();

                        // Add datagridview columns
                        DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
                        idColumn.DataPropertyName = "Id";
                        idColumn.HeaderText = "ID";

                        DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
                        nameColumn.DataPropertyName = "Name";
                        nameColumn.HeaderText = "Name";

                        DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
                        emailColumn.DataPropertyName = "Email";
                        emailColumn.HeaderText = "Email";

                        DataGridViewTextBoxColumn telephoneColumn = new DataGridViewTextBoxColumn();
                        telephoneColumn.DataPropertyName = "Telephone";
                        telephoneColumn.HeaderText = "Telephone";

                        DataGridViewTextBoxColumn roleColumn = new DataGridViewTextBoxColumn();
                        roleColumn.DataPropertyName = "Role"; // Using the alias from the query
                        roleColumn.HeaderText = "Role";

                        // Add columns to the DataGridView
                        tableUser.Columns.Add(idColumn);
                        tableUser.Columns.Add(nameColumn);
                        tableUser.Columns.Add(emailColumn);
                        tableUser.Columns.Add(telephoneColumn);
                        tableUser.Columns.Add(roleColumn);

                        // Set DataGridView properties
                        tableUser.AutoGenerateColumns = false;
                        tableUser.DataSource = users;
                    }
                    //otherwise, popup a messagebox Not found
                    else
                    {
                        MessageBox.Show("No user data found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (roleInput == "teacher")
                {
                    List<TeacherClass> users = new List<TeacherClass>();

                    users = system.TeacherManage.GetAllTeachers();
                    // if there is more than 0 result, execute this func
                    if (users.Count > 0)
                    {
                        // clear existing columns if any
                        tableUser.Columns.Clear();

                        // Add datagridview columns
                        DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
                        idColumn.DataPropertyName = "Id";
                        idColumn.HeaderText = "ID";

                        DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
                        nameColumn.DataPropertyName = "Name";
                        nameColumn.HeaderText = "Name";

                        DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
                        emailColumn.DataPropertyName = "Email";
                        emailColumn.HeaderText = "Email";

                        DataGridViewTextBoxColumn telephoneColumn = new DataGridViewTextBoxColumn();
                        telephoneColumn.DataPropertyName = "Telephone";
                        telephoneColumn.HeaderText = "Telephone";

                        DataGridViewTextBoxColumn roleColumn = new DataGridViewTextBoxColumn();
                        roleColumn.DataPropertyName = "Role"; // Using the alias from the query
                        roleColumn.HeaderText = "Role";

                        // Add columns to the DataGridView
                        tableUser.Columns.Add(idColumn);
                        tableUser.Columns.Add(nameColumn);
                        tableUser.Columns.Add(emailColumn);
                        tableUser.Columns.Add(telephoneColumn);
                        tableUser.Columns.Add(roleColumn);

                        // Set DataGridView properties
                        tableUser.AutoGenerateColumns = false;
                        tableUser.DataSource = users;
                    }
                    //otherwise, popup a messagebox Not found
                    else
                    {
                        MessageBox.Show("No user data found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    List<PersonClass> users = new List<PersonClass>();

                    users = system.PersonManage.GetAllUserSearch(txtSearchUser.Text);
                    // if there is more than 0 result, execute this func
                    if (users.Count > 0)
                    {
                        // clear existing columns if any
                        tableUser.Columns.Clear();

                        // Add datagridview columns
                        DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
                        idColumn.DataPropertyName = "Id";
                        idColumn.HeaderText = "ID";

                        DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
                        nameColumn.DataPropertyName = "Name";
                        nameColumn.HeaderText = "Name";

                        DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
                        emailColumn.DataPropertyName = "Email";
                        emailColumn.HeaderText = "Email";

                        DataGridViewTextBoxColumn telephoneColumn = new DataGridViewTextBoxColumn();
                        telephoneColumn.DataPropertyName = "Telephone";
                        telephoneColumn.HeaderText = "Telephone";

                        DataGridViewTextBoxColumn roleColumn = new DataGridViewTextBoxColumn();
                        roleColumn.DataPropertyName = "Role"; // Using the alias from the query
                        roleColumn.HeaderText = "Role";

                        // Add columns to the DataGridView
                        tableUser.Columns.Add(idColumn);
                        tableUser.Columns.Add(nameColumn);
                        tableUser.Columns.Add(emailColumn);
                        tableUser.Columns.Add(telephoneColumn);
                        tableUser.Columns.Add(roleColumn);

                        // Set DataGridView properties
                        tableUser.AutoGenerateColumns = false;
                        tableUser.DataSource = users;
                    }
                    //otherwise, popup a messagebox Not found
                    else
                    {
                        MessageBox.Show("No user data found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // if the user click the dropdown Filterm this function will be executed
        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if the selected index is valid to avoid exceptions
            if (comboBoxFilter.SelectedIndex != -1)
            {

                // Retrieve the selected item from the ComboBox
                // If the ComboBox is bound to a data source, you might need to cast this to the appropriate type
                //string selectedItem = comboBoxFilter.SelectedItem.ToString();
                //string selectedItem = comboBoxFilter.SelectedItem.ToString();


                UoGSystem system = new UoGSystem();

                // Show a MessageBox displaying the selected item
                //MessageBox.Show($"Selected item: {selectedItem}", "Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // check if the user click on what item in dropdown filter, and pass param to LoadUserData func
                if (comboBoxFilter.SelectedIndex ==0)
                {

                    LoadUserData("user");
                }
                else if (comboBoxFilter.SelectedIndex == 1)
                {

                    LoadUserData("student");
                }
                else if (comboBoxFilter.SelectedIndex == 2)
                {

                    LoadUserData("teacher");

                }
            }
        }

        // when the user click the Search button, this func will be executed
        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a role is selected
                if (comboBoxFilter.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // retrieve the selected role from the combobox
                string selectedRole = comboBoxFilter.SelectedItem.ToString();

                // Rrtrieve users based on the selected role and search text
                UoGSystem system = new UoGSystem();
                if (selectedRole.ToLower() == "student")
                {
                    List<StudentClass> users = system.StudentManage.GetAllStudentSearch(txtSearchUser.Text);
                    if (users.Count > 0)
                    {
                        // clear existing columns in the DataGridView
                        tableUser.Columns.Clear();

                        // add DataGridView columns
                        DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
                        idColumn.DataPropertyName = "Id";
                        idColumn.HeaderText = "ID";

                        DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
                        nameColumn.DataPropertyName = "Name";
                        nameColumn.HeaderText = "Name";

                        DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
                        emailColumn.DataPropertyName = "Email";
                        emailColumn.HeaderText = "Email";

                        DataGridViewTextBoxColumn telephoneColumn = new DataGridViewTextBoxColumn();
                        telephoneColumn.DataPropertyName = "Telephone";
                        telephoneColumn.HeaderText = "Telephone";

                        DataGridViewTextBoxColumn roleColumn = new DataGridViewTextBoxColumn();
                        roleColumn.DataPropertyName = "Role";
                        roleColumn.HeaderText = "Role";

                        // add columns to the DataGridView
                        tableUser.Columns.AddRange(idColumn, nameColumn, emailColumn, telephoneColumn, roleColumn);

                        // set DataGridView properties
                        tableUser.AutoGenerateColumns = false;
                        tableUser.DataSource = users;
                    }
                    else
                    {
                        MessageBox.Show("No user data found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else if (selectedRole.ToLower() == "teacher")
                {
                    List<TeacherClass> users = system.TeacherManage.GetAllTeacherSearch(txtSearchUser.Text);
                    if (users.Count > 0)
                    {
                        // clear existing columns in the DataGridView
                        tableUser.Columns.Clear();

                        // add DataGridView columns
                        DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
                        idColumn.DataPropertyName = "Id";
                        idColumn.HeaderText = "ID";

                        DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
                        nameColumn.DataPropertyName = "Name";
                        nameColumn.HeaderText = "Name";

                        DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
                        emailColumn.DataPropertyName = "Email";
                        emailColumn.HeaderText = "Email";

                        DataGridViewTextBoxColumn telephoneColumn = new DataGridViewTextBoxColumn();
                        telephoneColumn.DataPropertyName = "Telephone";
                        telephoneColumn.HeaderText = "Telephone";

                        DataGridViewTextBoxColumn roleColumn = new DataGridViewTextBoxColumn();
                        roleColumn.DataPropertyName = "Role";
                        roleColumn.HeaderText = "Role";

                        // add columns to the DataGridView
                        tableUser.Columns.AddRange(idColumn, nameColumn, emailColumn, telephoneColumn, roleColumn);

                        // set DataGridView properties
                        tableUser.AutoGenerateColumns = false;
                        tableUser.DataSource = users;
                    }
                    else
                    {
                        MessageBox.Show("No user data found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    List<PersonClass> users = system.PersonManage.GetAllUserSearch(txtSearchUser.Text);
                    if (users.Count > 0)
                    {
                        // clear existing columns in the DataGridView
                        tableUser.Columns.Clear();

                        // add DataGridView columns
                        DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
                        idColumn.DataPropertyName = "Id";
                        idColumn.HeaderText = "ID";

                        DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
                        nameColumn.DataPropertyName = "Name";
                        nameColumn.HeaderText = "Name";

                        DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
                        emailColumn.DataPropertyName = "Email";
                        emailColumn.HeaderText = "Email";

                        DataGridViewTextBoxColumn telephoneColumn = new DataGridViewTextBoxColumn();
                        telephoneColumn.DataPropertyName = "Telephone";
                        telephoneColumn.HeaderText = "Telephone";

                        DataGridViewTextBoxColumn roleColumn = new DataGridViewTextBoxColumn();
                        roleColumn.DataPropertyName = "Role";
                        roleColumn.HeaderText = "Role";

                        // add columns to the DataGridView
                        tableUser.Columns.AddRange(idColumn, nameColumn, emailColumn, telephoneColumn, roleColumn);

                        // set DataGridView properties
                        tableUser.AutoGenerateColumns = false;
                        tableUser.DataSource = users;
                    }
                    else
                    {
                        MessageBox.Show("No user data found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // check if any users are found

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                //check if there is a current row selected in the DataGridView
                if (tableUser.CurrentRow != null)
                {
                    // get the selected user from the DataGridView
                    UserClass selectedUser = tableUser.CurrentRow.DataBoundItem as UserClass;

                    //check if the selectedUser is not null
                    if (selectedUser != null)
                    {
                        //use the id value from the UserClass object
                        int userId = selectedUser.Id;
                        string selectedRole = comboBoxFilter.SelectedItem.ToString();

                        // create an instance of UoGSystem to perform the deletion
                        UoGSystem system = new UoGSystem();
                        if (selectedRole.ToLower() == "student")
                        {

                            system.StudentManage.DeleteStudent(userId);
                        }
                        else if (selectedRole.ToLower() == "teacher")
                        {

                            system.TeacherManage.DeleteTeacher(userId);
                        }
                        else if (selectedRole.ToLower() == "user")
                        {
                            // display a message indicating that direct deletion is not allowed for 'user'
                            MessageBox.Show("Direct deletion of 'user' is not allowed. Please select 'student' or 'teacher' in the dropdown instead.", "Invalid Role", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        //Reload user data based on the currently selected filter
                        LoadUserData(comboBoxFilter.SelectedItem.ToString().ToLower());
                    }
                    else
                    {
                        //if selectedUser is null, show a warning message
                        MessageBox.Show("No data associated with the selected row.", "Invalid Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // if no row is selected, show a warning message
                    MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // show an error message if an exception occurs during deletion
                MessageBox.Show("ERROR when deleting user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            using (AddStudent ads = new AddStudent())
            {
                // Set the label text for Add New Student
                ads.lbl = "Add New Student";
                ads.ShowDialog(); // Show the AddStudent form as a dialog
            }

        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            using (AddTeacher adt = new AddTeacher())
            {
                // Set the label text for Add New Teacher
                adt.lbl = "Add New Teacher";
                adt.ShowDialog(); // Show the AddTeacher form as a dialog
            }
        }

        /* public class PersonClass : UserClass { }*/


    }
}
