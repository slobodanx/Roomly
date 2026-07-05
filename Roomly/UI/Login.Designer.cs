namespace Roomly
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            ll_copyright = new LinkLabel();
            lbl_error = new Label();
            btn_signup = new Button();
            btn_login = new Button();
            label6 = new Label();
            label5 = new Label();
            txt_password = new TextBox();
            txt_username = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(ll_copyright);
            panel1.Controls.Add(lbl_error);
            panel1.Controls.Add(btn_signup);
            panel1.Controls.Add(btn_login);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txt_password);
            panel1.Controls.Add(txt_username);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(389, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 528);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(337, 16);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // ll_copyright
            // 
            ll_copyright.AutoSize = true;
            ll_copyright.Location = new Point(149, 496);
            ll_copyright.Name = "ll_copyright";
            ll_copyright.Size = new Size(87, 20);
            ll_copyright.TabIndex = 5;
            ll_copyright.TabStop = true;
            ll_copyright.Text = "COPYRIGHT";
            ll_copyright.LinkClicked += ll_copyright_LinkClicked;
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_error.ForeColor = Color.Red;
            lbl_error.Location = new Point(49, 107);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(0, 23);
            lbl_error.TabIndex = 7;
            // 
            // btn_signup
            // 
            btn_signup.BackColor = Color.White;
            btn_signup.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_signup.ForeColor = Color.DarkSlateGray;
            btn_signup.Location = new Point(90, 373);
            btn_signup.Margin = new Padding(3, 4, 3, 4);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(197, 44);
            btn_signup.TabIndex = 4;
            btn_signup.Text = "SIGN UP";
            btn_signup.UseVisualStyleBackColor = false;
            btn_signup.Click += btn_signup_Click;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.DarkSlateGray;
            btn_login.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(90, 315);
            btn_login.Margin = new Padding(3, 4, 3, 4);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(197, 44);
            btn_login.TabIndex = 3;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(95, 212);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 4;
            label6.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(95, 143);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 3;
            label5.Text = "Username";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(90, 236);
            txt_password.Margin = new Padding(3, 4, 3, 4);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(196, 27);
            txt_password.TabIndex = 2;
            txt_password.UseSystemPasswordChar = true;
            txt_password.KeyDown += txt_password_KeyDown;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(90, 167);
            txt_username.Margin = new Padding(3, 4, 3, 4);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(196, 27);
            txt_username.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(38, 48);
            label4.Name = "label4";
            label4.Size = new Size(325, 41);
            label4.TabIndex = 0;
            label4.Text = "Login to your account";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(115, 92);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 181);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(67, 297);
            label1.Name = "label1";
            label1.Size = new Size(248, 58);
            label1.TabIndex = 2;
            label1.Text = "ROOMLY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 373);
            label2.Name = "label2";
            label2.Size = new Size(344, 23);
            label2.TabIndex = 3;
            label2.Text = "Hotel Reservation and Management System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(143, 496);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 4;
            label3.Text = "FCSE 2026";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(760, 528);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_login;
        private Label label6;
        private Label label5;
        private TextBox txt_password;
        private TextBox txt_username;
        private Button btn_signup;
        private Label lbl_error;
        private LinkLabel ll_copyright;
        private PictureBox pictureBox2;
    }
}
