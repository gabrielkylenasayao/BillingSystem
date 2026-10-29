using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BillingSystem.Database;

namespace BillingSystem
{
    public partial class frmChangePassword : Form
    {
        private string loggedInUsername;

        // Constructor accepting the logged-in username
        public frmChangePassword(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string currentPass = txtCurrentPassword.Text.Trim();
            string newPass = txtNewPassword.Text.Trim();
            string retypePass = txtRetypePassword.Text.Trim();

            // 1. Verify Current Password against Database
            if (!VerifyCurrentPassword(currentPass))
            {
                MessageBox.Show("Current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Check Password Match
            if (newPass != retypePass)
            {
                MessageBox.Show("New Password and Retype Password do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Complexity Validations (Items 53-57)
            if (newPass.Length < 8)
            {
                MessageBox.Show("New Password must be at least 8 characters long.", "Complexity Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(newPass, @"[A-Z]"))
            {
                MessageBox.Show("New Password must contain at least one uppercase letter.", "Complexity Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(newPass, @"[a-z]"))
            {
                MessageBox.Show("New Password must contain at least one lowercase letter.", "Complexity Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(newPass, @"[0-9]"))
            {
                MessageBox.Show("New Password must contain at least one numeric digit.", "Complexity Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(newPass, @"[!@#\$%^&*(),.?\""{}|<>]"))
            {
                MessageBox.Show("New Password must contain at least one special character.", "Complexity Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Update Database Password using Parameterized Query
            UpdatePasswordInDatabase(newPass);
        }

        private bool VerifyCurrentPassword(string inputPassword)
        {
            bool isValid = false;
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Password FROM Users WHERE Username = @Username";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", loggedInUsername);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result.ToString() == inputPassword)
                        {
                            isValid = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return isValid;
        }

        private void UpdatePasswordInDatabase(string newPassword)
        {
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Users SET Password = @NewPassword WHERE Username = @Username";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewPassword", newPassword);
                        cmd.Parameters.AddWithValue("@Username", loggedInUsername);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating password: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}