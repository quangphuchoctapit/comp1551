using comp1551.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp1551.Subject
{
    public partial class AddSubject : Form
    {
        public AddSubject()
        {
            InitializeComponent();
        }

        private Database db = new Database();  // Creating an instance of the Database class

        public int subjectID;  // Variable to hold the ID of the subject being added or updated
        public string lbl;  // Variable to hold the label text for the form (which will be set in subjectDetails.cs file)


        // event handler when winform first loaded
        private void AddSubject_Load(object sender, EventArgs e)
        {
            lblAddSubject.Text = lbl;  // Setting the label text for the form based on the provided label

            // setting the button text based on the label text
            if (lblAddSubject.Text == "Add New Subject")
            {
                btnAddSubject.Text = "Add";
            }
            else if (lblAddSubject.Text == "Update Subject")
            {
                btnAddSubject.Text = "Update";
                try
                {
                    // Query to retrieve subject data based on the subjectID
                    string query = $"SELECT * FROM Subject WHERE Id = '{subjectID}'";
                    DataTable subjectData = db.ExecuteQuery(query);

                    if (subjectData.Rows.Count > 0)
                    {
                        // Populating form fields with existing subject information
                        txtAddSubjectName.Text = subjectData.Rows[0]["Name"].ToString();
                        txtAddSubjectSubjectId.Text = subjectData.Rows[0]["SubjectId"].ToString();
                        txtAddSubjectDescription.Text = subjectData.Rows[0]["Description"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Subject not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading subject information: {ex.Message}");
                }
            }
        }


        // event handler when user clicks 'Add' button
        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            // Getting subject information from the form fields
            string subjectName = txtAddSubjectName.Text;
            string subjectDescription = txtAddSubjectDescription.Text;
            string subjectSubjectId = txtAddSubjectSubjectId.Text;

            // Checking if required fields are empty
            if (string.IsNullOrEmpty(subjectName) || string.IsNullOrEmpty(subjectSubjectId) || string.IsNullOrEmpty(subjectDescription))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }

            try
            {
                Database db = new Database();
                db.OpenConnection();

                // Checking if subject with the same name exists
                string checkSubjectQuery = $"SELECT Id FROM Subject WHERE id = '{subjectID}'";
                DataTable existingSubjectTable = db.ExecuteQuery(checkSubjectQuery);

                if (lblAddSubject.Text == "Add New Subject")
                {
                    // Inserting a new subject
                    if (existingSubjectTable.Rows.Count > 0)
                    {
                        MessageBox.Show("A subject with the same name already exists.");
                        return;
                    }

                    // creating a new row in the 'Subject' table
                    string createSubjectQuery = $"INSERT INTO Subject (Description, SubjectId, Name) " +
                        $"VALUES ('{subjectDescription}', '{subjectSubjectId}', '{subjectName}');";

                    // executing the query to add the Subject
                    db.ExecuteNonQuery(createSubjectQuery);
                    this.Close();


                    // reload subjectDetails
                    SubjectDetails studentDetailsForm = Application.OpenForms["SubjectDetails"] as SubjectDetails;
                    studentDetailsForm?.LoadSubjectData();
                }
                else if (lblAddSubject.Text == "Update Subject")
                {
                    // updating an existing class
                    if (existingSubjectTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Subject not found.");
                        return;
                    }

                    // updating the existing row in the 'Subject' table
                    string updateSubjectQuery = $"UPDATE Subject SET Name = '{subjectName}', Description = '{subjectDescription}' , SubjectId = '{subjectSubjectId}' " +
                        $"WHERE Id = '{subjectID}'";

                    // Executing the query to update the class
                    db.ExecuteNonQuery(updateSubjectQuery);
                    db.CloseConnection();
                    this.Close();
                    // reload subjectDetails
                    SubjectDetails studentDetailsForm = Application.OpenForms["SubjectDetails"] as SubjectDetails;
                    studentDetailsForm?.LoadSubjectData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding/updating subject: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}
