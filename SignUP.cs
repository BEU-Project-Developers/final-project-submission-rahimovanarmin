using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace TaskSchudler
{
    public partial class SignUP : Form
    {
        public SignUP()
        {
            InitializeComponent();
            PasswordInput.PasswordChar = '•';
        }

        private void questiontoLogin_Click(object sender, EventArgs e)
        {
            
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide(); 
        }

        private void SignUpButton_Click_1(object sender, EventArgs e)
        {
            string email = EmailInput.Text;
            string password = PasswordInput.Text;

            // Validation checks
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!email.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            try
            {
                TaskRecords db = new TaskRecords();

                // Check if email already exists
                string checkQuery = "SELECT COUNT(*) FROM Userss WHERE Email = @Email";
                var checkParams = new Dictionary<string, object>
                {
                    { "@Email", email }
                };

                DataTable result = db.GetData(checkQuery, checkParams);
                int emailCount = Convert.ToInt32(result.Rows[0][0]);

                if (emailCount > 0)
                {
                    MessageBox.Show("You already have an account. Please log in.");
                    return;
                }

          
                string insertQuery = "INSERT INTO Userss (Email, Password) VALUES (@Email, @Password)";
                var insertParams = new Dictionary<string, object>
                {
                    { "@Email", email },
                    { "@Password", password }
                };

                int rowsAffected = db.SetData(insertQuery, insertParams);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Signup successful! Redirecting to login...");
                    Login loginForm = new Login();
                    loginForm.Show();
                    this.Hide(); 
                }
                else
                {
                    MessageBox.Show("Signup failed. Please try again.");
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
    }
}
