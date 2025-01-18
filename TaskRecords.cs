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

            Console.WriteLine($"Query: {query}");
            Console.WriteLine($"Rows affected: {count}"); // Debugging log

            return count;
        }

    }
}
