using comp1551.Account;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static comp1551.utils;

namespace comp1551.ExtensionWinform
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
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
            this.Close();
            using (AccountDetails ad = new AccountDetails())
            {
                ad.ShowDialog();
            }
        }

        // this func is executed when the user click subjects button
        private void btnSubject_Click(object sender, EventArgs e)
        {
            this.Close();
            using (Subjects s = new Subjects())
            {
                s.ShowDialog();
            }
        }
    }
}
