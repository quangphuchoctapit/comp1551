using System;
using System.Data;

namespace comp1551
{
    // derived class representing teacher
    public class TeacherClass : UserClass
    {
        public decimal Salary { get; set; }
        public string Subject1 { get; set; }
        public string Subject2 { get; set; }
        public string FacultyName { get; set; }
        public int FacultyId { get; set; }
        public string Qualifications { get; set; }
        public string Image { get; set; }
    }

    public class TeacherManage
    {
        private Database database;

        public TeacherManage(Database db)
        {
            database = db;
        }

        // method to add a new teacher to the database
        public void AddTeacher(TeacherClass teacher)
        {
            try
            {
                // Open database connection
                database.OpenConnection();

                // check if the email already exists in the database
                string checkEmailQuery = $"SELECT COUNT(*) FROM User WHERE Email = '{teacher.Email}'";
                int emailCount = database.GetCount(checkEmailQuery);
                if (emailCount > 0)
                {
                    Console.WriteLine("Email already exists. Please choose a different one.");
                    return;
                }

                // Convert the image to a Base64 string
                string base64Image = "";
                if (!string.IsNullOrEmpty(teacher.Image))
                {
                    base64Image = teacher.Image;
                }

                // insert new user into the database with the role 'teacher'
                string insertUserQuery = $"INSERT INTO User (Name, Telephone, Email, Role, Image, password) " +
                    $"VALUES ('{teacher.Name}', '{teacher.Telephone}', '{teacher.Email}', 'teacher', '{base64Image}', '123456')";

                // execute the insert query for the user
                database.ExecuteNonQuery(insertUserQuery);

                // Get the ID of the newly inserted user
                string getUserIdQuery = "SELECT LAST_INSERT_ID()";
                int userId = database.GetUserId(getUserIdQuery);

                string insertTeacherQuery = $"INSERT INTO Teacher (Qualifications, FacultyId, UserId, Salary, Subject1, Subject2) " +
                    $"VALUES ('{teacher.Qualifications}',  {teacher.FacultyId}, {userId}, '{teacher.Salary}', '{teacher.Subject1}', '{teacher.Subject2}')";

                // execute the insert query for the teacher
                database.ExecuteNonQuery(insertTeacherQuery);

                // Close database connection
                database.CloseConnection();
            }
            catch (Exception ex)
            {
                // display an error message if adding the teacher fails
                MessageBox.Show($"Error adding teacher: {ex.Message}");
            }
        }

        // Method to update an existing teacher in the database
        public void UpdateTeacher(int id, TeacherClass updatedTeacher)
        {
            try
            {
                database.OpenConnection();

                // update the user information
                string updateQueryUser = $"UPDATE User SET Name = '{updatedTeacher.Name}', " +
                    $"Email = '{updatedTeacher.Email}', Telephone = '{updatedTeacher.Telephone}', " +
                    $"Image = '{updatedTeacher.Image}' " +
                    $"WHERE Id = {id}";

                // update the teacher information
                string updateQueryTeacher = $"UPDATE Teacher SET Subject1 = '{updatedTeacher.Subject1}', " +
                    $"Subject2 = '{updatedTeacher.Subject2}', " +
                    $"Qualifications = '{updatedTeacher.Qualifications}', " +
                    $"FacultyId = '{updatedTeacher.FacultyId}' " +
                    $"WHERE UserId = {id}";

                // execute the update queries
                database.ExecuteNonQuery(updateQueryUser);
                database.ExecuteNonQuery(updateQueryTeacher);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating teacher: {ex.Message}");
            }
            finally
            {
                database.CloseConnection();
            }
        }

        // Method to delete an existing teacher from the database
        public void DeleteTeacher(int id)
        {
            database.OpenConnection();
            string queryUser = $"DELETE FROM user WHERE Id = {id} and role = 'teacher'";
            string queryTeacher = $"DELETE FROM teacher WHERE userId = {id}";
            database.ExecuteNonQuery(queryUser);
            database.ExecuteNonQuery(queryTeacher);
            database.CloseConnection();
        }

