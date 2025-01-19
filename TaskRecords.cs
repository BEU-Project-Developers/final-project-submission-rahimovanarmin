using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace TaskSchudler
{
    internal class TaskRecords
    {
        private readonly string _connectionString;

        public TaskRecords()
        {
            _connectionString = @"Data Source=DESKTOP-LIJ1K35\SQLEXPRESS;Initial Catalog=TaskScheduler;Integrated Security=True";
        }

        public string ConnectionString => _connectionString;
        public DataTable GetAllTasks(int userId)
        {
            string query = "SELECT * FROM Taskss WHERE UserId = @UserId ORDER BY CASE WHEN Status = 'Completed' THEN 1 ELSE 0 END, DueDate";
            var parameters = new Dictionary<string, object> { { "@UserId", userId } };
            return GetData(query, parameters);
        }

        public int AddTask(string title, DateTime reminderDate, DateTime dueDate, string status, string importance, int userId)
        {
            string query = "INSERT INTO Taskss (TaskTitle, ReminderDate, DueDate, Status, Importance, UserId) " +
                           "VALUES (@TaskTitle, @ReminderDate, @DueDate, @Status, @Importance, @UserId)";
            var parameters = new Dictionary<string, object>
            {
                { "@TaskTitle", title },
                { "@ReminderDate", reminderDate },
                { "@DueDate", dueDate },
                { "@Status", status },
                { "@Importance", importance },
                { "@UserId", userId }
            };
            return SetData(query, parameters);
        }

        public int UpdateTask(int taskId, string title, DateTime reminderDate, DateTime dueDate, string status, string importance)
        {
            string query = "UPDATE Taskss " +
                           "SET TaskTitle = @TaskTitle, ReminderDate = @ReminderDate, DueDate = @DueDate, " +
                           "Status = @Status, Importance = @Importance " +
                           "WHERE TaskId = @TaskId";
            var parameters = new Dictionary<string, object>
            {
                { "@TaskId", taskId },
                { "@TaskTitle", title },
                { "@ReminderDate", reminderDate },
                { "@DueDate", dueDate },
                { "@Status", status },
                { "@Importance", importance }
            };
            return SetData(query, parameters);
        }

        public int DeleteTask(int taskId)
        {
            string query = "DELETE FROM Taskss WHERE TaskId = @TaskId";
            var parameters = new Dictionary<string, object>
            {
                { "@TaskId", taskId }
            };
            return SetData(query, parameters);
        }

        
        public DataTable GetData(string query, Dictionary<string, object> parameters = null)
        {
            var dataTable = new DataTable();

            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }

                    using (var adapter = new SqlDataAdapter(command))
                    {
                        connection.Open();
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        
        public int SetData(string query, Dictionary<string, object> parameters = null)
        {
            int count = 0;

            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }

                    connection.Open();
                    count = command.ExecuteNonQuery();
                }
            }

            return count;
        }
    }
}
