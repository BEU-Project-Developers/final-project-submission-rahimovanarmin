using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void Countofcompleted_Click(object sender, EventArgs e)
        {

        }
    }
}
