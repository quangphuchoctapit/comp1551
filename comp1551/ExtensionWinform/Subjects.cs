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
using static comp1551.utils;

namespace comp1551.ExtensionWinform
{
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
        }

        // this func will be executed when the winform is inititally loaded
        private void Subjects_Load(object sender, EventArgs e)
        {
            UoGSystem system = new UoGSystem();

            // condition to chek the current user role, based on that to set visibility (btns and lbls are shown) on screen or not
            if (GlobalVariables.UserRole == "student")
            {
                // retrieve the previous subjects for the current student
                string[] previousSubjects = system.StudentManage.Get2PreviousSubjects(GlobalVariables.UserId);

                txtSubject1.Visible = false;
                txtSubject2.Visible = false;

                lblSubject1.Visible = false;
                lblSubject2.Visible = false;
                // display the previous subjects in the text boxes
                if (previousSubjects.Length > 0)
                {
                    txtPrevSubject1.Text = previousSubjects[0];
                    txtPrevSubject2.Text = previousSubjects[1];
                    
                }
                else
                {
                    MessageBox.Show("Previous subjects not found.");
                }

                // retrieve the current subjects for the current student
                string[] currentSubjects = system.StudentManage.Get2CurrentSubjects(GlobalVariables.UserId);

                // display the previous subjects in the text boxes
                if (currentSubjects.Length > 0)
                {
                    txtCurrentSubject1.Text = currentSubjects[0];
                    txtCurrentSubject2.Text = currentSubjects[1];
                }
                else
                {
                    MessageBox.Show("Current subjects not found.");
                }
            }
            else if (GlobalVariables.UserRole == "teacher")
            {
                // Retrieve the subjects for the current teacher
                string[] subjects = system.TeacherManage.Get2Subjects(GlobalVariables.UserId);

                txtCurrentSubject1.Visible = false;
                txtCurrentSubject2.Visible = false;
                txtPrevSubject1.Visible = false;
                txtPrevSubject2.Visible = false;

                    lblCurrentSubject1.Visible = false;
                lblCurrentSubject2.Visible = false;
                lblPrevSubject1.Visible = false;
                lblPrevSubject2.Visible = false;

                // Display the subjects in the text boxes
                if (subjects.Length == 2)
                {
                    txtSubject1.Text = subjects[0];
                    txtSubject2.Text = subjects[1];
                }
                else
                {
                    MessageBox.Show("Subjects not found.");
                }
            }
            else
            {
                txtCurrentSubject1.Visible = false;
                txtCurrentSubject2.Visible = false;
                txtPrevSubject1.Visible = false;
                txtPrevSubject2.Visible = false;
                txtSubject1.Visible = false;
                txtSubject2.Visible = false;
                lblCurrentSubject1.Visible = false;
                lblCurrentSubject2.Visible = false;
                lblPrevSubject1.Visible = false;
                lblPrevSubject2.Visible = false;
                lblSubject1.Visible = false;
                lblSubject2.Visible = false;
            }

        }

    }
}
