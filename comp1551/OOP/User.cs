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
    public abstract class UserClass
    {
        public  int Id { get; set; }
        public string Name { get; set; }
        public  string Telephone { get; set; }
        public  string Password { get; set; }
        public  string Email { get; set; }
        public  UserRole Role { get; set; }



        public abstract void View();

        public class UoGSystem
        {
            private Database database;

            public UoGSystem()
            {
                database = new Database();
                TeacherManage = new TeacherManage(database);
                AdminManage = new AdminManage(database);
                StudentManage = new StudentManage(database);
                PersonManage = new PersonManage(database);
            }
            public TeacherManage TeacherManage { get; }
            public AdminManage AdminManage { get; }
            public StudentManage StudentManage { get; }
            public PersonManage PersonManage { get; }

          
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
                            PersonClass user = new PersonClass
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
        public class PersonClass : UserClass
        {
            Database database = new Database();
            public override void View()
            {

            }

            /*      public override int Id { get; set; }
                  public override string Name { get; set; }
                  public override string Telephone { get; set; }
                  public override string Password { get; set; }
                  public override string Email { get; set; }
                  public override UserRole Role { get; set; }*/


        }
            public class PersonManage
            {
                private Database database;
                public PersonManage(Database db)
                {
                    database = db;
                }

                public List<PersonClass> GetAllUserSearch(string searchText)
                {
                    List<PersonClass> users = new List<PersonClass>();
                    try
                    {
                        database.OpenConnection();
                        // construct the sql query with a WHERE clause to filter by name or email
                        string query = $"SELECT * FROM user WHERE name LIKE '%{searchText}%'";

                        DataTable dataTable = database.ExecuteQuery(query);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            // convert the role value to lowercase for consistency
                            string roleString = row["Role"].ToString().ToLower();

                            // parse the lowercase role string to the UserRole enum
                            if (Enum.TryParse<UserRole>(roleString, true, out UserRole role))
                            {
                                // create a user object based on the data retrieved from the database
                                PersonClass user = new PersonClass
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
}
