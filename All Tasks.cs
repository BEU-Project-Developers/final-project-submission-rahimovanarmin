using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskSchudler
{
    public partial class All_Tasks : Form
    {
        private readonly TaskRecords _con;
        private readonly int _currentUserId; // Assume this is set during user login.
        private readonly string connectionString = @"Data Source=DESKTOP-LIJ1K35\SQLEXPRESS;Initial Catalog=TaskScheduler;Integrated Security=True";

        public All_Tasks(int userId)
        {
            InitializeComponent();
            _con = new TaskRecords();
            _currentUserId = userId;
            ShowTasks();
        }
        private void ConfigureDataGridView()
        {
            // Make TaskTitle, ReminderDate, DueDate, Status, and Importance editable
            foreach (DataGridViewColumn column in AlltasksTable.Columns)
            {
                if (column.Name == "TaskId") // Primary Key should remain non-editable
                {
                    column.ReadOnly = true;
                }
                else
                {
                    column.ReadOnly = false;
                }
            }
        }

        private void ShowTasks()
        {
           
            
                try
                {
                string query = "SELECT * FROM Taskss ORDER BY CASE WHEN Status = 'Completed' THEN 1 ELSE 0 END, DueDate";
                DataTable dt = _con.GetData(query);
                    AlltasksTable.DataSource = dt;

                    // Hide columns manually
                    AlltasksTable.Columns["TaskId"].Visible = false;
                    AlltasksTable.Columns["UserId"].Visible = false;
                AlltasksTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                AlltasksTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                AlltasksTable.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            }

            catch (Exception ex)
                {
                    MessageBox.Show($"Error loading tasks: {ex.Message}");
                }
            

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(taskTitleInput.Text))
            {
                MessageBox.Show("Missing data");
                return;
            }

            try
            {
                var parameters = new Dictionary<string, object>
            {
                { "@TaskTitle", taskTitleInput.Text },
                { "@ReminderDate", RemiderDateInput.Value },
                { "@DueDate", DueDateInput.Value },
                { "@Status", StatusCombo.SelectedItem.ToString() },
                { "@Importance", ImportanceCombo.SelectedItem.ToString() },
                { "@UserId", _currentUserId }
            };

                string query = "INSERT INTO Taskss (TaskTitle, ReminderDate, DueDate, Status, Importance, UserId) " +
                               "VALUES (@TaskTitle, @ReminderDate, @DueDate, @Status, @Importance, @UserId)";
                _con.SetData(query, parameters);

                MessageBox.Show("Task added!");
                ShowTasks();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RemindersNav_Click(object sender, EventArgs e)
        {
            Reminders Obj = new Reminders();
            Obj.Show();
            this.Close();
        }

        private void ProfileNav_Click(object sender, EventArgs e)
        {
            Profile Object = new Profile(_currentUserId,connectionString);
            Object.Show();
            this.Close();
        }

        private void EscapeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        

        private void AllTasksPanel_Paint(object sender, PaintEventArgs e)
        {

        }

         private void Edit_Click(object sender, EventArgs e)
            {
                if (AlltasksTable.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a task to update.");
                    return;
                }

                try
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = AlltasksTable.SelectedRows[0];

                    // Ensure TaskId is not null
                    if (selectedRow.Cells["TaskId"].Value == null)
                    {
                        MessageBox.Show("Invalid task selection.");
                        return;
                    }

                    // Get the task details from the UI
                    int taskId = Convert.ToInt32(selectedRow.Cells["TaskId"].Value);
                    string title = taskTitleInput.Text.Trim();
                    DateTime reminderDate = RemiderDateInput.Value;
                    DateTime dueDate = DueDateInput.Value;
                    string status = StatusCombo.SelectedItem?.ToString() ?? "";
                    string importance = ImportanceCombo.SelectedItem?.ToString() ?? "";

                    // Ensure required fields are filled
                    if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(status) || string.IsNullOrWhiteSpace(importance))
                    {
                        MessageBox.Show("Please fill in all fields.");
                        return;
                    }

                    // Update query
                    string query = "UPDATE Taskss " +
                                    "SET TaskTitle = @TaskTitle, ReminderDate = @ReminderDate, DueDate = @DueDate, " +
                                    "Status = @Status, Importance = @Importance " +
                                    "WHERE TaskId = @TaskId";

                    // Add parameters
                    var parameters = new Dictionary<string, object>
        {
            { "@TaskTitle", title },
            { "@ReminderDate", reminderDate },
            { "@DueDate", dueDate },
            { "@Status", status },
            { "@Importance", importance },
            { "@TaskId", taskId }
        };

                    // Execute update
                    int rowsAffected = _con.SetData(query, parameters);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Task updated successfully.");
                        ShowTasks(); // Refresh DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Update failed. No rows affected.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

    


        private void AlltasksTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked row index is valid (i.e., a row was clicked)
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = AlltasksTable.Rows[e.RowIndex];

                // Populate input fields with values from the selected row
                taskTitleInput.Text = selectedRow.Cells["TaskTitle"].Value.ToString();
                RemiderDateInput.Value = Convert.ToDateTime(selectedRow.Cells["ReminderDate"].Value);
                DueDateInput.Value = Convert.ToDateTime(selectedRow.Cells["DueDate"].Value);
                StatusCombo.SelectedItem = selectedRow.Cells["Status"].Value.ToString();
                ImportanceCombo.SelectedItem = selectedRow.Cells["Importance"].Value.ToString();
            }
        }

        private void AlltasksTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            AlltasksTable.DefaultCellStyle.Font = new Font("Century Gothic", 12);
            AlltasksTable.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            if (AlltasksTable.Columns[e.ColumnIndex].Name == "Importance" && e.RowIndex >= 0)

            {
                // Ensure the value in the cell is not null
                var importanceValue = AlltasksTable.Rows[e.RowIndex].Cells["Importance"].Value;

                if (importanceValue != null)
                {
                    string importance = importanceValue.ToString(); // Convert it to string

                    // Set the row color based on the Importance level
                    if (importance == "Low")
                    {
                        AlltasksTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#dcdcdc");  // Hex for Grey
                    }
                    else if (importance == "Medium")
                    {
                        AlltasksTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#CA9C47");  
                    }
                    else if (importance == "High")
                    {
                        AlltasksTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#CB4752"); 
                    }
                    else
                    {
                        AlltasksTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;  // Default color if no match
                    }
                }
                else
                {
                    // Handle null values gracefully by setting a default background color or any other action
                    AlltasksTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;  // Set a neutral color if null
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (AlltasksTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a task to delete.");
                return;
            }

            try
            {
                // Get the selected row
                DataGridViewRow selectedRow = AlltasksTable.SelectedRows[0];

                // Ensure TaskId is valid
                if (selectedRow.Cells["TaskId"].Value == null)
                {
                    MessageBox.Show("Invalid task selection.");
                    return;
                }

                int taskId = Convert.ToInt32(selectedRow.Cells["TaskId"].Value);

                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this task?",
                                                      "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }

                // Delete query
                string query = "DELETE FROM Taskss WHERE TaskId = @TaskId";

                // Add parameter
                var parameters = new Dictionary<string, object>
        {
            { "@TaskId", taskId }
        };

                // Execute delete
                int rowsAffected = _con.SetData(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Task deleted successfully.");
                    ShowTasks(); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Delete failed. Task not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void All_Tasks_Load(object sender, EventArgs e)
        {

        }
    }
}
