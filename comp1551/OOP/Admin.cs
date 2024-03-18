using System;
using System.Data;

namespace comp1551
{
    // derived class representing admin
    public class AdminClass : UserClass
    {
        public decimal Salary { get; set; }
        public bool FullTime { get; set; }
        public int WorkingHours { get; set; }

    }

    public class AdminManage {

        private Database database;

        public AdminManage(Database db)
        {
            database = db;
        }

        // method to insert admin if not already inserted
        public void InsertAdminIfNotExists()
        {
            try
            {
                // Open connection
                database.OpenConnection();

                // query to check if an admin already exists
                string checkAdminQuery = "SELECT COUNT(*) FROM User WHERE Role = 'admin'";

                // execute the query to get the count of admin records
                int adminCount = database.GetCount(checkAdminQuery);

                // if no admin record exists, insert admin
                if (adminCount == 0)
                {
                    try
                    {

                        // Insert new user into the database with the role 'admin'
                        string insertUserQuery = "INSERT INTO User (Name, Telephone, Email, Role, Image) " +
                                                  "VALUES ('', '', '', 'admin', '')";

                        // execute the insert query for the user
                        database.ExecuteNonQuery(insertUserQuery);

                        // get the ID of the newly inserted user
                        string getUserIdQuery = "SELECT LAST_INSERT_ID()";
                        int userId = database.GetUserId(getUserIdQuery);

                        // insert into admin table using the obtained user ID
                        string insertAdminQuery = $"INSERT INTO Admin (userId, salary, workingHours, isFullTime) " +
                                                  $"VALUES ({userId}, 0, 0, 1)";

                        // execute the insert query for the admin
                        database.ExecuteNonQuery(insertAdminQuery);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error inserting admin: {ex.Message}");
                    }
                    finally
                    {
                        // close connection
                        database.CloseConnection();
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error checking/inserting admin: {ex.Message}");
            }
            finally
            {
                // close connection
                database.CloseConnection();
            }
        }

        // add admin
        public void AddAdmin(AdminClass admin)
        {
            string query = $"INSERT INTO admins (Name, Telephone, Email, Role, Salary, FullTime, WorkingHours) VALUES ('{admin.Name}', '{admin.Telephone}', '{admin.Email}', '{admin.Role}', '{admin.Salary}', '{admin.FullTime}', '{admin.WorkingHours}')";
            database.ExecuteNonQuery(query);
        }

        public void UpdateAdmin(int id, AdminClass updatedAdmin)
        {
            try
            {
                database.OpenConnection();

                // query to update the user information
                string userQuery = $"UPDATE user " +
                                   $"SET name = '{updatedAdmin.Name}', " +
                                   $"telephone = '{updatedAdmin.Telephone}', " +
                                   $"email = '{updatedAdmin.Email}', " +
                                   $"password = '{updatedAdmin.Password}'" +
                                   $"WHERE id = '{id}'";

                database.ExecuteNonQuery(userQuery);

                // update the admin table based on the user information
                string adminQuery = $"UPDATE admin " +
                                    $"SET salary = '{updatedAdmin.Salary}', " +
                                    $"workingHours = '{updatedAdmin.WorkingHours}', " +
                                    $"isFullTime = '{(updatedAdmin.FullTime ? 1 : 0)}' " +
                                    $"WHERE userId = '{id}'";

                database.ExecuteNonQuery(adminQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user information: {ex.Message}");
            }
            finally
            {
                database.CloseConnection();
            }
        }


       /* public void DeleteAdmin(int id)
        {
            string query = $"DELETE FROM admins WHERE Id = {id}";
            database.ExecuteNonQuery(query);
        }*/

        // method to get all admin (this is deprecated because there is only 1 admin
        public List<AdminClass> GetAllAdmins()
        {
            List<AdminClass> admins = new List<AdminClass>();
            string query = "SELECT * FROM admins";
            DataTable dataTable = database.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                AdminClass admin = new AdminClass
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString(),
                    Telephone = row["Telephone"].ToString(),
                    Email = row["Email"].ToString(),
                    Role = UserRole.Admin,
                    Salary = Convert.ToDecimal(row["Salary"]),
                    FullTime = Convert.ToBoolean(row["FullTime"]),
                    WorkingHours = Convert.ToInt32(row["WorkingHours"])
                };
                admins.Add(admin);
            }
            return admins;
        }

        // method to get admin salary

        public decimal GetAdminSalary()
        {
            string query = "SELECT salary FROM admin"; // Limit to 1 row since there should be only one row in admin table

            DataTable dataTable = database.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                // Assuming 'salary' column is of decimal type
                return Convert.ToDecimal(dataTable.Rows[0]["salary"]);
            }
            else
            {
                return 0; // Or any other appropriate default value
            }
        }

        // method to get admin's working hours

        public decimal GetAdminWorkingHours()
        {
            string query = "SELECT workingHours FROM admin"; // Limit to 1 row since there should be only one row in admin table

            DataTable dataTable = database.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                // Assuming 'salary' column is of decimal type
                return Convert.ToDecimal(dataTable.Rows[0]["workingHours"]);
            }
            else
            {
                return 0; // Or any other appropriate default value
            }
        }

        // method to check if the admin is working full time or part time?
        public bool ValidateFullTime()
        {
            string query = "SELECT isFullTime FROM admin"; 

            DataTable dataTable = database.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                return Convert.ToBoolean(dataTable.Rows[0]["isFullTime"]);
            }
            else
            {
                // If no data found, assuming it's not full time
                return false;
            }
        }


    }
}

