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
    public partial class StudentSignup : Form
    {
        public StudentSignup()
        {
            InitializeComponent();
        }
        public int userId;

        // custom class to hold faculty information

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

        // custom class to hold class information

        private class ClassItem
        {
            public string ClassName { get; set; }
            public int Id { get; set; }
            public override string ToString()
            {
                return ClassName;
            }
                    }

        private void StudentSignup_Load(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();
                db.OpenConnection();

                // select the columns 'name', 'facultyId', and 'id' from the 'Subject' table
                string selectFacultysQuery = "SELECT name, facultyId, id FROM Faculty";

                // execute the query to get the subjects
                DataTable facultiesTable = db.ExecuteQuery(selectFacultysQuery);

                // clear existing items in the listBoxSubjects
                listboxFaculties.Items.Clear();

                // iterate through the DataTable rows and add each faculty to the listBox
                foreach (DataRow row in facultiesTable.Rows)
                {
                    // create a new SubjectItem with the 'name', 'facultyId', and 'id'
                    FacultyItem facultyItem = new FacultyItem
                    {
                        Name = row["name"].ToString(),
                        FacultyId = row["facultyId"].ToString(),
                        Id = Convert.ToInt32(row["id"])
                    };

                    // add the FacultyItem to the listBoxFaculties
                    listboxFaculties.Items.Add(facultyItem);
                }

                // select the columns 'name', 'facultyId', and 'id' from the 'Subject' table
                string selectClassQuery = "SELECT name, id FROM Class";

                // execute the query to get the subjects
                DataTable ClassesTable = db.ExecuteQuery(selectClassQuery);

                // clear existing items in the listBoxSubjects
                listBoxClassName.Items.Clear();

                // iterate through the DataTable rows and add each faculty to the listBox
                foreach (DataRow row in ClassesTable.Rows)
                {
                    // create a new SubjectItem with the 'name', 'facultyId', and 'id'
                    ClassItem classItem = new ClassItem
                    {
                        ClassName = row["name"].ToString(),
                        Id = Convert.ToInt32(row["id"])
                    };

                    // add the ClassItem to the listBoxFaculties
                    listBoxClassName.Items.Add(classItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading subjects: {ex.Message}");
            }
        }

        // insert (or raise error) when the user click the confirm button
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                // check if any item is selected in the listBoxFaculties
                if (listboxFaculties.SelectedItem != null)
                {
                    // get the selected FacultyItem
                    FacultyItem selectedFaculty = (FacultyItem)listboxFaculties.SelectedItem;
                    ClassItem selectedClass = (ClassItem)listBoxClassName.SelectedItem;

                    int facultyItemId = selectedFaculty.Id;

                    // get student information from the form
                    int classItemId = selectedClass.Id;

                    int studentGrade = Convert.ToInt32(txtGrade.Text);

                    // insert the student's information into the faculty_subjects table
                    try
                    {
                        // open database connection
                        Database db = new Database();
                        db.OpenConnection();

                        // create a new row in the 'student' table
                        string insertStudentQuery = $"INSERT INTO student (classId, grade, facultyId, userId) " +
                            $"VALUES ({classItemId}, {studentGrade}, {facultyItemId} , {userId})";

                        // execute the query to add the student to student
                        db.ExecuteNonQuery(insertStudentQuery);

                        // close database connection
                        db.CloseConnection();

                        // hide the current StudentSignup window
                        this.Hide();
                        using (Login lg = new Login())
                        {
                            lg.ShowDialog();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error inserting student into student: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a faculty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding student to Faculty Subjects: {ex.Message}");
            }
        }

    }
}
