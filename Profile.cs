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
        public Profile()
        {
            InitializeComponent();
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

            //All_Tasks Obj = new All_Tasks();
            //Obj.Show();
            //this.Close();
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
    }
}
