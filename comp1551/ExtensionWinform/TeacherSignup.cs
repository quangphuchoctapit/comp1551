using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp1551.ExtensionWinform
{
    public partial class TeacherSignup : Form
    {
        public TeacherSignup()
        {
            InitializeComponent();
        }
        public int userId;


        // creaete a custom class to hold faculty data
        private class FacultyItem
        {
            public string Name { get; set; }
            public string FacultyId { get; set; }
            public int Id { get; set; }
            public override string ToString()
            {
                return $"{Name} ({FacultyId})";
            }
        }

        // this func will be executed when the form is first opened
        private void TeacherSignup_Load(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();
                db.OpenConnection();

                // Select the columns 'name', 'facultyId', and 'id' from the 'Subject' table
                string selectFacultysQuery = "SELECT name, facultyId, id FROM Faculty";

                // Execute the query to get the subjects
                DataTable facultiesTable = db.ExecuteQuery(selectFacultysQuery);

                // Clear existing items in the listBoxSubjects
                listboxFaculties.Items.Clear();

                // Iterate through the DataTable rows and add each faculty to the listBox
                foreach (DataRow row in facultiesTable.Rows)
                {
                    // Create a new SubjectItem with the 'name', 'facultyId', and 'id'
                    FacultyItem facultyItem = new FacultyItem
                    {
                        Name = row["name"].ToString(),
                        FacultyId = row["facultyId"].ToString(),
                        Id = Convert.ToInt32(row["id"])
                    };

                    // Add the FacultyItem to the listBoxFaculties
                    listboxFaculties.Items.Add(facultyItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading subjects: {ex.Message}");
            }
        }

        // this func will be executed when the user clicks Confirm btn
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any item is selected in the listBoxFaculties
                if (listboxFaculties.SelectedItem != null)
                {
                    // Get the selected FacultyItem
                    FacultyItem selectedFaculty = (FacultyItem)listboxFaculties.SelectedItem;

                    int facultyItemId = selectedFaculty.Id;
                    string teacherQualifications = txtQualifications.Text;
                    string teacherSubject1 = txtSubject1.Text;
                    string teacherSubject2 = txtSubject2.Text;

                    try
                    {
                        // Open database connection
                        Database db = new Database();
                        db.OpenConnection();

                        // Create a new row in the 'teacher' table  
                        string insertTeacherQuery = $"INSERT INTO Teacher (qualifications, userId, facultyId, subject1, subject2, salary) " +
                            $"VALUES ('{teacherQualifications}', {userId}, {facultyItemId}, '{teacherSubject1}', '{teacherSubject2}', 0)"; // Added single quotes around qualifications

                        // Execute the query to add the teacher
                        db.ExecuteNonQuery(insertTeacherQuery);

                        // Close database connection
                        db.CloseConnection();

                        // Hide the current TeacherSignup window
                        this.Hide();
                        using (Login lg = new Login())
                        {
                            lg.ShowDialog();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error inserting teacher into teacher: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a faculty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding teacher to Faculty Subjects: {ex.Message}");
            }
        }

    }
}

