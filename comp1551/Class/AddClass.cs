using comp1551.ExtensionWinform;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp1551.Class
{
    public partial class AddClass : Form
    {
        public AddClass()
        {
            InitializeComponent();
        }

        private Database db = new Database();  // creating an instance of the Database class for database operations

        public int classID;  // variable to hold the ID of the class being added or updated
        public string lbl;  // variable to hold the label text for the form (which will be set dynamically)


        // event handler when the form is loaded
        private void AddClass_Load(object sender, EventArgs e)
        {
            lblAddClass.Text = lbl;  // setting the label text for the form based on the provided label

            // setting the button text based on the label text
            if (lblAddClass.Text == "Add New Class")
            {
                btnAddClass.Text = "Add";
            }
            else if (lblAddClass.Text == "Update Class")
            {
                btnAddClass.Text = "Update";
                try
                {
                    // query to retrieve class data based on the classID
                    string query = $"SELECT * from Class where id='{classID}'";
                    DataTable classData = db.ExecuteQuery(query);

                    if (classData.Rows.Count > 0)
                    {
                        // populate form fields with existing class information
                        txtAddClassName.Text = classData.Rows[0]["Name"].ToString();
                        txtAddClassMaxCapacity.Text = classData.Rows[0]["MaxCapacity"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Class not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading class information: {ex.Message}");
                }
            }
        }


        // event handler when the 'Add Class' button is clicked
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            // get class information from the form
            string className = txtAddClassName.Text;
            string classMaxCapacity = txtAddClassMaxCapacity.Text;

            // check if the required fields are empty
            if (string.IsNullOrEmpty(className) || string.IsNullOrEmpty(classMaxCapacity))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }

            try
            {
                Database db = new Database();
                db.OpenConnection();

                // check if class with the same name exists
                string checkClassQuery = $"SELECT Id FROM Class WHERE id = '{classID}'";
                DataTable existingClassTable = db.ExecuteQuery(checkClassQuery);

                if (lblAddClass.Text == "Add New Class")
                {
                    // insert a new class
                    if (existingClassTable.Rows.Count > 0)
                    {
                        MessageBox.Show("A class with the same name already exists.");
                        db.CloseConnection();
                        return;
                    }

                    // create a new row in the 'Class' table
                    string createClassQuery = $"INSERT INTO Class (MaxCapacity, Name) " +
                        $"VALUES ('{classMaxCapacity}', '{className}');";

                    // execute the query to add the class
                    db.ExecuteNonQuery(createClassQuery);
                    db.CloseConnection();
                    this.Close();


                    // reload class details
                    ClassDetails classDetailsForm = Application.OpenForms["ClassDetails"] as ClassDetails;
                    classDetailsForm?.LoadClassData();
                }
                else if (lblAddClass.Text == "Update Class")
                {
                    // update an existing class
                    if (existingClassTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Class not found.");
                        db.CloseConnection();
                        return;
                    }

                    // update the existing row in the 'Class' table
                    string updateClassQuery = $"UPDATE Class SET Name = '{className}', MaxCapacity = '{classMaxCapacity}' " +
                        $"WHERE Id = '{classID}'";

                    // execute the query to update the class
                    db.ExecuteNonQuery(updateClassQuery);
                    db.CloseConnection();
                    this.Close();

                    // reload class details
                    ClassDetails classDetailsForm = Application.OpenForms["ClassDetails"] as ClassDetails;
                    classDetailsForm?.LoadClassData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding/updating class: {ex.Message}");
            }
        }

    }
}
