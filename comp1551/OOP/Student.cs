using System;
using System.Data;
using static System.Windows.Forms.Design.AxImporter;
using System.Text.Json;
using MySql.Data.MySqlClient;
using static comp1551.UserClass;

namespace comp1551
{
    // derived class representing student
    public class StudentClass : UserClass
    {


        public override void View()
        {

        }
        //   public override string Role { get; set; }

        private string currentSubject1;
        public string GetCurrentSubject1() => currentSubject1;
        public void SetCurrentSubject1(string value) => currentSubject1 = value;

        private string currentSubject2;
        public string GetCurrentSubject2() => currentSubject2;
        public void SetCurrentSubject2(string value) => currentSubject2 = value;

        private string previousSubject1;
        public string GetPreviousSubject1() => previousSubject1;
        public void SetPreviousSubject1(string value) => previousSubject1 = value;

        private string previousSubject2;
        public string GetPreviousSubject2() => previousSubject2;
        public void SetPreviousSubject2(string value) => previousSubject2 = value;

        private string facultyName;
        public string GetFacultyName() => facultyName;
        public void SetFacultyName(string value) => facultyName = value;

        private string className;
        public string GetClassName() => className;
        public void SetClassName(string value) => className = value;

        private string image;
        public string GetImage() => image;
        public void SetImage(string value) => image = value;

        private int facultyId;
        public int GetFacultyId() => facultyId;
        public void SetFacultyId(int value) => facultyId = value;

        private int classId;
        public int GetClassId() => classId;
        public void SetClassId(int value) => classId = value;

    }

    public class StudentManage : UserClass
    {

        private Database database;
        public StudentManage(Database db)
        {
            database = db;
        }

        public override void View()
        {
            List<StudentClass> teachers = GetAllStudents();
        }

        // Student CRUD operations
        public void AddStudent(StudentClass student)
        {
            try
            {
                // Open database connection
                database.OpenConnection();

                // Check if the email already exists in the database
                string checkEmailQuery = $"SELECT COUNT(*) FROM User WHERE Email = '{student.Email}'";
                int emailCount = database.GetCount(checkEmailQuery);
                if (emailCount > 0)
                {
                    MessageBox.Show("Email already exists. Please choose a different one.");
                    return;
                }

                // Convert the image to a Base64 string
                string base64Image = "";
                if (!string.IsNullOrEmpty(student.GetImage()))
                {
                    base64Image = student.GetImage();
                }

                // Insert new user into the database with the role 'student'
                string insertUserQuery = $"INSERT INTO User (Name, Telephone, Email, Role, Image, password) " +
                    $"VALUES ('{student.Name}', '{student.Telephone}', '{student.Email}', 'student', '{base64Image}', '123456')";

                // Execute the insert query for the user
                database.ExecuteNonQuery(insertUserQuery);

                // Get the ID of the newly inserted user
                string getUserIdQuery = "SELECT LAST_INSERT_ID()";
                int userId = database.GetUserId(getUserIdQuery);

                string insertStudentQuery = $"INSERT INTO Student (currSubject1, currSubject2, UserId, prevSubject1, prevSubject2, facultyId, classId) " +
                    $"VALUES ('{student.GetCurrentSubject1()}',  '{student.GetCurrentSubject2()}', {userId}, '{student.GetPreviousSubject1()}', '{student.GetPreviousSubject2()}', '{student.GetFacultyId()}', '{student.GetClassId()}')";

                // Execute the insert query for the student
                database.ExecuteNonQuery(insertStudentQuery);

                // Close database connection
                database.CloseConnection();
            }
            catch (Exception ex)
            {
                // Display an error message if adding the student fails
                MessageBox.Show($"Error adding student: {ex.Message}");
            }
        }



