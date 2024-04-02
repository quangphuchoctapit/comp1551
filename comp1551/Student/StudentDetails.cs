using comp1551.Student;
using System;
using System.Data;
using System.Windows.Forms;
using static comp1551.UserClass;
using static comp1551.utils;

namespace comp1551.Student
{
    public partial class StudentDetails : Form
    {

        public StudentDetails()
        {
            InitializeComponent();
            LoadStudentData();
        }

        // define variable to check current user role
        string userRole = GlobalVariables.UserRole;

        // this func will be executed when winform is initially loaded
        private void StudentDetails_Load(object sender, EventArgs e)
        {
            // Load student data when the form is loaded
            LoadStudentData();
            btnAddStudent.Enabled = false;
            btnEditStudent.Enabled = false;
            btnDeleteStudent.Enabled = false;
            // check if the current user role is admin or not, if yes, enable some buttons
            if (userRole == "admin")
            {
                btnAddStudent.Enabled = true;
                btnEditStudent.Enabled = true;
                btnDeleteStudent.Enabled = true;
            }
        }

        // this func is used to make changes to datagridview, and load all student data
        public void LoadStudentData()
        {
            try
            {
                // use OOP to get all students => first instantiate UoGSystem class, then invoke GetAllStudents method in StudentManage attribute in that instance
                UoGSystem system = new UoGSystem();
                List<StudentClass> students = system.StudentManage.GetAllStudents();
                if (students.Count > 0)
                {
                    // Clear existing columns if any
                    tableStudent.Columns.Clear();

                    // Convert the list of students to a DataTable
                    DataTable studentTable = new DataTable();
                    studentTable.Columns.Add("Id", typeof(int));
                    studentTable.Columns.Add("Name", typeof(string));
                    studentTable.Columns.Add("Email", typeof(string));
                    studentTable.Columns.Add("Telephone", typeof(string));
                    studentTable.Columns.Add("FacultyName", typeof(string));
                    studentTable.Columns.Add("ClassName", typeof(string));
                    studentTable.Columns.Add("CurrentSubject1", typeof(string));
                    studentTable.Columns.Add("CurrentSubject2", typeof(string));
                    studentTable.Columns.Add("PreviousSubject1", typeof(string));
                    studentTable.Columns.Add("PreviousSubject2", typeof(string));

                    foreach (var student in students)
                    {
                        studentTable.Rows.Add(student.Id, student.Name, student.Email, student.Telephone, student.GetFacultyName(), student.GetClassName(), student.GetCurrentSubject1(), student.GetCurrentSubject2(), student.GetPreviousSubject1(), student.GetPreviousSubject2());
                    }

                    // Set DataGridView properties
                    tableStudent.AutoGenerateColumns = false;
                    tableStudent.DataSource = studentTable;

                    // Add DataGridView columns if not already added
                    if (tableStudent.Columns.Count == 0)
                    {
                        DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
                        idColumn.DataPropertyName = "Id";
                        idColumn.HeaderText = "ID";

                        DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
                        nameColumn.DataPropertyName = "Name";
                        nameColumn.HeaderText = "Name";

                        DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
                        emailColumn.DataPropertyName = "Email";
                        emailColumn.HeaderText = "Email";

                        DataGridViewTextBoxColumn telephoneColumn = new DataGridViewTextBoxColumn();
                        telephoneColumn.DataPropertyName = "Telephone";
                        telephoneColumn.HeaderText = "Telephone";

                        DataGridViewTextBoxColumn facultyColumn = new DataGridViewTextBoxColumn();
                        facultyColumn.DataPropertyName = "FacultyName"; // Using the alias from the query
                        facultyColumn.HeaderText = "Faculty";

                        DataGridViewTextBoxColumn classColumn = new DataGridViewTextBoxColumn();
                        classColumn.DataPropertyName = "ClassName"; // Using the alias from the query
                        classColumn.HeaderText = "Class";

                        DataGridViewTextBoxColumn currSubject1Column = new DataGridViewTextBoxColumn();
                        currSubject1Column.DataPropertyName = "CurrentSubject1"; // Using the alias from the query
                        currSubject1Column.HeaderText = "Curr Subject 1";

                        DataGridViewTextBoxColumn currSubject2Column = new DataGridViewTextBoxColumn();
                        currSubject2Column.DataPropertyName = "CurrentSubject2"; // Using the alias from the query
                        currSubject2Column.HeaderText = "Curr Subject 2";

                        DataGridViewTextBoxColumn prevSubject1Column = new DataGridViewTextBoxColumn();
                        prevSubject1Column.DataPropertyName = "PreviousSubject1"; // Using the alias from the query
                        prevSubject1Column.HeaderText = "Prev Subject 1";

                        DataGridViewTextBoxColumn prevSubject2Column = new DataGridViewTextBoxColumn();
                        prevSubject2Column.DataPropertyName = "PreviousSubject2"; // Using the alias from the query
                        prevSubject2Column.HeaderText = "Prev Subject 2";

                        // Add columns to the DataGridView
                        tableStudent.Columns.Add(idColumn);
                        tableStudent.Columns.Add(nameColumn);
                        tableStudent.Columns.Add(emailColumn);
                        tableStudent.Columns.Add(telephoneColumn);
                        tableStudent.Columns.Add(facultyColumn);
                        tableStudent.Columns.Add(classColumn);
                        tableStudent.Columns.Add(currSubject1Column);
                        tableStudent.Columns.Add(currSubject2Column);
                        tableStudent.Columns.Add(prevSubject1Column);
                        tableStudent.Columns.Add(prevSubject2Column);
                    }
                }
                else
                {
                    MessageBox.Show("No student data found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student data: {ex.Message}");
            }
        }




        // this func will be executed when the user click 'Search' btn
        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            HandleSearchStudent();  
        }

