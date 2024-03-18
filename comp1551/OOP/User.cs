using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;

namespace comp1551
{
    // Enum to represent user roles
    public enum UserRole
    {
        Teacher,
        Admin,
        Student
    }

    // Base class representing a user
    public class UserClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public UserRole Role { get; set; }


        public class UoGSystem
        {
            private Database database;

            public UoGSystem()
            {
                database = new Database();
                TeacherManage = new TeacherManage(database);
                AdminManage = new AdminManage(database);
                StudentManage = new StudentManage(database);
            }
            public TeacherManage TeacherManage { get; }
            public AdminManage AdminManage { get; }
            public StudentManage StudentManage { get; }

            public List<UserClass> GetAllUsers()
            {
                List<UserClass> users = new List<UserClass>();

                try
                {
                    database.OpenConnection();
                    string query = "SELECT * FROM User";
                    DataTable dataTable = database.ExecuteQuery(query);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        // convert the role value to lowercase for consistency
                        string roleString = row["Role"].ToString().ToLower();

                        // Parse the lowercase role string to the UserRole enum
                        if (Enum.TryParse<UserRole>(roleString, true, out UserRole role))
                        {
                            // Create a user object based on the data retrieved from the database
                            UserClass user = new UserClass
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
                            // Handle case where role string doesn't match any enum value
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

            public List<UserClass> GetAllUsersByRole(string roleInput)
            {
                List<UserClass> users = new List<UserClass>();

                try
                {
                    database.OpenConnection();
                    string query = $"SELECT * FROM User where ROLE='{roleInput}'";
                    DataTable dataTable = database.ExecuteQuery(query);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Convert the role value to lowercase for consistency
                        string roleString = row["Role"].ToString().ToLower();

                        // Parse the lowercase role string to the UserRole enum
                        if (Enum.TryParse<UserRole>(roleString, true, out UserRole role))
                        {
                            // Create a user object based on the data retrieved from the database
                            UserClass user = new UserClass
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
                            // Handle case where role string doesn't match any enum value
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

            public List<UserClass> GetAllUsersSearch(string searchText)
            {
                List<UserClass> users = new List<UserClass>();

                try
                {
                    database.OpenConnection();

                    // construct the sql query with a WHERE clause to filter by name or email
                    string query = $"SELECT * FROM User WHERE Name LIKE '%{searchText}%' OR Email LIKE '%{searchText}%'";

                    DataTable dataTable = database.ExecuteQuery(query);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Convert the role value to lowercase for consistency
                        string roleString = row["Role"].ToString().ToLower();

                        // Parse the lowercase role string to the UserRole enum
                        if (Enum.TryParse<UserRole>(roleString, true, out UserRole role))
                        {
                            // create a user object based on the data retrieved from the database
                            UserClass user = new UserClass
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
                            // Handle case where role string doesn't match any enum value
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
            public List<UserClass> GetAllUsersSearchByRole(string searchText, string roleInput)
            {
                List<UserClass> users = new List<UserClass>();
                try
                {
                    database.OpenConnection();
                    // construct the sql query with a WHERE clause to filter by name or email
                    string query = $"SELECT * FROM user WHERE role = '{roleInput}' AND name LIKE '%{searchText}%'";
                    if (roleInput == "user")
                    {
                        query = $"SELECT * FROM user WHERE name LIKE '%{searchText}%'";
                    }

                    DataTable dataTable = database.ExecuteQuery(query);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        // convert the role value to lowercase for consistency
                        string roleString = row["Role"].ToString().ToLower();

                        // parse the lowercase role string to the UserRole enum
                        if (Enum.TryParse<UserRole>(roleString, true, out UserRole role))
                        {
                            // create a user object based on the data retrieved from the database
                            UserClass user = new UserClass
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

            // Method to delete an existing user from the database
            public void DeleteUser(int id)
            {
                database.OpenConnection();
                string queryUser = $"DELETE FROM user WHERE Id = {id}";
                database.ExecuteNonQuery(queryUser);
                database.CloseConnection();
            }
        }

    }
}
