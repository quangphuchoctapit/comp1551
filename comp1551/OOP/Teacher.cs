using comp1551.ExtensionWinform;
using Mysqlx.Datatypes;
using System;
using System.Collections.Generic;
using System.Data;

namespace comp1551
{
    // derived class representing teacher
    public class TeacherClass : UserClass
    {
        public override void View()
        {
            // view() of this class will be different to other view() from other classes
            // but in this case, I do not do anything here because View() method for teacher
            // will be overriden in TeacherManage below.
            // for instance, this View() can be used to get all teacher data, like getAllTeacher() method below 
        }

        private decimal Salary;
        private string Subject1;
        private string Subject2;
        private string FacultyName;
        private int FacultyId;
        private string Qualifications;
        private string Image;

        // Accessor methods
        public decimal GetSalary() => Salary;
        public void SetSalary(decimal salary) => Salary = salary;

        public string GetSubject1() => Subject1;
        public void SetSubject1(string subject1) => Subject1 = subject1;

        public string GetSubject2() => Subject2;
        public void SetSubject2(string subject2) => Subject2 = subject2;

        public string GetFacultyName() => FacultyName;
        public void SetFacultyName(string facultyName) => FacultyName = facultyName;

        public int GetFacultyId() => FacultyId;
        public void SetFacultyId(int facultyId) => FacultyId = facultyId;

        public string GetQualifications() => Qualifications;
        public void SetQualifications(string qualifications) => Qualifications = qualifications;

        public string GetImage() => Image;
        public void SetImage(string image) => Image = image;
    }

    public class TeacherManage : UserClass
    {
        private Database database;

        public TeacherManage(Database db)
        {
            database = db;
        }

        public override void View()
        {
            List<TeacherClass> teachers = GetAllTeachers();
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
                    MessageBox.Show("Email already exists. Please choose a different one.");
                    return;
                }

                // Convert the image to a Base64 string
                string base64Image = "";
                if (!string.IsNullOrEmpty(teacher.GetImage()))
                {
                    base64Image = teacher.GetImage();
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
                    $"VALUES ('{teacher.GetQualifications()}',  {teacher.GetFacultyId()}, {userId}, '{teacher.GetSalary()}', '{teacher.GetSubject1()}', '{teacher.GetSubject2()}')";

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
                // check if the email already exists in the database
                string checkEmailQuery = $"SELECT COUNT(*) FROM User WHERE Email = '{updatedTeacher.Email}'";
                int emailCount = database.GetCount(checkEmailQuery);
                    // update the user information
                    string updateQueryUser = $"UPDATE User SET Name = '{updatedTeacher.Name}', " +
                    $"Email = '{updatedTeacher.Email}', Telephone = '{updatedTeacher.Telephone}', " +
                    $"Image = '{updatedTeacher.GetImage()}' " +
                    $"WHERE Id = {id}";

                // update the teacher information
                string updateQueryTeacher = $"UPDATE Teacher SET Subject1 = '{updatedTeacher.GetSubject1()}', " +
                    $"Subject2 = '{updatedTeacher.GetSubject2()}', " +
                    $"Qualifications = '{updatedTeacher.GetQualifications()}', " +
                    $"FacultyId = '{updatedTeacher.GetFacultyId()}' " +
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
                        Telephone = row["Telephone"].ToString()
                    };

                    teacher.SetFacultyName(row["FacultyName"].ToString());
                    teacher.SetSalary(Convert.ToDecimal(row["Salary"]));
                    teacher.SetQualifications(row["Qualifications"].ToString());
                    teacher.SetSubject1(row["Subject1"].ToString());
                    teacher.SetSubject2(row["Subject2"].ToString());

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
                        Telephone = row["Telephone"].ToString()
                    };

                    teacher.SetSalary(Convert.ToDecimal(row["Salary"]));
                    teacher.SetFacultyName(row["FacultyName"].ToString());
                    teacher.SetQualifications(row["Qualifications"].ToString());
                    teacher.SetSubject1(row["Subject1"].ToString());
                    teacher.SetSubject2(row["Subject2"].ToString());

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



        public List<TeacherClass> GetAllTeacherSearch(string searchText)
        {
            List<TeacherClass> users = new List<TeacherClass>();
            try
            {
                database.OpenConnection();
                // construct the sql query with a WHERE clause to filter by name or email
                string query = $"SELECT * FROM user WHERE role = 'teacher' AND name LIKE '%{searchText}%'";

                DataTable dataTable = database.ExecuteQuery(query);

                foreach (DataRow row in dataTable.Rows)
                {
                    // convert the role value to lowercase for consistency
                    string roleString = row["Role"].ToString().ToLower();

                    // parse the lowercase role string to the UserRole enum
                    if (Enum.TryParse<UserRole>(roleString, true, out UserRole role))
                    {
                        // create a user object based on the data retrieved from the database
                        TeacherClass user = new TeacherClass
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
