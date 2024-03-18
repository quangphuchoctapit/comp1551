using comp1551.Teacher;
using System;
using System.Data;
using System.Windows.Forms;
using static comp1551.UserClass;
using static comp1551.utils;

namespace comp1551.Teacher
{
    public partial class TeacherDetails : Form
    {
        public TeacherDetails()
        {
            InitializeComponent();
        }

        // define a variable to check the current user role
        string userRole = GlobalVariables.UserRole;

        // this func will be execueted when the user clicks 'Add' button
        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            // Open the AddTeacher form to add a new teacher
            using (AddTeacher at = new AddTeacher())
            {
                // Set the label text for Add New Teacher
                at.lbl = "Add New Teacher";
                at.ShowDialog(); // Show the AddTeacher form as a dialog
            }
        }

        // this func will be execueted when the user clicks 'Edit' button
                private void btnEditTeacher_Click(object sender, EventArgs e)
        {
            // open the AddTeacher form to edit an existing teacher
            using (AddTeacher at = new AddTeacher())
            {
                // set the label text for Update Teacher
                at.lbl = "Update Teacher";

                // check if any row is selected in the DataGridView
                if (tableTeacher.CurrentRow != null)
                {
                    // get the selected teacher from the DataGridView
                    DataRowView selectedRowView = tableTeacher.CurrentRow.DataBoundItem as DataRowView;

                    // Check if the selectedRowView is not null
                    if (selectedRowView != null)
                    {
                        // Retrieve the ID value from the DataRow
                        if (selectedRowView.Row.Table.Columns.Contains("Id"))
                        {
                            int teacherId = Convert.ToInt32(selectedRowView.Row["Id"]);

                            // pass the teacherId to the AddTeacher form
                            at.teacherId = teacherId;
                        }
                        else
                        {
                            MessageBox.Show("The selected row does not contain an ID value.", "Invalid Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data associated with the selected row.", "Invalid Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    at.ShowDialog(); // Show the AddTeacher form as a dialog
                }
                else
                {
                    MessageBox.Show("Please select a teacher to edit.", "No Teacher Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        // this func is used to retreive teacher data
        public void LoadTeacherData()
        {
            try
            {
                // call the GetAllTeachers method to retrieve teacher data
                UoGSystem system = new UoGSystem();
                List<TeacherClass> teachers = system.TeacherManage.GetAllTeachers();

                // check if there is any data
                if (teachers.Count > 0)
                {
                    // Convert the list of teachers to a DataTable
                    DataTable teacherTable = new DataTable();
                    teacherTable.Columns.Add("Id", typeof(int));
                    teacherTable.Columns.Add("Name", typeof(string));
                    teacherTable.Columns.Add("Email", typeof(string));
                    teacherTable.Columns.Add("Telephone", typeof(string));
                    teacherTable.Columns.Add("FacultyName", typeof(string));
                    teacherTable.Columns.Add("Qualifications", typeof(string));
                    teacherTable.Columns.Add("Salary", typeof(string));
                    teacherTable.Columns.Add("Subject 1", typeof(string));
                    teacherTable.Columns.Add("Subject 2", typeof(string));

                    foreach (var teacher in teachers)
                    {
                        teacherTable.Rows.Add(teacher.Id, teacher.Name, teacher.Email, teacher.Telephone, teacher.FacultyName, teacher.Qualifications, teacher.Salary, teacher.Subject1, teacher.Subject2);
                    }

                    // set datagridview properties
                    tableTeacher.AutoGenerateColumns = false;
                    tableTeacher.DataSource = teacherTable;

                    // add datagridview columns if not already added
                    if (tableTeacher.Columns.Count == 0)
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
                        facultyColumn.DataPropertyName = "FacultyName";
                        facultyColumn.HeaderText = "Faculty";

                        DataGridViewTextBoxColumn qualificationsColumn = new DataGridViewTextBoxColumn();
                        qualificationsColumn.DataPropertyName = "Qualifications";
                        qualificationsColumn.HeaderText = "Qualifications";

                        DataGridViewTextBoxColumn SalaryColumn = new DataGridViewTextBoxColumn();
                        SalaryColumn.DataPropertyName = "Salary";
                        SalaryColumn.HeaderText = "Salary";

                        DataGridViewTextBoxColumn subject1Column = new DataGridViewTextBoxColumn();
                        subject1Column.DataPropertyName = "Subject 1";
                        subject1Column.HeaderText = "Subject 1";

                        DataGridViewTextBoxColumn subject2Column = new DataGridViewTextBoxColumn();
                        subject2Column.DataPropertyName = "Subject 2";
                        subject2Column.HeaderText = "subject 2";

                        // Add columns to the DataGridView
                        tableTeacher.Columns.Add(idColumn);
                        tableTeacher.Columns.Add(nameColumn);
                        tableTeacher.Columns.Add(emailColumn);
                        tableTeacher.Columns.Add(telephoneColumn);
                        tableTeacher.Columns.Add(facultyColumn);
                        tableTeacher.Columns.Add(qualificationsColumn);
                        if (userRole == "admin")
                        {
                            tableTeacher.Columns.Add(SalaryColumn);
                        }
                        tableTeacher.Columns.Add(subject1Column);
                        tableTeacher.Columns.Add(subject2Column);
                    }
                }
                else
                {
                    MessageBox.Show("No teacher data found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading teacher data: {ex.Message}");
            }
        }

        // this func is executed when the winform is inititally loaded / opened
        private void TeacherDetails_Load(object sender, EventArgs e)
        {
            // load teacher data when the form is loaded
            LoadTeacherData();
            btnAddTeacher.Enabled = false;
            btnEditTeacher.Enabled = false;
            btnDeleteTeacher.Enabled = false;
            // check if the current user role is admin or not, if yes, enable the user to use the below btns
            if (userRole == "admin")
            {
                btnAddTeacher.Enabled = true;
                btnEditTeacher.Enabled = true;
                btnDeleteTeacher.Enabled = true;
            }
        }

        // this func will be executed when the user click the search btn
        private void btnSearchTeacher_Click(object sender, EventArgs e)
        {
            // call HandleSearchTeacher func
            HandleSearchTeacher();
        }


        // this func is used to load teacher data and make changes to datagridview
        private void HandleSearchTeacher()
        {
            UoGSystem system = new UoGSystem();
            List<TeacherClass> teachers = system.TeacherManage.GetTeachersByName(txtSearchTeacher.Text);
            // check if there is any data
            if (teachers.Count > 0)
            {
                // convert the list of teachers to a DataTable
                DataTable teacherTable = new DataTable();
                teacherTable.Columns.Add("Id", typeof(int));
                teacherTable.Columns.Add("Name", typeof(string));
                teacherTable.Columns.Add("Email", typeof(string));
                teacherTable.Columns.Add("Telephone", typeof(string));
                teacherTable.Columns.Add("FacultyName", typeof(string));
                teacherTable.Columns.Add("Qualifications", typeof(string));
                teacherTable.Columns.Add("Salary", typeof(string));
                teacherTable.Columns.Add("Subject 1", typeof(string));
                teacherTable.Columns.Add("Subject 2", typeof(string));

                foreach (var teacher in teachers)
                {
                    teacherTable.Rows.Add(teacher.Id, teacher.Name, teacher.Email, teacher.Telephone, teacher.FacultyName, teacher.Qualifications, teacher.Salary, teacher.Subject1, teacher.Subject2);
                }

                // set DataGridView properties
                tableTeacher.AutoGenerateColumns = false;
                tableTeacher.DataSource = teacherTable;

                // add DataGridView columns if not already added
                if (tableTeacher.Columns.Count == 0)
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
                    facultyColumn.DataPropertyName = "FacultyName";
                    facultyColumn.HeaderText = "Faculty";

                    DataGridViewTextBoxColumn qualificationsColumn = new DataGridViewTextBoxColumn();
                    qualificationsColumn.DataPropertyName = "Qualifications";
                    qualificationsColumn.HeaderText = "Qualifications";

                    DataGridViewTextBoxColumn SalaryColumn = new DataGridViewTextBoxColumn();
                    SalaryColumn.DataPropertyName = "Salary";
                    SalaryColumn.HeaderText = "Salary";

                    DataGridViewTextBoxColumn subject1Column = new DataGridViewTextBoxColumn();
                    subject1Column.DataPropertyName = "Subject 1";
                    subject1Column.HeaderText = "Subject 1";

                    DataGridViewTextBoxColumn subject2Column = new DataGridViewTextBoxColumn();
                    subject2Column.DataPropertyName = "Subject 2";
                    subject2Column.HeaderText = "subject 2";

                    // Add columns to the DataGridView
                    tableTeacher.Columns.Add(idColumn);
                    tableTeacher.Columns.Add(nameColumn);
                    tableTeacher.Columns.Add(emailColumn);
                    tableTeacher.Columns.Add(telephoneColumn);
                    tableTeacher.Columns.Add(facultyColumn);
                    tableTeacher.Columns.Add(qualificationsColumn);
                    tableTeacher.Columns.Add(SalaryColumn);
                    tableTeacher.Columns.Add(subject1Column);
                    tableTeacher.Columns.Add(subject2Column);
                }
            }
            else
            {
                MessageBox.Show("No teacher data found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // this func will be executed when the user click Delete button
        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                if (tableTeacher.CurrentRow != null)
                {
                    // Get the selected teacher from the DataGridView
                    DataRowView selectedRowView = tableTeacher.CurrentRow.DataBoundItem as DataRowView;

                    // Check if the selectedRowView is not null
                    if (selectedRowView != null)
                    {
                        // Retrieve the ID value from the DataRow
                        if (selectedRowView.Row.Table.Columns.Contains("Id"))
                        {
                            int teacherId = Convert.ToInt32(selectedRowView.Row["Id"]);
                            UoGSystem system = new UoGSystem();
                            system.TeacherManage.DeleteTeacher(teacherId);
                            LoadTeacherData();
                        }
                        else
                        {
                            MessageBox.Show("The selected row does not contain an ID value.", "Invalid Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data associated with the selected row.", "Invalid Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please select a teacher to edit.", "No Teacher Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR when deleting teacher: " + ex.Message);
            }
            finally
            {

            }
        }

        // this func will be executed when the user click the picturebox in the search button
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HandleSearchTeacher();
        }
    }
}