        public void UpdateStudent(int id, StudentClass updatedStudent)
        {
            try
            {
                // Open database connection
                database.OpenConnection();

                // Check if the email already exists in the database
                string checkEmailQuery = $"SELECT COUNT(*) FROM User WHERE Email = '{updatedStudent.Email}'";
                int emailCount = database.GetCount(checkEmailQuery);

                // Handle NULL values for the image field
                string imageValue = updatedStudent.GetImage() != null ? $"'{updatedStudent.GetImage()}'" : "NULL";
                updatedStudent.SetImage(imageValue);

                // Update the user information in the 'User' table
                string updateQueryUser = $"UPDATE User SET Name = '{updatedStudent.Name}', " +
                                         $"Email = '{updatedStudent.Email}', Telephone = '{updatedStudent.Telephone}', " +
                                         $"Image = {imageValue} WHERE Id = '{id}'";

                // Update the student information in the 'Student' table
                string updateQueryStudent = $"UPDATE Student SET FacultyId = '{updatedStudent.GetFacultyId()}', " +
                                            $"ClassId = '{updatedStudent.GetClassId()}', " +
                                            $"currSubject1 = '{updatedStudent.GetCurrentSubject1()}', " +
                                            $"currSubject2 = '{updatedStudent.GetCurrentSubject2()}', " +
                                            $"prevSubject1 = '{updatedStudent.GetPreviousSubject1()}', " +
                                            $"prevSubject2 = '{updatedStudent.GetPreviousSubject2()}' " +
                                            $"WHERE UserId = '{id}'";

                // Execute the update queries
                database.ExecuteNonQuery(updateQueryUser);
                database.ExecuteNonQuery(updateQueryStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating student: {ex.Message}");
            }
            finally
            {
                // Close database connection
                database.CloseConnection();
            }
        }



        public void DeleteStudent(int id)
        {
            database.OpenConnection();
            string queryUser = $"DELETE FROM user WHERE Id = {id} and role = 'student'";
            string queryStudent = $"DELETE FROM student WHERE userId = {id}";
            database.ExecuteNonQuery(queryUser);
            database.ExecuteNonQuery(queryStudent);
            database.CloseConnection();
        }
        // method to get student 2 current subjects

        public string[] Get2CurrentSubjects(int studentId)
        {
            string[] currentSubjects = new string[2]; // Assuming each student has two current subjects

            try
            {
                database.OpenConnection();

                // Query to retrieve the current subjects of the specified student
                string query = $"SELECT s.currSubject1 AS CurrSubject1, s.currSubject2 AS CurrSubject2 " +
                               $"FROM User u " +
                               $"JOIN Student s ON u.Id = s.UserId " +
                               $"WHERE u.Role = 'student' AND u.Id = {studentId}";

                DataTable dataTable = database.ExecuteQuery(query);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    currentSubjects[0] = row["CurrSubject1"].ToString();
                    currentSubjects[1] = row["CurrSubject2"].ToString();
                }
                else
                {
                    MessageBox.Show("Subjects not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading current subjects of student: {ex.Message}");
            }
            finally
            {
                database.CloseConnection();
            }

            return currentSubjects;
        }


        // method to get student 2 previous subjects
        public string[] Get2PreviousSubjects(int studentId)
        {
            string[] previousSubjects = new string[2]; // Assuming each student has two current subjects

            try
            {
                database.OpenConnection();

                // Query to retrieve the current subjects of the specified student
                string query = $"SELECT s.prevSubject1 AS PrevSubject1, s.prevSubject2 AS PrevSubject2 " +
                               $"FROM User u " +
                               $"JOIN Student s ON u.Id = s.UserId " +
                               $"WHERE u.Role = 'student' AND u.Id = {studentId}";

                DataTable dataTable = database.ExecuteQuery(query);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    previousSubjects[0] = row["PrevSubject1"].ToString();
                    previousSubjects[1] = row["PrevSubject2"].ToString();
                }
                else
                {
                    MessageBox.Show("Subjects not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Previous subjects of student: {ex.Message}");
            }
            finally
            {
                database.CloseConnection();
            }

            return previousSubjects;
        }

        // method to get all students
        public List<StudentClass> GetAllStudents()
        {
            List<StudentClass> students = new List<StudentClass>();

            try
            {
                database.OpenConnection();

                string query = "SELECT u.Id, u.Name, u.Email, u.Telephone, u.Role, f.Name AS FacultyName, c.Name AS ClassName,    s.currSubject1 AS CurrSubject1, s.currSubject2 AS CurrSubject2,      s.prevSubject1 AS PrevSubject1, s.prevSubject2 AS PrevSubject2 FROM User u        JOIN Student s ON u.Id = s.UserId        LEFT JOIN Faculty f ON s.FacultyId = f.Id       LEFT JOIN Class c ON s.ClassId = c.Id             WHERE u.Role = 'student'";

                DataTable dataTable = database.ExecuteQuery(query);





                foreach (DataRow row in dataTable.Rows)
                {
                    string roleString = row["Role"].ToString().ToLower();
                    if (Enum.TryParse<UserRole>(roleString, true, out UserRole role))
                    {
                        StudentClass student = new StudentClass
                        {
                            Id = Convert.ToInt32(row["Id"]),
                            Name = row["Name"].ToString(),
                            Email = row["Email"].ToString(),
                            Role = role,
                            Telephone = row["Telephone"].ToString(),
                        };

                        // Use the setter methods to set the additional properties
                        student.SetFacultyName(row["FacultyName"].ToString());
                        student.SetClassName(row["ClassName"].ToString());
                        student.SetCurrentSubject1(row["CurrSubject1"].ToString());
                        student.SetCurrentSubject2(row["CurrSubject2"].ToString());
                        student.SetPreviousSubject1(row["PrevSubject1"].ToString());
                        student.SetPreviousSubject2(row["PrevSubject2"].ToString());

                        students.Add(student);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student data: {ex.Message}");
            }
            finally
            {
                database.CloseConnection();
            }

            return students;
        }

        // method to get all students by name
        public List<StudentClass> GetStudentsByName(string nameFilter)
        {
            List<StudentClass> students = new List<StudentClass>();

            try
            {
                database.OpenConnection();

                string query = $"SELECT u.Id, u.Name, u.Email, u.Telephone, f.Name AS FacultyName, c.Name AS ClassName, s.currSubject1 AS CurrSubject1, s.currSubject2 AS CurrSubject2, s.prevSubject1 AS PrevSubject1, s.prevSubject2 AS PrevSubject2 " +
                               $"FROM User u " +
                               $"JOIN Student s ON u.Id = s.UserId " +
                               $"LEFT JOIN Faculty f ON s.FacultyId = f.Id " +
                               $"LEFT JOIN Class c ON s.ClassId = c.Id " +
                               $"WHERE u.Role = 'student' AND u.Name LIKE '%{nameFilter}%' Or u.Email LIKE '%{nameFilter}%'";

                DataTable dataTable = database.ExecuteQuery(query);

                foreach (DataRow row in dataTable.Rows)
                {
                    StudentClass student = new StudentClass
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Name = row["Name"].ToString(),
                        Email = row["Email"].ToString(),
                        Telephone = row["Telephone"].ToString(),
                    };
                    student.SetFacultyName(row["FacultyName"].ToString());
                    student.SetClassName(row["ClassName"].ToString());
                    student.SetCurrentSubject1(row["CurrSubject1"].ToString());
                    student.SetCurrentSubject2(row["CurrSubject2"].ToString());
                    student.SetPreviousSubject1(row["PrevSubject1"].ToString());
                    student.SetPreviousSubject2(row["PrevSubject2"].ToString());
                    students.Add(student);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student data: {ex.Message}");
            }
            finally
            {
                database.CloseConnection();
            }

            return students;
        }

        public List<StudentClass> GetAllStudentSearch(string searchText)
        {
            List<StudentClass> users = new List<StudentClass>();
            try
            {
                database.OpenConnection();
                // construct the sql query with a WHERE clause to filter by name or email
                string query = $"SELECT * FROM user WHERE role = 'student' AND name LIKE '%{searchText}%'";

                DataTable dataTable = database.ExecuteQuery(query);

                foreach (DataRow row in dataTable.Rows)
                {
                    // convert the role value to lowercase for consistency
                    string roleString = row["Role"].ToString().ToLower();

                    // parse the lowercase role string to the UserRole enum
                    if (Enum.TryParse<UserRole>(roleString, true, out UserRole role))
                    {
                        // create a user object based on the data retrieved from the database
                        StudentClass user = new StudentClass
                        {
                            Id = Convert.ToInt32(row["Id"]),
                            Name = row["Name"].ToString(),
                            Email = row["Email"].ToString(),
                            Telephone = row["Telephone"].ToString(),
                            Role = role
                        };

                        users.Add(user);
                    }
                    else
                    {
                        // handle case where role string doesn't match any enum value
                        MessageBox.Show($"Error: Invalid role value '{roleString}' for user with ID {row["Id"]}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                database.CloseConnection();
            }

            return users;
        }
    }
}
