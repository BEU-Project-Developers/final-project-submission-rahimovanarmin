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
            PasswordInput.PasswordChar = '•';
        }
        

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

            string email = EmailInput.Text; // Updated for email
            string password = PasswordInput.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            try
            {
                TaskRecords db = new TaskRecords();
                string query = "SELECT UserId FROM Userss WHERE Email = @Email AND Password = @Password";
                var parameters = new Dictionary<string, object>
        {
            { "@Email", email },
            { "@Password", password }
        };

                DataTable result = db.GetData(query, parameters);

                if (result.Rows.Count == 1)
                {
                    int userId = Convert.ToInt32(result.Rows[0]["UserId"]);

                    
                    All_Tasks tasksPage = new All_Tasks(userId);
                    tasksPage.Show();

                   
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid email or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void EscapeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void questiontoSignup_Click(object sender, EventArgs e)
        {
            
            
            SignUP signup = new SignUP();
            signup.Show();
            this.Close();

        }
    }
}
