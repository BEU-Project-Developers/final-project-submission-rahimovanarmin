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
    public partial class Reminders : Form
    {
        private int _userID;
        private string _connectionString;
        private ProfileRecords profileRecords;

        public Reminders(int userID, string connectionString)
        {
            InitializeComponent();
            _userID = userID;
            _connectionString = connectionString;

            // Initialize ProfileRecords
            profileRecords = new ProfileRecords(connectionString, userID);
        }

        private void Reminders_Load(object sender, EventArgs e)
        {
            // Load today's reminders
            LoadTodaysReminders();
        }

        private void LoadTodaysReminders()
        {
            // Get today's reminders from the ProfileRecords
            DataTable remindersTable = profileRecords.GetTodaysReminders();

            // Bind the DataTable to the RemindersTable DataGridView
            RemindersTable.DataSource = remindersTable;

            // Format the DataGridView columns
            RemindersTable.Columns["TaskTitle"].HeaderText = "Task Title";
            RemindersTable.Columns["DueDate"].HeaderText = "Due Date";
            RemindersTable.Columns["Importance"].HeaderText = "Importance";
            RemindersTable.Columns["Status"].HeaderText = "Status";

            RemindersTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Update the label with the count of today's reminders
            int reminderCount = remindersTable.Rows.Count;
            Remindercountmassage.Text = $"You have {reminderCount} reminders today.";
        }

        private void ProfileNav_Click(object sender, EventArgs e)
        {
           
                Profile Object = new Profile(_userID,_connectionString);
                Object.Show();
                this.Close();
            

        }

        private void RemindersNav_Click(object sender, EventArgs e)
        {

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

        private void AllTasksPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void rəddolburdangetbuttonu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemindersTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            RemindersTable.DefaultCellStyle.Font = new Font("Century Gothic", 12);
            RemindersTable.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            if (RemindersTable.Columns[e.ColumnIndex].Name == "Importance" && e.RowIndex >= 0)

            {
                // Ensure the value in the cell is not null
                var importanceValue = RemindersTable.Rows[e.RowIndex].Cells["Importance"].Value;

                if (importanceValue != null)
                {
                    string importance = importanceValue.ToString(); // Convert it to string

                    // Set the row color based on the Importance level
                    if (importance == "Low")
                    {
                        RemindersTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#dcdcdc");  // Hex for Grey
                    }
                    else if (importance == "Medium")
                    {
                        RemindersTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#CA9C47");
                    }
                    else if (importance == "High")
                    {
                        RemindersTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#CB4752");
                    }
                    else
                    {
                        RemindersTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;  // Default color if no match
                    }
                }
                else
                {
                    // Handle null values gracefully by setting a default background color or any other action
                    RemindersTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;  // Set a neutral color if null
                }
            }
        }
    }
}
