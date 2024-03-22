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

                    // Add DataGridView columns
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

                    DataGridViewTextBoxColumn CurrSubject1Column = new DataGridViewTextBoxColumn();
                    CurrSubject1Column.DataPropertyName = "CurrentSubject1"; // Using the alias from the query
                    CurrSubject1Column.HeaderText = "Curr Subject 1";

                    DataGridViewTextBoxColumn CurrSubject2Column = new DataGridViewTextBoxColumn();
                    CurrSubject2Column.DataPropertyName = "CurrentSubject2"; // Using the alias from the query
                    CurrSubject2Column.HeaderText = "Curr Subject 2";

                    DataGridViewTextBoxColumn PrevSubject1Column = new DataGridViewTextBoxColumn();
                    PrevSubject1Column.DataPropertyName = "PreviousSubject1"; // Using the alias from the query
                    PrevSubject1Column.HeaderText = "Prev Subject 1";

                    DataGridViewTextBoxColumn PrevSubject2Column = new DataGridViewTextBoxColumn();
                    PrevSubject2Column.DataPropertyName = "PreviousSubject2"; // Using the alias from the query
                    PrevSubject2Column.HeaderText = "Prev Subject 2";

                    // Add columns to the DataGridView
                    tableStudent.Columns.Add(idColumn);
                    tableStudent.Columns.Add(nameColumn);
                    tableStudent.Columns.Add(emailColumn);
                    tableStudent.Columns.Add(telephoneColumn);
                    tableStudent.Columns.Add(facultyColumn);
                    tableStudent.Columns.Add(classColumn);
                    tableStudent.Columns.Add(CurrSubject1Column);
                    tableStudent.Columns.Add(CurrSubject2Column);
                    tableStudent.Columns.Add(PrevSubject1Column);
                    tableStudent.Columns.Add(PrevSubject2Column);

                    // Set DataGridView properties
                    tableStudent.AutoGenerateColumns = false;
                    tableStudent.DataSource = students;
                }
                else
                {
                    MessageBox.Show("No student data found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
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
            // use OOP to get all students => first instantiate UoGSystem class, then invoke GetStudentsByName method in StudentManage attribute in that instance
            UoGSystem system = new UoGSystem();
            List<StudentClass> students = system.StudentManage.GetStudentsByName(txtSearchStudent.Text);

            // if there is a result, then fire the below condition
            if (students.Count > 0)
            {
                // Clear existing columns if any
                tableStudent.Columns.Clear();

                // Add DataGridView columns
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

                DataGridViewTextBoxColumn CurrSubject1Column = new DataGridViewTextBoxColumn();
                CurrSubject1Column.DataPropertyName = "CurrentSubject1"; // Using the alias from the query
                CurrSubject1Column.HeaderText = "Curr Subject 1";

                DataGridViewTextBoxColumn CurrSubject2Column = new DataGridViewTextBoxColumn();
                CurrSubject2Column.DataPropertyName = "CurrentSubject2"; // Using the alias from the query
                CurrSubject2Column.HeaderText = "Curr Subject 2";

                DataGridViewTextBoxColumn PrevSubject1Column = new DataGridViewTextBoxColumn();
                PrevSubject1Column.DataPropertyName = "PreviousSubject1"; // Using the alias from the query
                PrevSubject1Column.HeaderText = "Prev Subject 1";

                DataGridViewTextBoxColumn PrevSubject2Column = new DataGridViewTextBoxColumn();
                PrevSubject2Column.DataPropertyName = "PreviousSubject2"; // Using the alias from the query
                PrevSubject2Column.HeaderText = "Prev Subject 2";

                // Add columns to the DataGridView
                tableStudent.Columns.Add(idColumn);
                tableStudent.Columns.Add(nameColumn);
                tableStudent.Columns.Add(emailColumn);
                tableStudent.Columns.Add(telephoneColumn);
                tableStudent.Columns.Add(facultyColumn);
                tableStudent.Columns.Add(classColumn);
                tableStudent.Columns.Add(CurrSubject1Column);
                tableStudent.Columns.Add(CurrSubject2Column);
                tableStudent.Columns.Add(PrevSubject1Column);
                tableStudent.Columns.Add(PrevSubject2Column);

                // Set DataGridView properties
                tableStudent.AutoGenerateColumns = false;
                tableStudent.DataSource = students;
            }
            else
            {
                MessageBox.Show("No student data found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // this func will be exectued when the user click 'Edit' btn
        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            // Open the AddStudent form to edit an existing student
            using (AddStudent ac = new AddStudent())
            {
                // Set the label text for Update Student
                ac.lbl = "Update Student";

                // Check if any row is selected
                if (tableStudent.CurrentRow != null)
                {
                    // Get the selected student from the DataGridView
                    StudentClass selectedStudent = tableStudent.CurrentRow.DataBoundItem as StudentClass;

                    // Check if the selectedStudent is not null
                    if (selectedStudent != null)
                    {
                        // Retrieve the ID value from the selected student
                        int studentId = selectedStudent.Id;

                        // Pass the student ID to the AddStudent form
                        ac.studentId = studentId;
                    }
                    else
                    {
                        MessageBox.Show("No data associated with the selected row.", "Invalid Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    ac.ShowDialog(); // Show the AddStudent form as a dialog
                }
                else
                {
                    MessageBox.Show("Please select a student to edit.", "No Student Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
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
                    // Get the selected student from the DataGridView
                    StudentClass selectedStudent = tableStudent.CurrentRow.DataBoundItem as StudentClass;

                    // Check if the selectedStudent is not null
                    if (selectedStudent != null)
                    {
                        // Retrieve the ID value from the selected student
                        int studentId = selectedStudent.Id;
                        UoGSystem system = new UoGSystem();
                        system.StudentManage.DeleteStudent(studentId);
                        LoadStudentData();
                    }
                    else
                    {
                        MessageBox.Show("No data associated with the selected row.", "Invalid Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HandleSearchStudent();

        }
    }
}
