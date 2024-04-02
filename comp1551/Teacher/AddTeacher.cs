using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;
using static comp1551.utils;
using System.Security.Cryptography.X509Certificates;
using static comp1551.UserClass;
using comp1551.User;

namespace comp1551.Teacher
{
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private Database db = new Database(); // database object for handling database operations

        private KeyValuePair<int, string> selectedFaculty; // selected faculty (key-value pair of facultId and name)
        public string lbl; // label for the form
        public int teacherId; // id of the teacher
        byte[] fileName; // a byte array to store the img data
        private byte[] imageBytes; // a byte array to store the img data


        // method to convert an Image to a byte array
        byte[] ImageToByteList(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        // func to convert a base64 string to an Image
        private Image ConvertBase64ToImage(string base64String)
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                return Image.FromStream(new MemoryStream(imageBytes));
            }
            catch (Exception ex)
            {
                // Show error message if conversion fails
                MessageBox.Show($"Error converting to image: {ex.Message}");
                return null;
            }
        }

        // func to populate the Faculties ListBox
        private void PopulateFacultiesListBox()
        {
            try
            {
                // open database connection
                db.OpenConnection();

                // query to get faclties
                string getFacultiesQuery = "SELECT Id, Name FROM Faculty";

                // execute the query and get the DataTable
                DataTable facultiesTable = db.ExecuteQuery(getFacultiesQuery);

                // iterate through each row and add to the ListBox as a key-value pair
                foreach (DataRow row in facultiesTable.Rows)
                {
                    int facultyId = Convert.ToInt32(row["Id"]);
                    string facultyName = row["Name"].ToString();
                    listBoxFaculties.Items.Add(new KeyValuePair<int, string>(facultyId, facultyName));
                }

                // close database connection
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                // show error message if an exception occurs
                MessageBox.Show($"Error loading faculties: {ex.Message}");
            }
        }

        // func called when the AddTeacher form loads
        private void AddTeacher_Load(object sender, EventArgs e)
        {
            // populate the Faculties ListBox
            PopulateFacultiesListBox();

            // set the label text based on the provided label
            lblAddTeacher.Text = lbl;

            // check if the label text is "Add New Teacher"
            if (lblAddTeacher.Text == "Add New Teacher")
            {
                // set the button text to "Add"
                btnAddTeacher.Text = "Add";
            }
            // check if the label text is "Update Teacher"
            else if (lblAddTeacher.Text == "Update Teacher")
            {
                // set the button text to "Update"
                btnAddTeacher.Text = "Update";

                try
                {
                    // populate the teacher's information
                    db.OpenConnection();

                    // query to get the teacher's information
                    string getTeacherQuery = $"SELECT u.Name, u.Email, u.Telephone, u.Image, t.Qualifications, t.subject1, t.subject2, f.Id AS FacultyId, f.Name AS FacultyName " +
                        $"FROM User u " +
                        $"JOIN Teacher t ON u.Id = t.UserId " +
                        $"LEFT JOIN Faculty f ON t.FacultyId = f.Id " +
                        $"WHERE u.Id = '{teacherId}'";

                    // execute the query and get the DataTable
                    DataTable teacherTable = db.ExecuteQuery(getTeacherQuery);

                    if (teacherTable.Rows.Count > 0)
                    {
                        // Set the text boxes with the teacher's information
                        txtAddTeacherName.Text = teacherTable.Rows[0]["Name"].ToString();
                        txtAddTeacherEmail.Text = teacherTable.Rows[0]["Email"].ToString();
                        txtAddTeacherTelephone.Text = teacherTable.Rows[0]["Telephone"].ToString();
                        txtAddTeacherQualifications.Text = teacherTable.Rows[0]["Qualifications"].ToString();
                        txtAddTeacherSubject1.Text = teacherTable.Rows[0]["Subject1"].ToString();
                        txtAddTeacherSubject2.Text = teacherTable.Rows[0]["Subject2"].ToString();

                        // ceck if the Image column in the database is not null or empty
                        if (teacherTable.Rows[0]["Image"] != DBNull.Value && !string.IsNullOrEmpty(teacherTable.Rows[0]["Image"].ToString()))
                        {
                            // convert the Base64 string to an Image and set it as the PictureBox background image
                            string imageBase64 = teacherTable.Rows[0]["Image"].ToString();
                            Image image = ConvertBase64ToImage(imageBase64);
                            if (image != null)
                            {
                                pictureboxAddTeacher.BackgroundImage = image;
                                pictureboxAddTeacher.BackgroundImageLayout = ImageLayout.Zoom;
                            }
                        }
                        else
                        {
                            pictureboxAddTeacher.BackgroundImage = null;
                        }

                        int facultyId = Convert.ToInt32(teacherTable.Rows[0]["FacultyId"]);
                        foreach (KeyValuePair<int, string> item in listBoxFaculties.Items)
                        {
                            if (item.Key == facultyId)
                            {
                                listBoxFaculties.SelectedItem = item;
                                selectedFaculty = item;
                                break;
                            }
                        }
                    }

                    // close database connection
                    db.CloseConnection();
                }
                catch (Exception ex)
                {
                    // show error message if an exception occurs
                    MessageBox.Show($"Error loading teacher information: {ex.Message}");
                }
            }
        }


        // evvent handler when the Upload LinkLabel is clicked
        private void linkLblAddTeacherUpload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (sender is LinkLabel)
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                DialogResult result = fileDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fileDialog.FileName))
                {
                    try
                    {
                        if (pictureboxAddTeacher != null && pictureboxAddTeacher.BackgroundImage != null)
                        {
                            pictureboxAddTeacher.BackgroundImage.Dispose();
                        }
                        byte[] fileBytes = File.ReadAllBytes(fileDialog.FileName);
                        using (MemoryStream ms = new MemoryStream(fileBytes))
                        {
                            Image image = Image.FromStream(ms);
                            pictureboxAddTeacher.BackgroundImage = new Bitmap(image);
                            pictureboxAddTeacher.BackgroundImageLayout = ImageLayout.Zoom;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}");
                    }
                }
            }
        }



        // func called when the Add/Update Teacher button is clicked
        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            // Check if the teacher name, email, and telephone,... fields are empty
            if (string.IsNullOrWhiteSpace(txtAddTeacherName.Text) ||
                string.IsNullOrWhiteSpace(txtAddTeacherEmail.Text) ||
                string.IsNullOrWhiteSpace(txtAddTeacherTelephone.Text) ||
                string.IsNullOrWhiteSpace(txtAddTeacherSubject1.Text) ||
                string.IsNullOrWhiteSpace(txtAddTeacherSubject2.Text)
                )
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }

            if (!IsValidEmail(txtAddTeacherEmail.Text) || !IsValidPhoneNumber(txtAddTeacherTelephone.Text))
            {
                MessageBox.Show("Please enter valid email or phone");

                return;
            }


            if (lblAddTeacher.Text == "Add New Teacher")
            {
                if (listBoxFaculties.SelectedItem == null)
                {
                    MessageBox.Show("Please select a Faculty before adding the teacher.");
                    return;
                }
                else
                {
                    selectedFaculty = (KeyValuePair<int, string>)listBoxFaculties.SelectedItem;
                    try
                    {
                        string base64Image = pictureboxAddTeacher.BackgroundImage != null ? ImageToBase64(pictureboxAddTeacher.BackgroundImage) : null;
                        TeacherClass newTeacher = new TeacherClass
                        {
                            Name = txtAddTeacherName.Text,
                            Email = txtAddTeacherEmail.Text,
                            Telephone = txtAddTeacherTelephone.Text
                        };

                        newTeacher.SetImage(base64Image);
                        newTeacher.SetSalary(0);
                        newTeacher.SetSubject1(txtAddTeacherSubject1.Text);
                        newTeacher.SetSubject2(txtAddTeacherSubject2.Text);
                        newTeacher.SetFacultyId(selectedFaculty.Key);
                        newTeacher.SetQualifications(txtAddTeacherQualifications.Text);

                        UoGSystem system = new UoGSystem();
                        system.TeacherManage.AddTeacher(newTeacher);
                        ClearForm();
                        TeacherDetails teacherDetailsForm = Application.OpenForms["TeacherDetails"] as TeacherDetails;
                        teacherDetailsForm?.LoadTeacherData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error adding teacher: {ex.Message}");
                    }
                    finally
                    {
                        TeacherDetails teacherDetailsForm = Application.OpenForms["TeacherDetails"] as TeacherDetails;
                        teacherDetailsForm?.LoadTeacherData();
                        UserDetails userDetailForm = Application.OpenForms["UserDetails"] as UserDetails;
                        userDetailForm?.LoadUserData("user");
                    }
                }
            }
            else if (lblAddTeacher.Text == "Update Teacher")
            {
                if (listBoxFaculties.SelectedItem == null)
                {
                    MessageBox.Show("Please select a Faculty before updating the teacher.");
                    return;
                }
                else
                {
                    selectedFaculty = (KeyValuePair<int, string>)listBoxFaculties.SelectedItem;
                    try
                    {
                        imageBytes = pictureboxAddTeacher.BackgroundImage != null ? ImageToByteList(pictureboxAddTeacher.BackgroundImage) : null;
                        string base64Image = imageBytes != null ? Convert.ToBase64String(imageBytes) : null;
                        TeacherClass updatedTeacher = new TeacherClass
                        {
                            Name = txtAddTeacherName.Text,
                            Email = txtAddTeacherEmail.Text,
                            Telephone = txtAddTeacherTelephone.Text
                        };

                        updatedTeacher.SetFacultyId(selectedFaculty.Key);
                        updatedTeacher.SetQualifications(txtAddTeacherQualifications.Text);
                        updatedTeacher.SetSubject1(txtAddTeacherSubject1.Text);
                        updatedTeacher.SetSubject2(txtAddTeacherSubject2.Text);
                        updatedTeacher.SetImage(base64Image);
                        UoGSystem system = new UoGSystem();
                        system.TeacherManage.UpdateTeacher(teacherId, updatedTeacher);
                        this.Close();
                        TeacherDetails teacherDetailsForm = Application.OpenForms["TeacherDetails"] as TeacherDetails;
                        teacherDetailsForm?.LoadTeacherData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating teacher information: {ex.Message}");
                    }
                    finally
                    {
                        TeacherDetails teacherDetailsForm = Application.OpenForms["TeacherDetails"] as TeacherDetails;
                        teacherDetailsForm?.LoadTeacherData();
                        UserDetails userDetailForm = Application.OpenForms["UserDetails"] as UserDetails;
                        userDetailForm?.LoadUserData("user");
                    }
                }
            }
        }




        // func to convert an Image object to a Base64 string
        private string ImageToBase64(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Jpeg);
                byte[] imageBytes = ms.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        //  func to clear the form fields
        private void ClearForm()
        {
            txtAddTeacherName.Text = "";
            txtAddTeacherTelephone.Text = "";
            txtAddTeacherEmail.Text = "";
            txtAddTeacherQualifications.Text = "";
            pictureboxAddTeacher.BackgroundImage = null;
        }
    }
}
