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
        private bool IsPasswordStrong(string password)
        {
            if (password.Length < 8) return false; // Minimum length requirement
            if (!password.Any(char.IsUpper)) return false; // At least one uppercase letter
            if (!password.Any(char.IsLower)) return false; // At least one lowercase letter
            if (!password.Any(char.IsDigit)) return false; // At least one digit
            if (!password.Any(ch => "!@#$%^&*()_+-=[]{}|;:'\",.<>?/".Contains(ch))) return false; // At least one special character

            return true;
        }


        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string email = EmailInput.Text.Trim(); // Trim to remove leading/trailing spaces
            string password = PasswordInput.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            try
            {
                // Hash the input password
                string hashedInputPassword = SecurityHelper.HashPassword(password);
                MessageBox.Show("Hashed Input Password: " + hashedInputPassword); // Debugging the input password hash

                // Prepare the query to retrieve the stored hashed password
                string query = "SELECT UserId, Password FROM Userss WHERE LOWER(Email) = LOWER(@Email)";
                var parameters = new Dictionary<string, object>
        {
            { "@Email", email }
        };

                // Create a TaskRecords instance to execute the query
                TaskRecords db = new TaskRecords();
                DataTable result = db.GetData(query, parameters);

                // Check if the user exists
                if (result.Rows.Count == 1)
                {
                    // Extract the stored hashed password from the database
                    string storedHashedPassword = result.Rows[0]["Password"].ToString();
                    //MessageBox.Show("Stored Hashed Password: " + storedHashedPassword); // Debugging the stored hash

                    // Compare the hashes
                    if (hashedInputPassword == storedHashedPassword)
                    {
                        int userId = Convert.ToInt32(result.Rows[0]["UserId"]);

                        // Login successful, open the next form
                        All_Tasks tasksPage = new All_Tasks(userId);
                        tasksPage.Show();

                        // Close the current form
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password.");
                    }
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
