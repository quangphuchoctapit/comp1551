using System;
using System.Data;
using static System.Windows.Forms.Design.AxImporter;
using System.Text.Json;
using MySql.Data.MySqlClient;

namespace comp1551
{
    // derived class representing student
    public class StudentClass : UserClass
    {
        public string CurrentSubject1 { get; set; }
        public string CurrentSubject2 { get; set; }
        public string PreviousSubject1 { get; set; }
        public string PreviousSubject2 { get; set; }
        public string FacultyName { get; set; }
        public string ClassName { get; set; }
        public string Image { get; set; }
        public int FacultyId { get; set; }
        public int ClassId { get; set; }
    }

    public class StudentManage
    {

        private Database database;
        public StudentManage(Database db)
        {
            database = db;
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
                    Console.WriteLine("Email already exists. Please choose a different one.");
                    return;
                }

                // Convert the image to a Base64 string
                string base64Image = "";
                if (!string.IsNullOrEmpty(student.Image))
                {
                    base64Image = student.Image;
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
                    $"VALUES ('{student.CurrentSubject1}',  '{student.CurrentSubject2}', {userId}, '{student.PreviousSubject1}', '{student.PreviousSubject2}', '{student.FacultyId}', '{student.ClassId}')";

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

            string imageValue = updatedStudent.Image != null ? $"'{updatedStudent.Image}'" : "NULL";
            string updateQueryUser = $"UPDATE User SET Name = '{updatedStudent.Name}', " +
                $"Email = '{updatedStudent.Email}', Telephone = '{updatedStudent.Telephone}', " +
                $"Image = {imageValue} WHERE Id = '{id}'";

            // Update the student information
            string updateQueryStudent = $"UPDATE Student SET FacultyId = '{updatedStudent.FacultyId}', " +
                $"ClassId = '{updatedStudent.ClassId}', " +
                $"currSubject1 = '{updatedStudent.CurrentSubject1}', " +
                $"currSubject2 = '{updatedStudent.CurrentSubject2}', " +
                $"prevSubject1 = '{updatedStudent.PreviousSubject1}', " +
                $"prevSubject2 = '{updatedStudent.PreviousSubject2}' " +
                $"WHERE UserId = '{id}'";

            try
            {
                // Open database connection
                database.OpenConnection();

                // Execute the query to update the User table
                database.ExecuteNonQuery(updateQueryUser);

                // Execute the query to update the Student table
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

                string query = "SELECT u.Id, u.Name, u.Email, u.Telephone, f.Name AS FacultyName, c.Name AS ClassName, s.currSubject1 AS CurrSubject1, s.currSubject2 AS CurrSubject2, s.prevSubject1 AS PrevSubject1, s.prevSubject2 AS PrevSubject2 " +
                               "FROM User u " +
                               "JOIN Student s ON u.Id = s.UserId " +
                               "LEFT JOIN Faculty f ON s.FacultyId = f.Id " +
                               "LEFT JOIN Class c ON s.ClassId = c.Id " +
                               "WHERE u.Role = 'student'";

                DataTable dataTable = database.ExecuteQuery(query);

                foreach (DataRow row in dataTable.Rows)
                {
                    StudentClass student = new StudentClass
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Name = row["Name"].ToString(),
                        Email = row["Email"].ToString(),
                        Telephone = row["Telephone"].ToString(),
                        FacultyName = row["FacultyName"].ToString(),
                        ClassName = row["ClassName"].ToString(),
                        CurrentSubject1 = row["CurrSubject1"].ToString(),
                        CurrentSubject2 = row["CurrSubject2"].ToString(),
                        PreviousSubject1 = row["PrevSubject1"].ToString(),
                        PreviousSubject2 = row["PrevSubject2"].ToString()
                    };
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
                        FacultyName = row["FacultyName"].ToString(),
                        ClassName = row["ClassName"].ToString(),
                        CurrentSubject1 = row["CurrSubject1"].ToString(),
                        CurrentSubject2 = row["CurrSubject2"].ToString(),
                        PreviousSubject1 = row["PrevSubject1"].ToString(),
                        PreviousSubject2 = row["PrevSubject2"].ToString()
                    };
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



    }
}