        // Method to retrieve all teachers from the database
        public List<TeacherClass> GetAllTeachers()
        {
            List<TeacherClass> teachers = new List<TeacherClass>();
            try
            {
                database.OpenConnection();

                string query = "SELECT u.Id, u.Name, u.Email, u.Telephone, f.Name AS FacultyName, t.Qualifications, t.salary AS Salary, t.subject1 AS Subject1, t.subject2 AS Subject2 " +
                                "FROM User u " +
                                "JOIN Teacher t ON u.Id = t.UserId " +
                                "LEFT JOIN Faculty f ON t.FacultyId = f.Id " +
                                "WHERE u.Role = 'teacher'";

                DataTable dataTable = database.ExecuteQuery(query);

                foreach (DataRow row in dataTable.Rows)
                {
                    TeacherClass teacher = new TeacherClass
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Name = row["Name"].ToString(),
                        Email = row["Email"].ToString(),
                        Telephone = row["Telephone"].ToString(),
                        FacultyName = row["FacultyName"].ToString(),
                        Salary = Convert.ToDecimal(row["Salary"]),
                        Qualifications = row["Qualifications"].ToString(),
                        Subject1 = row["Subject1"].ToString(),
                        Subject2 = row["Subject2"].ToString()
                    };
                    teachers.Add(teacher);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loadingsssss teacher data: {ex.Message}");
            }
            finally
            {
                database.CloseConnection();
            }

            return teachers;
        }


        // method to get all teachers by name
        public List<TeacherClass> GetTeachersByName(string nameFilter)
        {
            List<TeacherClass> teachers = new List<TeacherClass>();

            try
            {
                database.OpenConnection();

                string query = $"SELECT u.Id, u.Name, u.Email, u.Telephone, f.Name AS FacultyName, t.Qualifications, t.salary AS Salary, t.subject1 AS Subject1, t.subject2 AS Subject2 " +
                                $"FROM User u " +
                                $"JOIN Teacher t ON u.Id = t.UserId " +
                                $"LEFT JOIN Faculty f ON t.FacultyId = f.Id " +
                                $"WHERE u.Role = 'teacher' AND u.Name LIKE '%{nameFilter}%' OR u.Email LIKE '%{nameFilter}%'";

                DataTable dataTable = database.ExecuteQuery(query);

                foreach (DataRow row in dataTable.Rows)
                {
                    TeacherClass teacher = new TeacherClass
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Name = row["Name"].ToString(),
                        Email = row["Email"].ToString(),
                        Telephone = row["Telephone"].ToString(),
                        Salary = Convert.ToDecimal(row["Salary"]),
                        FacultyName = row["FacultyName"].ToString(),
                        Qualifications = row["Qualifications"].ToString(),
                        Subject1 = row["Subject1"].ToString(),
                        Subject2 = row["Subject2"].ToString()
                    };
                    teachers.Add(teacher);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading teacher data: {ex.Message}");
            }
            finally
            {
                database.CloseConnection();
            }

            return teachers;
        }

        public decimal GetTeacherSalary(int userId)
        {
            string query = "SELECT u.Id, t.salary AS Salary " +
                           "FROM User u " +
                           "JOIN Teacher t ON u.Id = t.UserId " +
                           $"WHERE u.Role = 'teacher' and u.id={userId}";

            DataTable dataTable = database.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                return Convert.ToDecimal(dataTable.Rows[0]["Salary"]);
            }
            else
            {
                return 0;
            }
        }


        // method to get 2 subjects based on the teacherId
        public string[] Get2Subjects(int teacherId)
        {
            string[] subjects = new string[2];

            try
            {
                database.OpenConnection();

                // Query to retrieve the subjects of the specified teacher
                string query = $"SELECT t.subject1 AS Subject1, t.subject2 AS Subject2 " +
                               $"FROM Teacher t " +
                               $"JOIN User u ON u.Id = t.UserId " +
                               $"WHERE u.Role = 'teacher' AND u.Id = {teacherId}";

                DataTable dataTable = database.ExecuteQuery(query);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    subjects[0] = row["Subject1"].ToString();
                    subjects[1] = row["Subject2"].ToString();
                }
                else
                {
                    MessageBox.Show("Subjects not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading subjects of teacher: {ex.Message}");
            }
            finally
            {
                database.CloseConnection();
            }

            return subjects;
        }


    }
}