        // this func is used to get corresponding student result based on the user input
        private void HandleSearchStudent()
        {
            try
            {
                // use OOP to get all students => first instantiate UoGSystem class, then invoke GetAllStudents method in StudentManage attribute in that instance
                UoGSystem system = new UoGSystem();
                List<StudentClass> students = system.StudentManage.GetStudentsByName(txtSearchStudent.Text);
                if (students.Count > 0)
                {
                    // Clear existing columns if any
                    tableStudent.Columns.Clear();

                    // Convert the list of students to a DataTable
                    DataTable studentTable = new DataTable();
                    studentTable.Columns.Add("Id", typeof(int));
                    studentTable.Columns.Add("Name", typeof(string));
                    studentTable.Columns.Add("Email", typeof(string));
                    studentTable.Columns.Add("Telephone", typeof(string));
                    studentTable.Columns.Add("FacultyName", typeof(string));
                    studentTable.Columns.Add("ClassName", typeof(string));
                    studentTable.Columns.Add("CurrentSubject1", typeof(string));
                    studentTable.Columns.Add("CurrentSubject2", typeof(string));
                    studentTable.Columns.Add("PreviousSubject1", typeof(string));
                    studentTable.Columns.Add("PreviousSubject2", typeof(string));

                    foreach (var student in students)
                    {
                        studentTable.Rows.Add(student.Id, student.Name, student.Email, student.Telephone, student.GetFacultyName(), student.GetClassName(), student.GetCurrentSubject1(), student.GetCurrentSubject2(), student.GetPreviousSubject1(), student.GetPreviousSubject2());
                    }

                    // Set DataGridView properties
                    tableStudent.AutoGenerateColumns = false;
                    tableStudent.DataSource = studentTable;

                    // Add DataGridView columns if not already added
                    if (tableStudent.Columns.Count == 0)
                    {
                        DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
                        idColumn.DataPropertyName = "Id";
                        idColumn.HeaderText = "ID";

                        DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
                        nameColumn.DataPropertyName = "Name";
                        nameColumn.HeaderText = "Name";

                        DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
                        emailColumn.DataPropertyName = "Email";
                        emailColumn.HeaderText = "Email";

                        DataGridViewTextBoxColumn telephoneColumn = new DataGridViewTextBoxColumn();
                        telephoneColumn.DataPropertyName = "Telephone";
                        telephoneColumn.HeaderText = "Telephone";

                        DataGridViewTextBoxColumn facultyColumn = new DataGridViewTextBoxColumn();
                        facultyColumn.DataPropertyName = "FacultyName"; // Using the alias from the query
                        facultyColumn.HeaderText = "Faculty";

                        DataGridViewTextBoxColumn classColumn = new DataGridViewTextBoxColumn();
                        classColumn.DataPropertyName = "ClassName"; // Using the alias from the query
                        classColumn.HeaderText = "Class";

                        DataGridViewTextBoxColumn currSubject1Column = new DataGridViewTextBoxColumn();
                        currSubject1Column.DataPropertyName = "CurrentSubject1"; // Using the alias from the query
                        currSubject1Column.HeaderText = "Curr Subject 1";

                        DataGridViewTextBoxColumn currSubject2Column = new DataGridViewTextBoxColumn();
                        currSubject2Column.DataPropertyName = "CurrentSubject2"; // Using the alias from the query
                        currSubject2Column.HeaderText = "Curr Subject 2";

                        DataGridViewTextBoxColumn prevSubject1Column = new DataGridViewTextBoxColumn();
                        prevSubject1Column.DataPropertyName = "PreviousSubject1"; // Using the alias from the query
                        prevSubject1Column.HeaderText = "Prev Subject 1";

                        DataGridViewTextBoxColumn prevSubject2Column = new DataGridViewTextBoxColumn();
                        prevSubject2Column.DataPropertyName = "PreviousSubject2"; // Using the alias from the query
                        prevSubject2Column.HeaderText = "Prev Subject 2";

                        // Add columns to the DataGridView
                        tableStudent.Columns.Add(idColumn);
                        tableStudent.Columns.Add(nameColumn);
                        tableStudent.Columns.Add(emailColumn);
                        tableStudent.Columns.Add(telephoneColumn);
                        tableStudent.Columns.Add(facultyColumn);
                        tableStudent.Columns.Add(classColumn);
                        tableStudent.Columns.Add(currSubject1Column);
                        tableStudent.Columns.Add(currSubject2Column);
                        tableStudent.Columns.Add(prevSubject1Column);
                        tableStudent.Columns.Add(prevSubject2Column);
                    }
                }
                else
                {
                    MessageBox.Show("No student data found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student data: {ex.Message}");
            }
        }

        // this func will be exectued when the user click 'Add' btn
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // Open the AddStudent form to add a new student
            using (AddStudent ac = new AddStudent())
            {
                // Set the label text for Add New Student
                ac.lbl = "Add New Student";
                ac.ShowDialog(); // Show the AddStudent form as a dialog
            }


        }

