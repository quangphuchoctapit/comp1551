using comp1551.Account;
using comp1551.Class;
using comp1551.ExtensionWinform;
using comp1551.Faculty;
using comp1551.Student;
using comp1551.Subject;
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
using static comp1551.utils;

namespace comp1551
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            loadForm(new MainPage());
            lblUsername.Text = GlobalVariables.UserName;
        }

        public void loadForm(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            loadForm(new StudentDetails());
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            loadForm(new TeacherDetails());

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            loadForm(new AccountDetails());

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            loadForm(new MainPage());
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            loadForm(new SubjectDetails());
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            loadForm(new ClassDetails());
        }

        private void btnFaculty_Click(object sender, EventArgs e)
        {
            loadForm(new FacultyDetails());
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            loadForm(new Setting());
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSetting_Click_1(object sender, EventArgs e)
        {

        }
    }
}
