using comp1551.Account;
using comp1551.Subject;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static comp1551.utils;

namespace comp1551.ExtensionWinform
{
    public partial class Setting : Form
    {
        private Main mainForm; // Field to store the reference to the Main form

        public Setting(Main mainForm) // Constructor accepting a Main form reference
        {
            InitializeComponent();
            this.mainForm = mainForm; // Store the reference to the Main form
        }

        // this func is executed when the user click Log Out button

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Hide all forms except the Login form
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() != typeof(Login))
                {
                    form.Hide();
                }
            }

            // Show the Login form
            using (Login lg = new Login())
            {
                lg.ShowDialog();
                GlobalVariables.UserId = 0;
                GlobalVariables.UserName = "";
            }

            // Close the current form (Setting form)
            this.Close();
        }

        // this func is executed when the user click account button
        private void btnAccount_Click(object sender, EventArgs e)
        {
            /*this.Close();
            using (AccountDetails ad = new AccountDetails())
            {
                ad.ShowDialog();
            }*/
            if (mainForm != null)
            {
                mainForm.loadForm(new AccountDetails());
            }
            else
            {
                MessageBox.Show("Main form not found.");
            }
        }

        // this func is executed when the user click subjects button
        private void btnSubject_Click(object sender, EventArgs e)
        {
          /*  this.Close();
            mainForm.loadForm(new Subjects()); // Use the loadForm method of the Main form
*/
            if (mainForm != null)
            {
                mainForm.loadForm(new Subjects());
            }
            else
            {
                MessageBox.Show("Main form not found.");
            }
        }
    }
}
