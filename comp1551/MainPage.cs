using comp1551.Account;
using comp1551.Class;
using comp1551.ExtensionWinform;
using comp1551.Faculty;
using comp1551.Salary;
using comp1551.Student;
using comp1551.Subject;
using comp1551.Teacher;
using comp1551.User;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static comp1551.utils;

namespace comp1551
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // create a global variable for checking which role the current logged in user is
        public string userRole;

        // Method to open child forms as modeless dialogs
        private void OpenChildForm(Form childForm)
        {
            childForm.ShowDialog(); // Show the child form as a modeless dialog
        }

        // Event handler for "Student" button click
        private void btnStudent_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AccountDetails()); // Open the AccountDetails form as a child
        }

        // Event handler for "Student" button click
        private void btnStudent_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new StudentDetails()); // Open the StudentDetails form as a child
        }

        // Event handler for "Subject" button click
        private void btnSubject_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SubjectDetails()); // Open the SubjectDetails form as a child
        }

        // Event handler for "Class" button click
        private void btnClass_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ClassDetails()); // Open the ClassDetails form as a child
        }

        // Event handler for "Salary" button click
        private void btnSalary_Click(object sender, EventArgs e)
        {
            userRole = GlobalVariables.UserRole;
            if (userRole == "admin")
            {
                OpenChildForm(new ChoosingSalaryModal()); // Open the ChoosingSalaryModal form as a child
            }
            else
            {
                OpenChildForm(new AccountDetails()); // Open the SalaryTeacherDetaisl form as a child
            }
        }

        // Event handler for "Teacher" button click
        private void btnTeacher_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TeacherDetails()); // Open the TeacherDetails form as a child
        }

        // Event handler for "Faculty" button click
        private void btnFaculty_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FacultyDetails()); // Open the FacultyDetails form as a child
        }

        // Event handler for "Setting" button click
        private void btnSetting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Setting()); // Open the Setting form as a child
        }

           // when the form first loaded, it check every conditions below, to make changes to the Mainpage winform.
           // specifically, it change the location and the visibility of specific buttons
        private void MainPage_Load_1(object sender, EventArgs e)
        {
            userRole = GlobalVariables.UserRole;
            linkLabelUsers.Visible = false;
            if (userRole == "student")
            {
                btnTeacher.Visible = false;
                btnClass.Width = 286;
                btnSalary.Visible = false;
                btnTest.Width = 286;
            }
            if (userRole == "teacher")
            {

            }
            if (userRole == "admin")
            {
                linkLabelUsers.Visible = true;
            }

        }

        // Event handler for "List User" link label click
        private void linkLabelUsers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new UserDetails()); // open userDetails winform
        }
    }
}
