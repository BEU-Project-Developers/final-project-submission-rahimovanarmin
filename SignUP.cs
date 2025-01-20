using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        private bool IsPasswordStrong(string password)
        {
            if (password.Length < 8) return false; // Minimum length requirement
            if (!password.Any(char.IsUpper)) return false; // At least one uppercase letter
            if (!password.Any(char.IsLower)) return false; // At least one lowercase letter
            if (!password.Any(char.IsDigit)) return false; // At least one digit
            if (!password.Any(ch => "!@#$%^&*()_+-=[]{}|;:'\",.<>?/".Contains(ch))) return false; // At least one special character

            return true;
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

            if (!IsPasswordStrong(password))
            {
                MessageBox.Show("Password must be at least 8 characters long and include uppercase, lowercase, a number, and a special character.");
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

                // Hash the password before storing it
                string hashedPassword = SecurityHelper.HashPassword(password);

                // Insert the user data with the hashed password
                string insertQuery = "INSERT INTO Userss (Email, Password) VALUES (@Email, @Password)";
                var insertParams = new Dictionary<string, object>
        {
            { "@Email", email },
            { "@Password", hashedPassword }
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
