using comp1551.Teacher;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using static comp1551.UserClass;
using static comp1551.utils;

namespace comp1551.Student
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private Image loadedImage;
        private Database db = new Database(); // Database object for handling database operations
        private KeyValuePair<int, string> selectedFaculty; // Selected faculty (key-value pair of faculty ID and name)
        private KeyValuePair<int, string> selectedClass; // Selected class (key-value pair of class ID and name)
        private byte[] fileName; // A byte array to store the image data
        public int studentId; // ID of the student
        public string lbl; // Label for the form

        // this func will be execeuted when the user clicks Upload link label
        private void linkLblUpload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Load the selected image into the PictureBox
                using (Image tempImage = Image.FromFile(fileDialog.FileName))
                {
                    pictureboxAddStudent.BackgroundImage = new Bitmap(tempImage);
                    pictureboxAddStudent.BackgroundImageLayout = ImageLayout.Zoom;
                }
            }
        }


        // Method to convert a Base64 string to an Image
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

        // event handler when the AddStudent form loads
        private void AddStudent_Load(object sender, EventArgs e)
        {
            lblAddStudent.Text = lbl;
            // different conditions with different assign attribute to class btnAddStudent (button Add/Update)
            if (lblAddStudent.Text == "Add New Student")
            {
                btnAddStudent.Text = "Add";
                PopulateFacultiesListBox();
                PopulateClassesListBox();
            }
            else if (lblAddStudent.Text == "Update Student")
            {
                btnAddStudent.Text = "Update";
                PopulateFacultiesListBox();
                PopulateClassesListBox();
                try
                {
                    db.OpenConnection();
                    // this mysql query is used to get all student data based on userId(studentId variable)
                    string getStudentQuery = $"SELECT u.Id, u.Name, u.Email, u.Telephone, s.currSubject1 As CurrentSubject1, s.currSubject2 As CurrentSubject2, s.prevSubject1 AS PreviousSubject1, s.prevSubject2 As PreviousSubject2, u.Image, f.Id AS FacultyId, f.Name AS FacultyName, c.Id AS ClassId, c.Name AS ClassName " +
                                "FROM User u " +
                                "JOIN Student s ON u.Id = s.UserId " +
                                "LEFT JOIN Faculty f ON s.FacultyId = f.Id " +
                                "LEFT JOIN Class c ON s.ClassId = c.Id " +
                                $"WHERE u.Id = '{studentId}'";
                    DataTable existingStudentTable = db.ExecuteQuery(getStudentQuery);

                    if (existingStudentTable.Rows.Count > 0)
                    {
                        txtAddStudentName.Text = existingStudentTable.Rows[0]["Name"].ToString();
                        txtAddStudentTelephone.Text = existingStudentTable.Rows[0]["Telephone"].ToString();
                        txtAddStudentEmail.Text = existingStudentTable.Rows[0]["Email"].ToString();
                        txtAddStudentSubject1.Text = existingStudentTable.Rows[0]["CurrentSubject1"].ToString();
                        txtAddStudentSubject2.Text = existingStudentTable.Rows[0]["CurrentSubject2"].ToString();
                        txtAddStudentPrevSubject1.Text = existingStudentTable.Rows[0]["PreviousSubject1"].ToString();
                        txtAddStudentPrevSubject2.Text = existingStudentTable.Rows[0]["PreviousSubject2"].ToString();

                        // Check if the Image column in the database is not null or empty
                        if (existingStudentTable.Rows[0]["Image"] != DBNull.Value && !string.IsNullOrEmpty(existingStudentTable.Rows[0]["Image"].ToString()))
                        {
                            // Convert the Base64 string to an Image and set it as the PictureBox background image
                            string imageBase64 = existingStudentTable.Rows[0]["Image"].ToString();
                            Image image = ConvertBase64ToImage(imageBase64);
                            if (image != null)
                            {
                                pictureboxAddStudent.BackgroundImage = image;
                                pictureboxAddStudent.BackgroundImageLayout = ImageLayout.Zoom;
                            }
                        }
                        else
                        {
                            pictureboxAddStudent.BackgroundImage = null;
                        }

                        int facultyId = Convert.ToInt32(existingStudentTable.Rows[0]["FacultyId"]);
                        int classId = Convert.ToInt32(existingStudentTable.Rows[0]["ClassId"]);

                        foreach (KeyValuePair<int, string> item in listBoxFaculties.Items)
                        {
                            if (item.Key == facultyId)
                            {
                                listBoxFaculties.SelectedItem = item;
                                selectedFaculty = item;
                                break;
                            }
                        }

                        foreach (KeyValuePair<int, string> item in listBoxClassId.Items)
                        {
                            if (item.Key == classId)
                            {
                                listBoxClassId.SelectedItem = item;
                                selectedClass = item;
                                break;
                            }
                        }
                    }

                    db.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading student information: {ex.Message}");
                }
            }
        }

        // Method to populate the Faculties ListBox
        private void PopulateFacultiesListBox()
        {
            try
            {
                db.OpenConnection();
                string getFacultiesQuery = "SELECT Id, Name FROM Faculty";
                DataTable facultiesTable = db.ExecuteQuery(getFacultiesQuery);

                foreach (DataRow row in facultiesTable.Rows)
                {
                    int facultyId = Convert.ToInt32(row["Id"]);
                    string facultyName = row["Name"].ToString();
                    listBoxFaculties.Items.Add(new KeyValuePair<int, string>(facultyId, facultyName));
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading faculties: {ex.Message}");
            }
        }

        // Method to populate the Classes ListBox
        private void PopulateClassesListBox()
        {
            try
            {
                db.OpenConnection();
                string getClassesQuery = "SELECT Id, Name FROM Class";
                DataTable classesTable = db.ExecuteQuery(getClassesQuery);

                foreach (DataRow row in classesTable.Rows)
                {
                    int classId = Convert.ToInt32(row["Id"]);
                    string className = row["Name"].ToString();
                    listBoxClassId.Items.Add(new KeyValuePair<int, string>(classId, className));
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading classes: {ex.Message}");
            }
        }

        // this func will be execeuted when the user clicks add btn
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // Initialize base64Image as null. It will be used to store the base64 string of the image if any.
            string base64Image = null;

            // Check if the PictureBox has a background image before attempting to convert it.
            if (pictureboxAddStudent.BackgroundImage != null)
            {
                // Convert the background image to a base64 string.
                base64Image = ConvertImageToBase64(pictureboxAddStudent.BackgroundImage);
            }

            // handling for adding a new student.
            if (lblAddStudent.Text == "Add New Student")
            {
                // ensure both Faculty and Class are selected.
                if (listBoxFaculties.SelectedItem == null || listBoxClassId.SelectedItem == null)
                {
                    MessageBox.Show("Please select both a Faculty and a Class before adding the student.");
                }
                else
                {
                    // extract selected Faculty and Class.
                    selectedFaculty = (KeyValuePair<int, string>)listBoxFaculties.SelectedItem;
                    selectedClass = (KeyValuePair<int, string>)listBoxClassId.SelectedItem;

                    try
                    {
                        // create a new StudentClass instance and fill it with data from form controls.
                        StudentClass newStudent = new StudentClass
                        {
                            Name = txtAddStudentName.Text,
                            Email = txtAddStudentEmail.Text,
                            Telephone = txtAddStudentTelephone.Text,
                        };
                        newStudent.SetImage(base64Image);

                        // Set values using setter methods
                        newStudent.SetPreviousSubject1(txtAddStudentPrevSubject1.Text);
                        newStudent.SetPreviousSubject2(txtAddStudentPrevSubject2.Text);
                        newStudent.SetCurrentSubject1(txtAddStudentSubject1.Text);
                        newStudent.SetCurrentSubject2(txtAddStudentSubject2.Text);
                        newStudent.SetFacultyId(selectedFaculty.Key);
                        newStudent.SetClassId(selectedClass.Key);


                        // assuming you have a method to add a student in your system, it's called here.
                        UoGSystem system = new UoGSystem();
                        system.StudentManage.AddStudent(newStudent);

                        StudentDetails studentDetailsForm = Application.OpenForms["StudentDetails"] as StudentDetails;
                        studentDetailsForm?.LoadStudentData();

                        MessageBox.Show("Student added successfully.");
                        ClearForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error adding student: {ex.Message}");
                    }
                }
            }
            // handling for updating an existing student.
            else if (lblAddStudent.Text == "Update Student")
            {
                if (listBoxFaculties.SelectedItem == null || listBoxClassId.SelectedItem == null)
                {
                    MessageBox.Show("Please select both a Faculty and a Class before updating the student.");
                }
                else
                {
                    // extract selected Faculty and Class.
                    selectedFaculty = (KeyValuePair<int, string>)listBoxFaculties.SelectedItem;
                    selectedClass = (KeyValuePair<int, string>)listBoxClassId.SelectedItem;

                    try
                    {
                        // check if the base64Image is null and loadedImage is not null
                        if (base64Image == null && loadedImage != null)
                        {
                            // Convert the loadedImage to base64
                            base64Image = ConvertImageToBase64(loadedImage);
                        }

                        // create an updated StudentClass instance with new data.
                        StudentClass updatedStudent = new StudentClass
                        {
                            Name = txtAddStudentName.Text,
                            Email = txtAddStudentEmail.Text,
                            Telephone = txtAddStudentTelephone.Text,
                        };
                        updatedStudent.SetImage(base64Image);

                        // Set values using setter methods
                        updatedStudent.SetPreviousSubject1(txtAddStudentPrevSubject1.Text);
                        updatedStudent.SetPreviousSubject2(txtAddStudentPrevSubject2.Text);
                        updatedStudent.SetCurrentSubject1(txtAddStudentSubject1.Text);
                        updatedStudent.SetCurrentSubject2(txtAddStudentSubject2.Text);
                        updatedStudent.SetFacultyId(selectedFaculty.Key);
                        updatedStudent.SetClassId(selectedClass.Key);


                        // Assuming you have a method to update a student in your system, it's called here.
                        UoGSystem system = new UoGSystem();
                        system.StudentManage.UpdateStudent(studentId, updatedStudent);

                        MessageBox.Show("Student information updated successfully.");
                        this.Close();

                        StudentDetails studentDetailsForm = Application.OpenForms["StudentDetails"] as StudentDetails;
                        studentDetailsForm?.LoadStudentData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating student information: {ex.Message}");
                    }
                }
            }
        }

        // when the user click an itme of listbox faculties, this func will be executed
        private void listBoxFaculties_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFaculties.SelectedItem != null)
            {
                selectedFaculty = (KeyValuePair<int, string>)listBoxFaculties.SelectedItem;
                int facultyId = selectedFaculty.Key;
                string facultyName = selectedFaculty.Value;
                MessageBox.Show($"Selected Faculty: ID - {facultyId}, Name - {facultyName}");
            }
        }

        // when the user click an itme of listbox classId, this func will be executed

        private void listBoxClassId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxClassId.SelectedItem != null)
            {
                selectedClass = (KeyValuePair<int, string>)listBoxClassId.SelectedItem;
                int classId = selectedClass.Key;
                string className = selectedClass.Value;
                MessageBox.Show($"Selected Class: ID - {classId}, Name - {className}");
            }
        }


        // this func is used for converting image got from picturebox and convert it to base 64 string
        private string ConvertImageToBase64(Image img)
        {
            if (img == null) return null;

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // Save the image to the memory stream using PNG format
                    img.Save(ms, ImageFormat.Png);

                    // Convert the image bytes to a base64 string
                    byte[] imageBytes = ms.ToArray();
                    return Convert.ToBase64String(imageBytes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error converting image to base64: {ex.Message}");
                return null;
            }
        }

        // this func is used to clear all the  current inputs, and picturebox
        private void ClearForm()
        {
            txtAddStudentName.Text = "";
            txtAddStudentTelephone.Text = "";
            txtAddStudentEmail.Text = "";
            pictureboxAddStudent.BackgroundImage = null;
        }
    }
}