        // this func will be executed when the user clicks the 'Edit' button
        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            // Open the AddStudent form to edit an existing student
            using (AddStudent ac = new AddStudent())
            {
                // Set the label text for Update Student
                ac.lbl = "Update Student";

                // Check if any row is selected in the DataGridView
                if (tableStudent.CurrentRow != null)
                {
                    // Get the data bound to the selected row
                    DataRowView selectedRowView = tableStudent.CurrentRow.DataBoundItem as DataRowView;


                    // Check if the selected row is bound to a data item
                    if (selectedRowView != null)
                    {
                        // Get the student ID directly from the data source bound to the DataGridView
                        if (selectedRowView.Row.Table.Columns.Contains("Id"))
                        {
                            int studentId = Convert.ToInt32(selectedRowView.Row["Id"]);
                            ac.studentId = studentId; // pass the studentId to the AddStudent form
                            ac.ShowDialog(); // Show the AddStudent form as a dialog
                        }
                        else
                        {
                            MessageBox.Show("The selected row does not contain an ID value.", "Invalid Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The selected row is not bound to any data item.", "Invalid Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a student to edit.", "No Student Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }






        // this func will be exectued when the user click 'delete' btn
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (tableStudent.CurrentRow != null)
                {
                    DataRowView selectedRowView = tableStudent.CurrentRow.DataBoundItem as DataRowView;

                    // Check if the selected row is bound to a data item
                    if (selectedRowView != null)
                    {
                        // Get the student ID directly from the data source bound to the DataGridView
                        if (selectedRowView.Row.Table.Columns.Contains("Id"))
                        {
                            int studentId = Convert.ToInt32(selectedRowView.Row["Id"]);

                            UoGSystem system = new UoGSystem();
                            system.StudentManage.DeleteStudent(studentId);
                            LoadStudentData();
                        }
                        else
                        {
                            MessageBox.Show("The selected row does not contain an ID value.", "Invalid Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a student to delete.", "No Student Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when deleting student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
} 