using Roomly.Services;
using Roomly.UI;

namespace Roomly
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                var userService = new UserService();
                var loggedInUser = userService.Authenticate(txt_username.Text, txt_password.Text);

                if (loggedInUser != null)
                {
                    // Success: Navigate to next form
                    var main_form = new MainForm(loggedInUser);
                    main_form.Show();
                    this.Hide();
                }
                else
                {
                    // Failure: Show error
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("btn_login_Click", ex);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            try
            {
                txt_username.Text = "";
                txt_password.Text = "";
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                throw new Exception("pictureBox2_Click", ex);
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    // Trigger your existing login method
                    btn_login_Click(sender, e);

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
