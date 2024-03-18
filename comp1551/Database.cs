using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace comp1551
{
    public class Database
    {
        private MySqlConnection connection;
        private string connectionString = "server=127.0.0.1; user=root; database=comp1551; password=";

        // Constructor to initialize the Database class
        public Database()
        {
            // Create a new MySqlConnection using the provided connection string
            connection = new MySqlConnection(connectionString);
        }

        // Method to open the database connection
        public void OpenConnection()
        {
            try
            {
                // attempt to open the database connection
                connection.Open();
                Console.WriteLine("Database connection opened.");
            }
            catch (MySqlException ex)
            {
                // display an error message if opening the connection fails
                Console.WriteLine($"Error opening database connection: {ex.Message}");
            }
        }

        // method to close the database connection
        public void CloseConnection()
        {
            try
            {
                // attempt to close the database connection
                connection.Close();
                Console.WriteLine("Database connection closed.");
            }
            catch (MySqlException ex)
            {
                // display an error message if closing the connection fails
                Console.WriteLine($"Error closing database connection: {ex.Message}");
            }
        }

        // method to execute a query and return the result as a DataTable
        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                // create a MySqlCommand with the provided query and connection
                MySqlCommand command = new MySqlCommand(query, connection);

                // create a MySqlDataAdapter to fill the DataTable with the query results
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                // fill the DataTable with the results from the query
                adapter.Fill(dataTable);
            }
            catch (MySqlException ex)
            {
                // display an error message if executing the query fails
                Console.WriteLine($"Error executing query: {ex.Message}");
            }
            return dataTable;
        }

        // method to execute a non-query SQL statement (e.g., INSERT, UPDATE, DELETE)
        public void ExecuteNonQuery(string query)
        {
            try
            {
                // create a MySqlCommand with the provided query and connection
                MySqlCommand command = new MySqlCommand(query, connection);

                // execute the non-query SQL statement (no result returned)
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                // display an error message if executing the query fails
                Console.WriteLine($"Error executing query: {ex.Message}");
            }
        }

        // method to execute a query and return the count of the result
        public int GetCount(string query)
        {
            int count = 0;
            try
            {
                // create a MySqlCommand with the provided query and connection
                MySqlCommand command = new MySqlCommand(query, connection);

                // execute the query and get the count of the result
                count = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (MySqlException ex)
            {
                // display an error message if executing the query fails
                Console.WriteLine($"Error executing query: {ex.Message}");
            }
            return count;
        }

        // method to execute a query and return a single value (e.g., user ID)
        public int GetUserId(string query)
        {
            int userId = 0;
            try
            {
                // create a MySqlCommand with the provided query and connection
                MySqlCommand command = new MySqlCommand(query, connection);

                // execute the query and get the result as an object
                object result = command.ExecuteScalar();

                // convert the result to an integer if it's not null
                if (result != null && result != DBNull.Value)
                {
                    userId = Convert.ToInt32(result);
                }
            }
            catch (MySqlException ex)
            {
                // display an error message if getting the user ID fails
                Console.WriteLine($"Error getting user ID: {ex.Message}");
            }
            return userId;
        }



    }
}
