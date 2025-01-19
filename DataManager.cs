using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace TaskSchudler
{
    internal class DatabaseManager
    {
        private readonly string _connectionString;

        // Constructor to initialize the connection string
        public DatabaseManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Method to retrieve data from the database
        public DataTable GetData(string query, Dictionary<string, object> parameters = null)
        {
            return ExecuteQuery(query, parameters);
        }

        // Method to insert, update or delete data (non-query operations)
        public int SetData(string query, Dictionary<string, object> parameters = null)
        {
            return ExecuteNonQuery(query, parameters);
        }

        // Method to execute queries that return data (SELECT)
        private DataTable ExecuteQuery(string query, Dictionary<string, object> parameters)
        {
            var dataTable = new DataTable();

            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    AddParametersToCommand(command, parameters);

                    using (var adapter = new SqlDataAdapter(command))
                    {
                        connection.Open();
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        // Method to execute non-query commands (INSERT, UPDATE, DELETE)
        private int ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            int affectedRows;

            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    AddParametersToCommand(command, parameters);

                    connection.Open();
                    affectedRows = command.ExecuteNonQuery();
                }
            }

            LogQueryExecution(query, affectedRows);
            return affectedRows;
        }

        // Method to add parameters to a SQL command
        private void AddParametersToCommand(SqlCommand command, Dictionary<string, object> parameters)
        {
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    command.Parameters.Add(param.Key, SqlDbType.VarChar).Value = param.Value;
                }
            }
        }

        // Method to log the query execution details
        private void LogQueryExecution(string query, int affectedRows)
        {
            Console.WriteLine($"Query executed: {query}");
            Console.WriteLine($"Rows affected: {affectedRows}");
        }

        // Example method to fetch today's reminders from the database
        public DataTable GetTodaysReminders(int userId)
        {
            string query = "SELECT TaskTitle, DueDate, Importance, Status FROM Taskss WHERE UserId = @UserId AND DueDate = CAST(GETDATE() AS DATE)";
            var parameters = new Dictionary<string, object> { { "@UserId", userId } };
            return GetData(query, parameters);
        }

        // Example method to fetch all tasks for a user
        public DataTable GetAllTasks(int userId)
        {
            string query = "SELECT TaskTitle, DueDate, Importance, Status FROM Taskss WHERE UserId = @UserId";
            var parameters = new Dictionary<string, object> { { "@UserId", userId } };
            return GetData(query, parameters);
        }

        // Example method to insert a new task
        public int AddTask(int userId, string taskTitle, DateTime dueDate, string importance, string status)
        {
            string query = "INSERT INTO Taskss (UserId, TaskTitle, DueDate, Importance, Status) VALUES (@UserId, @TaskTitle, @DueDate, @Importance, @Status)";
            var parameters = new Dictionary<string, object>
            {
                { "@UserId", userId },
                { "@TaskTitle", taskTitle },
                { "@DueDate", dueDate },
                { "@Importance", importance },
                { "@Status", status }
            };
            return SetData(query, parameters);
        }

        // Example method to update an existing task
        public int UpdateTask(int taskId, string taskTitle, DateTime dueDate, string importance, string status)
        {
            string query = "UPDATE Taskss SET TaskTitle = @TaskTitle, DueDate = @DueDate, Importance = @Importance, Status = @Status WHERE TaskId = @TaskId";
            var parameters = new Dictionary<string, object>
            {
                { "@TaskId", taskId },
                { "@TaskTitle", taskTitle },
                { "@DueDate", dueDate },
                { "@Importance", importance },
                { "@Status", status }
            };
            return SetData(query, parameters);
        }

        // Example method to delete a task
        public int DeleteTask(int taskId)
        {
            string query = "DELETE FROM Taskss WHERE TaskId = @TaskId";
            var parameters = new Dictionary<string, object> { { "@TaskId", taskId } };
            return SetData(query, parameters);
        }

        // Example method to get the profile of a user
        public DataTable GetUserProfile(int userId)
        {
            string query = "SELECT Name, Email FROM Userss WHERE UserId = @UserId";
            var parameters = new Dictionary<string, object> { { "@UserId", userId } };
            return GetData(query, parameters);
        }

        // Example method to update user profile information
        public int UpdateUserProfile(int userId, string name, string email)
        {
            string query = "UPDATE Userss SET Name = @Name, Email = @Email WHERE UserId = @UserId";
            var parameters = new Dictionary<string, object>
            {
                { "@UserId", userId },
                { "@Name", name },
                { "@Email", email }
            };
            return SetData(query, parameters);
        }
    }
}
