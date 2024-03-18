using comp1551.Class;
using comp1551.Student;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace comp1551.Faculty
{
    public partial class AddFaculty : Form
    {
        public AddFaculty()
        {
            InitializeComponent();
        }

        public int facultyID;  // variable to hold the ID of the faculty being added or updated
        public string lbl;  // variable to hold the label text for the form (which will be set in FacultyDetails.cs file)

        private Database db = new Database();  // creating an instance of the Database class

        // custom class to hold subject information
        private class SubjectItem
        {
            public string Name { get; set; }  // name of the subject
            public string SubjectId { get; set; }  // subject ID
            public int Id { get; set; }  // subject ID as integer

            // override ToString() to display item in the listBox
            public override string ToString()
            {
                return $"{Name} - {SubjectId}";
            }
        }

        // method to pre-select subjects associated with the current faculty
        private void SelectSubjectsForFaculty()
        {
            try
            {
                db.OpenConnection();

                // query to retrieve subjectIds associated with the current faculty
                string getFacultySubjectsQuery = $"SELECT subjectId FROM faculty_subjects WHERE facultyId = '{facultyID}'";
                DataTable facultySubjectsTable = db.ExecuteQuery(getFacultySubjectsQuery);

                // create a list to store items to select
                List<SubjectItem> itemsToSelect = new List<SubjectItem>();

                foreach (SubjectItem item in listboxSubjects.Items)
                {
                    int subjectId = item.Id;
                    DataRow[] result = facultySubjectsTable.Select($"subjectId = {subjectId}");

                    if (result.Length > 0)
                    {
                        itemsToSelect.Add(item);
                    }
                }

                foreach (SubjectItem item in itemsToSelect)
                {
                    listboxSubjects.SetSelected(listboxSubjects.Items.IndexOf(item), true);
                }

                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting subjects for faculty: {ex.Message}");
            }
        }

        // method to populate listBoxSubjects with data from the 'subject' table
        private void PopulateSubjectsListBox()
        {
            try
            {
                db.OpenConnection();

                string getSubjectsQuery = "SELECT Id, Name, SubjectId FROM subject";
                DataTable subjectsTable = db.ExecuteQuery(getSubjectsQuery);

                foreach (DataRow row in subjectsTable.Rows)
                {
                    int subjectId = Convert.ToInt32(row["Id"]);
                    string subjectName = row["Name"].ToString();
                    string subjectIdString = row["SubjectId"].ToString();
                    listboxSubjects.Items.Add(new SubjectItem { Id = subjectId, Name = subjectName, SubjectId = subjectIdString });
                }

                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading subjects: {ex.Message}");
            }
        }

        // event handler when the form is loaded
        private void AddFaculty_Load(object sender, EventArgs e)
        {
            lblAddFaculty.Text = lbl;
            // condition check if the user click add or edit button in FacultyDetails
            if (lblAddFaculty.Text == "Add New Faculty")
            {
                btnAddFaculty.Text = "Add";
            }
            else if (lblAddFaculty.Text == "Update Faculty")
            {
                btnAddFaculty.Text = "Update";
                try
                {
                    // query to retrieve faculty data based on the facultyID
                    string query = $"SELECT * FROM Faculty WHERE id = '{facultyID}'";
                    DataTable facultyData = db.ExecuteQuery(query);

                    if (facultyData.Rows.Count > 0)
                    {
                        // populate form fields with existing faculty information
                        txtAddFacultyName.Text = facultyData.Rows[0]["Name"].ToString();
                        txtAddFacultyFacultyId.Text = facultyData.Rows[0]["FacultyId"].ToString();
                        txtAddFacultyDescription.Text = facultyData.Rows[0]["Description"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Faculty not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading faculty information: {ex.Message}");
                }
            }

            // populate the listBoxSubjects with data from the 'subjects' table
            PopulateSubjectsListBox();

            // select subjects associated with the current faculty
            SelectSubjectsForFaculty();
        }

        // event handler when the 'Add Faculty' button is clicked
        private void btnAddFaculty_Click(object sender, EventArgs e)
        {
            // get faculty information from the form
            string facultyName = txtAddFacultyName.Text;
            string facultyId = txtAddFacultyFacultyId.Text;
            string facultyDescription = txtAddFacultyDescription.Text;

            // check if the required fields are empty
            if (string.IsNullOrEmpty(facultyName) || string.IsNullOrEmpty(facultyId) || string.IsNullOrEmpty(facultyDescription))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }

            try
            {
                // if the label is "Add New Faculty", close the form
                if (lblAddFaculty.Text == "Add New Faculty")
                {
                    db.OpenConnection();

                    // check if faculty with the same name exists
                    string checkFacultyQuery = $"SELECT Id FROM Faculty WHERE Name = '{facultyName}'";
                    DataTable existingFacultyTable = db.ExecuteQuery(checkFacultyQuery);

                    if (existingFacultyTable.Rows.Count > 0)
                    {
                        MessageBox.Show("A faculty with the same name already exists.");
                        return;
                    }

                    // create a new row in the 'Faculty' table
                    string createFacultyQuery = $"INSERT INTO Faculty (Name, FacultyId, Description) " +
                        $"VALUES ('{facultyName}', '{facultyId}', '{facultyDescription}');";

                    // execute the query to add the faculty
                    db.ExecuteNonQuery(createFacultyQuery);

                    // get the newly inserted faculty Id
                    string getFacultyIdQuery = "SELECT LAST_INSERT_ID();";
                    int newFacultyId = Convert.ToInt32(db.ExecuteQuery(getFacultyIdQuery).Rows[0][0]);

                    // insert records into 'faculty_subjects' table for each selected subject
                    foreach (SubjectItem selectedSubject in listboxSubjects.SelectedItems)
                    {
                        int subjectId = selectedSubject.Id;

                        // create a new row in the 'faculty_subjects' table
                        string insertFacultySubjectQuery = $"INSERT INTO faculty_subjects (facultyId, subjectId) " +
                            $"VALUES ({newFacultyId}, {subjectId});";

                        // execute the query to add the faculty subject
                        db.ExecuteNonQuery(insertFacultySubjectQuery);
                    }

                    db.CloseConnection();
                    MessageBox.Show("Faculty added successfully.");
                    this.Close();

                    FacultyDetails facultyDetailsForm = Application.OpenForms["FacultyDetails"] as FacultyDetails;
                    facultyDetailsForm?.LoadFacultyData();
                }
                else // if the label is "Update Faculty", update the faculty and faculty_subjects tables
                {
                    db.OpenConnection();

                    // update faculty information in the 'Faculty' table
                    string updateFacultyQuery = $"UPDATE Faculty SET Name = '{facultyName}', FacultyId = '{facultyId}', Description = '{facultyDescription}' WHERE Id = '{facultyID}'";
                    db.ExecuteNonQuery(updateFacultyQuery);

                    // delete existing records in 'faculty_subjects' table for the faculty
                    string deleteFacultySubjectsQuery = $"DELETE FROM faculty_subjects WHERE facultyId = '{facultyID}'";
                    db.ExecuteNonQuery(deleteFacultySubjectsQuery);

                    // insert new records into 'faculty_subjects' table for each selected subject
                    foreach (SubjectItem selectedSubject in listboxSubjects.SelectedItems)
                    {
                        int subjectId = selectedSubject.Id;

                        // create a new row in the 'faculty_subjects' table
                        string insertFacultySubjectQuery = $"INSERT INTO faculty_subjects (facultyId, subjectId) " +
                            $"VALUES ('{facultyID}', {subjectId})";

                        // execute the query to add the faculty subject
                        db.ExecuteNonQuery(insertFacultySubjectQuery);
                    }

                    db.CloseConnection();
                    MessageBox.Show("Faculty updated successfully.");
                    this.Close();

                    // reload FacultyDetails data
                    FacultyDetails facultyDetailsForm = Application.OpenForms["FacultyDetails"] as FacultyDetails;
                    facultyDetailsForm?.LoadFacultyData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating faculty: {ex.Message}");
            }
        }
    }
}
