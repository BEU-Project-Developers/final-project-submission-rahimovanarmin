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

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LIJ1K35\SQLEXPRESS;Initial Catalog=TaskScheduler;Integrated Security=True");
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
            String email = EmailInput.Text;
            String password = PasswordInput.Text;

            try {
                String query = "SELECT * FROM Users WHERE Email='"+EmailInput.Text+"' AND Password='"+PasswordInput.Text+"' ";
                SqlDataAdapter sda = new SqlDataAdapter(query,conn);  

                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    email = EmailInput.Text;
                    password = PasswordInput.Text;
                    All_Tasks all_Tasks = new All_Tasks();
                    all_Tasks.Show();
                    this.Hide();

                }
                else {
                    MessageBox.Show("Redd ol");
                }


            } catch {
                MessageBox.Show("Error");
            
            } finally { conn.Close(); }   
                   

        }

        private void EscapeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
