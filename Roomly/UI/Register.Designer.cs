namespace Roomly.UI
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            ll_copyright = new LinkLabel();
            lbl_error = new Label();
            btn_clear = new Button();
            btn_register = new Button();
            label6 = new Label();
            label5 = new Label();
            txt_password = new TextBox();
            txt_username = new TextBox();
            label4 = new Label();
            label1 = new Label();
            txt_confirmPassword = new TextBox();
            SuspendLayout();
            // 
            // ll_copyright
            // 
            ll_copyright.AutoSize = true;
            ll_copyright.Location = new Point(179, 535);
            ll_copyright.Name = "ll_copyright";
            ll_copyright.Size = new Size(87, 20);
            ll_copyright.TabIndex = 15;
            ll_copyright.TabStop = true;
            ll_copyright.Text = "COPYRIGHT";
            ll_copyright.LinkClicked += ll_copyright_LinkClicked;
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_error.ForeColor = Color.Red;
            lbl_error.Location = new Point(83, 93);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(0, 23);
            lbl_error.TabIndex = 16;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.White;
            btn_clear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_clear.ForeColor = Color.DarkSlateGray;
            btn_clear.Location = new Point(123, 462);
            btn_clear.Margin = new Padding(3, 4, 3, 4);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(197, 44);
            btn_clear.TabIndex = 5;
            btn_clear.Text = "CLEAR";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.DarkSlateGray;
            btn_register.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_register.ForeColor = Color.White;
            btn_register.Location = new Point(123, 404);
            btn_register.Margin = new Padding(3, 4, 3, 4);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(197, 44);
            btn_register.TabIndex = 4;
            btn_register.Text = "REGISTER";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(129, 198);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 14;
            label6.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(129, 129);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 12;
            label5.Text = "Username";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(124, 222);
            txt_password.Margin = new Padding(3, 4, 3, 4);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(196, 27);
            txt_password.TabIndex = 2;
            txt_password.UseSystemPasswordChar = true;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(124, 153);
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
            label4.Location = new Point(72, 34);
            label4.Name = "label4";
            label4.Size = new Size(324, 41);
            label4.TabIndex = 8;
            label4.Text = "Register your account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(129, 276);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 18;
            label1.Text = "Confrim password";
            // 
            // txt_confirmPassword
            // 
            txt_confirmPassword.Location = new Point(124, 300);
            txt_confirmPassword.Margin = new Padding(3, 4, 3, 4);
            txt_confirmPassword.Name = "txt_confirmPassword";
            txt_confirmPassword.Size = new Size(196, 27);
            txt_confirmPassword.TabIndex = 3;
            txt_confirmPassword.UseSystemPasswordChar = true;
            txt_confirmPassword.KeyDown += txt_confirmPassword_KeyDown;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 578);
            Controls.Add(label1);
            Controls.Add(txt_confirmPassword);
            Controls.Add(ll_copyright);
            Controls.Add(lbl_error);
            Controls.Add(btn_clear);
            Controls.Add(btn_register);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(label4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome to Roomly";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel ll_copyright;
        private Label lbl_error;
        private Button btn_clear;
        private Button btn_register;
        private Label label6;
        private Label label5;
        private TextBox txt_password;
        private TextBox txt_username;
        private Label label4;
        private Label label1;
        private TextBox txt_confirmPassword;
    }
}