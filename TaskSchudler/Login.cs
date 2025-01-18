using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TaskSchudler
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-LIJ1K35\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
          
                All_Tasks all_Tasks = new All_Tasks();
                all_Tasks.Show();
                this.Hide();
            
            
        }

        private void EscapeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
