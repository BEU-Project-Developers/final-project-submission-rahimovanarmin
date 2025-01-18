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
    public partial class Reminders : Form
    {
        public Reminders()
        {
            InitializeComponent();
        }

        private void ProfileNav_Click(object sender, EventArgs e)
        {
           
                Profile Object = new Profile();
                Object.Show();
                this.Close();
            

        }

        private void RemindersNav_Click(object sender, EventArgs e)
        {

        }

        private void AllTasksNav_Click(object sender, EventArgs e)
        {
           // All_Tasks Obj = new All_Tasks();
            //Obj.Show();
            //this.Close();
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

        private void Reminders_Load(object sender, EventArgs e)
        {

        }

        private void rəddolburdangetbuttonu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
