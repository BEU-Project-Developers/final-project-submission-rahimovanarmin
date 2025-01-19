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
        private readonly int _currentUserId;

        public All_Tasks(int userId)
        {
            InitializeComponent();
            _con = new TaskRecords();
            _currentUserId = userId;
            ShowTasks();
        }
        private void ConfigureDataGridView()
        {
            foreach (DataGridViewColumn column in AlltasksTable.Columns)
            {
                if (column.Name == "TaskId")
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
                DataTable dt = _con.GetAllTasks(_currentUserId);
                AlltasksTable.DataSource = dt;

                // Hide certain columns
                AlltasksTable.Columns["TaskId"].Visible = false;
                AlltasksTable.Columns["UserId"].Visible = false;

                // Style the DataGridView
                AlltasksTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                AlltasksTable.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                AlltasksTable.DefaultCellStyle.Font = new Font("Century Gothic", 12);
                AlltasksTable.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 14, FontStyle.Bold);
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
                string title = taskTitleInput.Text;
                DateTime reminderDate = RemiderDateInput.Value;
                DateTime dueDate = DueDateInput.Value;
                string status = StatusCombo.SelectedItem?.ToString();
                string importance = ImportanceCombo.SelectedItem?.ToString();

                if (string.IsNullOrWhiteSpace(status) || string.IsNullOrWhiteSpace(importance))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                int rowsAffected = _con.AddTask(title, reminderDate, dueDate, status, importance, _currentUserId);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Task added!");
                    ShowTasks();
                }
                else
                {
                    MessageBox.Show("Failed to add task.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
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
                DataGridViewRow selectedRow = AlltasksTable.SelectedRows[0];
                int taskId = Convert.ToInt32(selectedRow.Cells["TaskId"].Value);

                string title = taskTitleInput.Text.Trim();
                DateTime reminderDate = RemiderDateInput.Value;
                DateTime dueDate = DueDateInput.Value;
                string status = StatusCombo.SelectedItem?.ToString() ?? "";
                string importance = ImportanceCombo.SelectedItem?.ToString() ?? "";

                if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(status) || string.IsNullOrWhiteSpace(importance))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                int rowsAffected = _con.UpdateTask(taskId, title, reminderDate, dueDate, status, importance);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Task updated successfully.");
                    ShowTasks();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RemindersNav_Click(object sender, EventArgs e)
        {
            string connectionString = _con.ConnectionString;
            Reminders remindersForm = new Reminders(_currentUserId, connectionString);
            remindersForm.Show();
            this.Close();
        }

        private void ProfileNav_Click(object sender, EventArgs e)
        {
            string connectionString = _con.ConnectionString;
            Profile profileForm = new Profile(_currentUserId, connectionString);
            profileForm.Show();
            this.Close();
        }

        private void EscapeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void AllTasksPanel_Paint(object sender, PaintEventArgs e)
        {

        }




        private void AlltasksTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = AlltasksTable.Rows[e.RowIndex];

                taskTitleInput.Text = selectedRow.Cells["TaskTitle"].Value.ToString();
                RemiderDateInput.Value = Convert.ToDateTime(selectedRow.Cells["ReminderDate"].Value);
                DueDateInput.Value = Convert.ToDateTime(selectedRow.Cells["DueDate"].Value);
                StatusCombo.SelectedItem = selectedRow.Cells["Status"].Value.ToString();
                ImportanceCombo.SelectedItem = selectedRow.Cells["Importance"].Value.ToString();
            }
        }


        private void AlltasksTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            TableApperance.ApplyCellFormatting(AlltasksTable, e);
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
                DataGridViewRow selectedRow = AlltasksTable.SelectedRows[0];
                int taskId = Convert.ToInt32(selectedRow.Cells["TaskId"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this task?",
                                                      "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }

                int rowsAffected = _con.DeleteTask(taskId);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Task deleted successfully.");
                    ShowTasks();
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
            ShowTasks();
        }
    }
}