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
        private readonly string _connectionString;
        private readonly int _currentUserId;
        private ProfileRecords profileRecords;

        public Reminders(int userID, string connectionString)
        {
            InitializeComponent();
            _currentUserId = userID;
            _connectionString = connectionString;

            
            profileRecords = new ProfileRecords(connectionString, userID);
        }

        private void Reminders_Load(object sender, EventArgs e)
        {
          
            LoadTodaysReminders();
        }

        private void LoadTodaysReminders()
        {
            
            DataTable remindersTable = profileRecords.GetTodaysReminders();

          
            RemindersTable.DataSource = remindersTable;

            
            RemindersTable.Columns["TaskTitle"].HeaderText = "Task Title";
            RemindersTable.Columns["DueDate"].HeaderText = "Due Date";
            RemindersTable.Columns["Importance"].HeaderText = "Importance";
            RemindersTable.Columns["Status"].HeaderText = "Status";

            RemindersTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

          
            int reminderCount = remindersTable.Rows.Count;
            Remindercountmassage.Text = $"You have {reminderCount} reminders today.";
        }

        private void ProfileNav_Click(object sender, EventArgs e)
        {
           
                Profile Object = new Profile(_currentUserId,_connectionString);
                Object.Show();
                this.Close();
            

        }

        private void RemindersNav_Click(object sender, EventArgs e)
        {

        }

        private void AllTasksNav_Click(object sender, EventArgs e)
        {
           All_Tasks Obj = new All_Tasks(_currentUserId);
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

            TableApperance.ApplyCellFormatting(RemindersTable, e);
        }
    }
}
