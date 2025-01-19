using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskSchudler.TaskSchudler;

namespace TaskSchudler
{
    public partial class Profile : Form
    {
        private int _userID;
        private string _connectionString;
        private ProfileRecords profileRecords;

        // Constructor expects userID and connectionString
        public Profile(int userID, string connectionString)
        {
            InitializeComponent();
            _userID = userID;
            _connectionString = connectionString;

            // Initialize ProfileRecords
            profileRecords = new ProfileRecords(connectionString, userID);
        }

        private void UpdateTaskCounts()
        {
            int completedCount = profileRecords.GetCompletedTaskCount(_userID);
            int incompletedCount = profileRecords.GetIncompleteTaskCount(_userID);

            Countofcompleted.Text = $"{completedCount}";
            CountofIncompleted.Text = $"{incompletedCount}";
            Countofcompleted.TextAlign = ContentAlignment.MiddleCenter;
            CountofIncompleted.TextAlign = ContentAlignment.MiddleCenter;

            // Center the labels horizontally within the panel
            Countofcompleted.Location = new Point((CompletedPanel.ClientSize.Width - Countofcompleted.Width) / 2, Countofcompleted.Location.Y);
            CountofIncompleted.Location = new Point((IncompletedPanel.ClientSize.Width - CountofIncompleted.Width) / 2, CountofIncompleted.Location.Y);
        }
        private void LoadIncompleteTasks()
        {
            DataTable tasksTable = profileRecords.GetIncompleteTasks();

            // Bind the DataTable to the DataGridView
            ProfileTable.DataSource = tasksTable;

            // Format the DataGridView
            ProfileTable.Columns["TaskTitle"].HeaderText = "Task Title";
            ProfileTable.Columns["ReminderDate"].HeaderText = "Reminder Date";
            ProfileTable.Columns["DueDate"].HeaderText = "Due Date";
            ProfileTable.Columns["Importance"].HeaderText = "Importance";

            ProfileTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void RemindersPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RemindersNav_Click(object sender, EventArgs e)
        {

            Reminders Obj = new Reminders();
            Obj.Show();
            this.Close();
        }

        private void AllTasksNav_Click(object sender, EventArgs e)
        {

            All_Tasks Obj = new All_Tasks(_userID);
            Obj.Show();
            this.Close();
        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void Logolabel_Click(object sender, EventArgs e)
        {

        }

        private void ProfileNav_Click(object sender, EventArgs e)
        {

        }

        private void EscapeButtonu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            UpdateTaskCounts();
            LoadIncompleteTasks();
        }

        private void Countofcompleted_Click(object sender, EventArgs e)
        {

        }

        private void ProfileTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ProfileTable.DefaultCellStyle.Font = new Font("Century Gothic", 12);
            ProfileTable.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            if (ProfileTable.Columns[e.ColumnIndex].Name == "Importance" && e.RowIndex >= 0)

            {
                // Ensure the value in the cell is not null
                var importanceValue = ProfileTable.Rows[e.RowIndex].Cells["Importance"].Value;

                if (importanceValue != null)
                {
                    string importance = importanceValue.ToString(); // Convert it to string

                    // Set the row color based on the Importance level
                    if (importance == "Low")
                    {
                        ProfileTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#dcdcdc");  // Hex for Grey
                    }
                    else if (importance == "Medium")
                    {
                        ProfileTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#CA9C47");
                    }
                    else if (importance == "High")
                    {
                        ProfileTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#CB4752");
                    }
                    else
                    {
                        ProfileTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;  // Default color if no match
                    }
                }
                else
                {
                    // Handle null values gracefully by setting a default background color or any other action
                    ProfileTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;  // Set a neutral color if null
                }
            }
        }
    }
}
