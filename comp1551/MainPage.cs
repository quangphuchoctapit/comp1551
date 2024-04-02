using comp1551.Account;
using comp1551.Class;
using comp1551.ExtensionWinform;
using comp1551.Faculty;
using comp1551.Student;
using comp1551.Subject;
using comp1551.Teacher;
using comp1551.User;
using System;
using System.Windows.Forms;
using static comp1551.UserClass;
using static comp1551.utils;

namespace comp1551
{
    public partial class MainPage : Form
    {
        private Main mainForm; // Field to store the reference to the Main form

        public MainPage(Main mainForm) // Constructor accepting a Main form reference
        {
            InitializeComponent();
            this.mainForm = mainForm; // Store the reference to the Main form
        }

        // create a global variable for checking which role the current logged in user is
        public string userRole;

        // Event handler for "Student" button click
        private void btnStudent_Click(object sender, EventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.loadForm(new StudentDetails());
            }
            else
            {
                MessageBox.Show("Main form not found.");
            }
        }

        // Event handler for "Subject" button click
        private void btnSubject_Click(object sender, EventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.loadForm(new SubjectDetails());
            }
            else
            {
                MessageBox.Show("Main form not found.");
            }
            // OpenChildForm(new SubjectDetails()); // Open the SubjectDetails form as a child
        }

        // Event handler for "Class" button click
        private void btnClass_Click(object sender, EventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.loadForm(new ClassDetails());
            }
            else
            {
                MessageBox.Show("Main form not found.");
            }

            // OpenChildForm(new ClassDetails()); // Open the ClassDetails form as a child
        }

        // Event handler for "Salary" button click
        private void btnSalary_Click(object sender, EventArgs e)
        {
            userRole = GlobalVariables.UserRole;
            if (userRole == "admin")
            {
                if (mainForm != null)
                {
                    mainForm.loadForm(new ChoosingSalaryModal());
                }
                else
                {
                    MessageBox.Show("Main form not found.");
                }
                //OpenChildForm(new ChoosingSalaryModal()); // Open the ChoosingSalaryModal form as a child
            }
            else
            {
                if (mainForm != null)
                {
                    mainForm.loadForm(new AccountDetails());
                }
                else
                {
                    MessageBox.Show("Main form not found.");
                }
                //OpenChildForm(new AccountDetails()); // Open the AccountDetails form as a child
            }
        }

        // Event handler for "Teacher" button click
        private void btnTeacher_Click(object sender, EventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.loadForm(new TeacherDetails());
            }
            else
            {
                MessageBox.Show("Main form not found.");
            }
            // OpenChildForm(new TeacherDetails()); // Open the TeacherDetails form as a child
        }

        // Event handler for "Faculty" button click
        private void btnFaculty_Click(object sender, EventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.loadForm(new FacultyDetails());
            }
            else
            {
                MessageBox.Show("Main form not found.");
            }
            //OpenChildForm(new FacultyDetails()); // Open the FacultyDetails form as a child
        }

        // Event handler for "Setting" button click
        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (mainForm != null)
            {
                Setting settingForm = new Setting(mainForm);
                mainForm.loadForm(settingForm);
            }
            else
            {
                MessageBox.Show("Main form not found.");
            }
            // OpenChildForm(new Setting()); // Open the Setting form as a child
        }

        // when the form first loaded, it check every conditions below, to make changes to the Mainpage winform.
        // specifically, it change the location and the visibility of specific buttons
        private void MainPage_Load(object sender, EventArgs e)
        {
            userRole = GlobalVariables.UserRole;
            linkLabelUsers.Visible = false;
            if (userRole == "student")
            {
                btnTeacher.Visible = false;
                btnClass.Width = 326;
                btnSalary.Visible = false;
                linkLabelUsers.Visible = false;

                btnTest.Width = 323;
            }
            if (userRole == "teacher")
            {
                linkLabelUsers.Visible = false;

            }
            if (userRole == "admin")
            {
                linkLabelUsers.Visible = true;
            }
        }

        // Event handler for "List User" link label click
        private void linkLabelUsers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.loadForm(new UserDetails());
            }
            else
            {
                MessageBox.Show("Main form not found.");
            }
            // OpenChildForm(new UserDetails()); // open userDetails winform
        }

        
    }
}
