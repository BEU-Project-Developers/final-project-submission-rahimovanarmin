using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSchudler
{
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

            public int GetCompletedTaskCount(int _userID)
            {
                int completedCount = 0;
                string query = "SELECT COUNT(*) FROM Taskss WHERE UserID = @UserID AND Status = 'Completed'";

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", _userID);
                    connection.Open();
                    completedCount = (int)command.ExecuteScalar();
                }

                return completedCount;
            }

            public int GetIncompleteTaskCount(int _userID)
            {
                int incompleteCount = 0;
                string query = "SELECT COUNT(*) FROM Taskss WHERE UserID = @UserID AND Status = 'Incompleted'";

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", _userID);
                    connection.Open();
                    incompleteCount = (int)command.ExecuteScalar();
                }

                return incompleteCount;
            }

            public DataTable GetIncompleteTasks()
            {
                DataTable tasksTable = new DataTable();
                string query = @"
                SELECT TaskTitle, ReminderDate, DueDate, Importance
                FROM Taskss
                 WHERE UserID = @UserID 
                 AND Status = 'Incompleted'
                 AND DueDate BETWEEN GETDATE() AND DATEADD(DAY, 7, GETDATE())";

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", _userID);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        tasksTable.Load(reader);
                    }
                }

                return tasksTable;
            }


            //reminders
            public DataTable GetTodaysReminders()
            {
                DataTable remindersTable = new DataTable();
                string query = @"
                SELECT TaskTitle, DueDate, Importance, Status
                FROM Taskss
                WHERE CONVERT(DATE, ReminderDate) = CAST(GETDATE() AS DATE)
                ";  // Only today's reminders

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", _userID);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        remindersTable.Load(reader);
                    }
                }

                return remindersTable;
            }
          

        }

    }
}