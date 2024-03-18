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
    public partial class ChoosingSalaryModal : Form
    {
        public ChoosingSalaryModal()
        {
            InitializeComponent();
        }
        // this func is used to open the expected winform
        private void OpenChildForm(Form childForm)
        {
            childForm.ShowDialog(); // Show the child form as a modeless dialog
        }

        // this func is executed when the user click teacher salary button
        private void btnTeacherSalary_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Salary.SalaryTeacherDetails()); // Open the SalaryTeacherDetails form as a child
        }

        // this func is executed when the user click teacher salary button

        private void btnAdminSalary_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Salary.SalaryAdminDetails()); // Open the SalaryTeacherDetails form as a child
        }


        // this func will be executed when the winform is initially loaded
        private void ChoosingSalaryModal_Load(object sender, EventArgs e)
        {
            string userRole = GlobalVariables.UserRole;
            btnAdminSalary.Enabled = false;
            // if the current user role is not admin, disbled the button(in fact, this is deprecated because only admin can get access to this ChoosingSlaaryModal)
            if (userRole == "admin")
            {
                btnAdminSalary.Enabled = true;
            }
        }
    }
}
