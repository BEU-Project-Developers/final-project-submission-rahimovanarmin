using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSchudler
{
    public class ProfileRecords
    {
        private string _connectionString;
        private int _userID;

        public ProfileRecords(string connectionString, int userID)
        {
            _connectionString = connectionString;
            _userID = userID;
        }

        public int GetCompletedTaskCount(int userID)
        {
            int completedCount = 0;
            // SQL query to get completed tasks count
            string query = "SELECT COUNT(*) FROM Taskss WHERE UserID = @UserID AND Status = 'Completed'"; // Adjust to your schema

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userID);
                connection.Open();
                completedCount = (int)command.ExecuteScalar();
            }

            return completedCount;
        }

        public int GetIncompleteTaskCount(int userID)
        {
            int incompleteCount = 0;
            // SQL query to get incomplete tasks count
            string query = "SELECT COUNT(*) FROM Taskss WHERE UserID = @UserID AND Status = 'Incomplete'"; // Adjust to your schema

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userID);
                connection.Open();
                incompleteCount = (int)command.ExecuteScalar();
            }

            return incompleteCount;
        }
    }
}
