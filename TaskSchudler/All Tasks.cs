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
    public partial class All_Tasks : Form
    {
        public All_Tasks()
        {
            InitializeComponent();
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
            Profile Object = new Profile();
            Object.Show();
            this.Close();
        }

        private void EscapeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
