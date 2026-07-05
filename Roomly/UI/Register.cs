
using Roomly.Services;

namespace Roomly.UI
{
    public partial class Register : Form
    {
        private bool _isAdmin = false;
        public Register(bool admin = false)
        {
            _isAdmin = admin;
            if (admin)
            {
                MessageBox.Show(
                "Welcome to Roomly! As this is the first time you are running the system, please set up the administrator account.",
                "First Time Setup",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            }
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            // 1. Basic validation: Ensure no fields are empty
            if (string.IsNullOrWhiteSpace(txt_username.Text) ||
                string.IsNullOrWhiteSpace(txt_password.Text) ||
                string.IsNullOrWhiteSpace(txt_confirmPassword.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validate that passwords match
            if (txt_password.Text != txt_confirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_password.Text = "";
                txt_confirmPassword.Text = "";
                txt_password.Focus();
                return;
            }

            // 3. Optional: Add complexity check (e.g., length)
            if (txt_password.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_password.Text = "";
                txt_confirmPassword.Text = "";
                txt_password.Focus();
                return;
            }

            try
            {
                // 4. Save to Database
                using (var context = new Roomly.Data.AppDbContext())
                {
                    if (_isAdmin)
                    {
                        var adminUser = new Roomly.Models.User
                        {
                            Username = txt_username.Text,
                            PasswordHash = BCrypt.Net.BCrypt.HashPassword(txt_password.Text),
                            RoleId = 1, // Assuming 1 is Admin
                            IsActive = true
                        };

                        context.Users.Add(adminUser);
                        context.SaveChanges();

                        MessageBox.Show("Administrator account created successfully! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var newUser = new Roomly.Models.User
                        {
                            Username = txt_username.Text,
                            PasswordHash = BCrypt.Net.BCrypt.HashPassword(txt_password.Text),
                            RoleId = 2, // 2 is for Staff/Receptionist
                            IsActive = false // Staff must wait for approval
                        };

                        context.Users.Add(newUser);
                        context.SaveChanges();

                        MessageBox.Show("Account created successfully! Pending for admin approval.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

                

                this.DialogResult = DialogResult.OK;
                // 5. Close the form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            try
            {
                txt_username.Text = "";
                txt_password.Text = "";
                txt_confirmPassword.Text = "";
            }
            catch (Exception ex)
            {
                throw new Exception("btn_clear_Click", ex);
            }
        }

        private void ll_copyright_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string text = "Roomly is Hotel Reservation and Management System made by\r\n";
                text += "\t1. Slobodan Spasovski (225089)\r\n";
                text += "\t2. Mario Markovski (225116)\r\n";
                text += "\t3. Monika Spasovska (186012)\r\n";
                text += "under mentorship of\r\n";
                text += "\t1. Dejan Gjorgjevic, Ph.D.\r\n";
                text += "\t2. Stefan Andonov, BSc\r\n\r\n";
                text += "This project is part of course Visual Programming in academic year 2025/2026.\r\n";
                text += "All rights reserved by FCSE.\r\n";

                MessageBox.Show(text, "COPYRIGHT");
            }
            catch (Exception ex)
            {
                throw new Exception("ll_copyright_LinkClicked", ex);
            }
        }

        private void txt_confirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    // Trigger your existing login method
                    btn_register_Click(sender, e);

                    // Optional: Suppress the "ding" sound that Windows makes on Enter
                    e.SuppressKeyPress = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("txt_password_KeyDown", ex);
            }
        }
    }
}
