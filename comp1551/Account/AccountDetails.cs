using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static comp1551.UserClass;
using static comp1551.utils;

namespace comp1551.Account
{
    public partial class AccountDetails : Form
    {
        public AccountDetails()
        {
            InitializeComponent();
        }

        private Database db = new Database();  // creating an instance of the Database class for database operations
        private byte[] imageBytes;  // a byte array to store the image data

        // event handler when the 'Upload' link is clicked
        private void linkLblAccountUpload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                // retrieve the user file image
                pictureboxAccount.BackgroundImage = Image.FromFile(fileDialog.FileName);
                pictureboxAccount.BackgroundImageLayout = ImageLayout.Zoom;
                imageBytes = ImageToByteList(pictureboxAccount.BackgroundImage);
            }
        }

        // event handler when the form is loaded
        private void AccountDetails_Load(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();

                // query to retrieve user details based on the GlobalVariables.UserId
                string query = $"SELECT * FROM user WHERE id = {GlobalVariables.UserId}";
                DataTable userDetails = db.ExecuteQuery(query);

                txtAccountWorkingHours.Enabled = false;
                txtAccountSalary.Enabled = false;
                comboBoxAccountFullTime.Enabled = false;

                if (userDetails.Rows.Count > 0)
                {
                    DataRow userRow = userDetails.Rows[0];

                    // populate form fields with existing user information
                    txtAccountId.Text = GlobalVariables.UserId.ToString();
                    txtAccountRole.Text = userRow["role"].ToString();
                    txtAccountName.Text = userRow["name"].ToString();
                    txtAccountEmail.Text = userRow["email"].ToString();
                    txtAccountPassword.Text = userRow["password"].ToString();
                    txtAccountTelephone.Text = userRow["telephone"].ToString();

                    // check if the 'image' field is not null and not an empty string, then load the image
                    if (userRow["image"] != DBNull.Value)
                    {
                        string imageBase64 = userRow["image"].ToString();
                        if (!string.IsNullOrEmpty(imageBase64))
                        {
                            Image image = ConvertBase64ToImage(imageBase64);
                            if (image != null)
                            {
                                // display image to the user interface
                                pictureboxAccount.BackgroundImage = image;
                                pictureboxAccount.BackgroundImageLayout = ImageLayout.Zoom;
                            }
                        }
                    }
                    else
                    {
                        pictureboxAccount.BackgroundImage = null;
                        pictureboxAccount.BackgroundImageLayout = ImageLayout.Zoom;
                    }


                    // using OOP to use some methods from class UserClass
                    UoGSystem system = new UoGSystem();
                    if (GlobalVariables.UserRole == "admin")
                    {
                        txtAccountWorkingHours.Enabled = true;
                        txtAccountSalary.Enabled = true;
                        comboBoxAccountFullTime.Enabled = true;

                        decimal salary = system.AdminManage.GetAdminSalary();
                        bool isFullTime = system.AdminManage.ValidateFullTime();

                        // set the selected item in the comboBoxAccountFullTime
                        comboBoxAccountFullTime.SelectedItem = isFullTime ? "Yes" : "No";

                        txtAccountSalary.Text = salary.ToString();
                        decimal workingHours = system.AdminManage.GetAdminWorkingHours();
                        txtAccountWorkingHours.Text = workingHours.ToString();
                    }
                    else if (GlobalVariables.UserRole == "teacher")
                    {
                        decimal salary = system.TeacherManage.GetTeacherSalary(GlobalVariables.UserId);
                        txtAccountSalary.Text = salary.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("User not found.");
                }

                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching user details: {ex.Message}");
            }
        }



        // event handler when the 'Edit Account' button is clicked
        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();  // open the connection at the beginning of the try block

                UoGSystem system = new UoGSystem();
                if (GlobalVariables.UserRole == "admin")
                {
                    AdminClass updatedAdmin = new AdminClass
                    {
                        Name = txtAccountName.Text,
                        Email = txtAccountEmail.Text,
                        Telephone = txtAccountTelephone.Text,
                        Password = txtAccountPassword.Text,
                    };
                    updatedAdmin.SetSalary(Convert.ToDecimal(txtAccountSalary.Text));
                    updatedAdmin.SetWorkingHours(Convert.ToInt32(txtAccountWorkingHours.Text));
                    updatedAdmin.SetFullTime(comboBoxAccountFullTime.SelectedItem.ToString() == "Yes");

                    system.AdminManage.UpdateAdmin(GlobalVariables.UserId, updatedAdmin);
                    MessageBox.Show("Account updated successfully.");
                }
                else
                {
                    // for roles other than admin, execute the update query directly
                    string base64Image = ConvertImageToBase64(pictureboxAccount.BackgroundImage);
                    string updateQueryUser = $"UPDATE User SET Name = '{txtAccountName.Text}', Image = '{base64Image}', " +
                                             $"Email = '{txtAccountEmail.Text}', Telephone = '{txtAccountTelephone.Text}' " +
                                             $"WHERE Id = '{GlobalVariables.UserId}'";
                    db.ExecuteNonQuery(updateQueryUser);
                    MessageBox.Show("Account updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating account: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();  // close db connection in the finally block
            }
        }

        // method to convert Base64 string to Image
        private Image ConvertBase64ToImage(string base64String)
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Image image = Image.FromStream(ms);
                    return image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error converting to image: {ex.Message}");
                return null;
            }
        }

        // method to convert

        // Method to convert Image to Base64 string
        private string ConvertImageToBase64(Image img)
        {
            if (img == null)
            {
                return null;
            }

            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Jpeg);
                byte[] imageBytes = ms.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        // Method to convert Image to byte array
        private byte[] ImageToByteList(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
    }
}
