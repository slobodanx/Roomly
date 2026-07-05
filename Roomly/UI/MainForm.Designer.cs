namespace Roomly.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pnlContent = new Panel();
            pnl_header = new FlowLayoutPanel();
            label1 = new Label();
            pnl_footer = new FlowLayoutPanel();
            btn_logout = new Button();
            pnl_sidebar = new FlowLayoutPanel();
            txt_dashboard = new Button();
            txt_reservations = new Button();
            btn_rooms = new Button();
            txt_guests = new Button();
            pnl_container = new Panel();
            btnAdminMenu = new Button();
            pnlContent.SuspendLayout();
            pnl_header.SuspendLayout();
            pnl_footer.SuspendLayout();
            pnl_sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.DarkSlateGray;
            pnlContent.Controls.Add(pnl_header);
            pnlContent.Controls.Add(pnl_footer);
            pnlContent.Controls.Add(pnl_sidebar);
            pnlContent.Dock = DockStyle.Left;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Margin = new Padding(3, 4, 3, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(11, 13, 11, 13);
            pnlContent.Size = new Size(229, 632);
            pnlContent.TabIndex = 0;
            // 
            // pnl_header
            // 
            pnl_header.Controls.Add(label1);
            pnl_header.Dock = DockStyle.Top;
            pnl_header.FlowDirection = FlowDirection.TopDown;
            pnl_header.Location = new Point(11, 13);
            pnl_header.Margin = new Padding(3, 4, 3, 4);
            pnl_header.Name = "pnl_header";
            pnl_header.Padding = new Padding(38, 20, 0, 0);
            pnl_header.Size = new Size(207, 85);
            pnl_header.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(41, 20);
            label1.Name = "label1";
            label1.Size = new Size(129, 37);
            label1.TabIndex = 5;
            label1.Text = "ROOMLY";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnl_footer
            // 
            pnl_footer.Controls.Add(btn_logout);
            pnl_footer.Dock = DockStyle.Bottom;
            pnl_footer.FlowDirection = FlowDirection.BottomUp;
            pnl_footer.Location = new Point(11, 527);
            pnl_footer.Margin = new Padding(3, 4, 3, 4);
            pnl_footer.Name = "pnl_footer";
            pnl_footer.Size = new Size(207, 92);
            pnl_footer.TabIndex = 1;
            // 
            // btn_logout
            // 
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatAppearance.MouseDownBackColor = Color.CadetBlue;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(3, 35);
            btn_logout.Margin = new Padding(3, 4, 3, 4);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(201, 53);
            btn_logout.TabIndex = 4;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // pnl_sidebar
            // 
            pnl_sidebar.Controls.Add(txt_dashboard);
            pnl_sidebar.Controls.Add(txt_reservations);
            pnl_sidebar.Controls.Add(btn_rooms);
            pnl_sidebar.Controls.Add(txt_guests);
            pnl_sidebar.Controls.Add(btnAdminMenu);
            pnl_sidebar.FlowDirection = FlowDirection.TopDown;
            pnl_sidebar.Location = new Point(11, 107);
            pnl_sidebar.Margin = new Padding(3, 4, 3, 4);
            pnl_sidebar.Name = "pnl_sidebar";
            pnl_sidebar.Padding = new Padding(0, 13, 0, 0);
            pnl_sidebar.Size = new Size(206, 412);
            pnl_sidebar.TabIndex = 0;
            pnl_sidebar.WrapContents = false;
            // 
            // txt_dashboard
            // 
            txt_dashboard.BackColor = Color.DarkSlateGray;
            txt_dashboard.FlatAppearance.BorderSize = 0;
            txt_dashboard.FlatAppearance.MouseDownBackColor = Color.CadetBlue;
            txt_dashboard.FlatStyle = FlatStyle.Flat;
            txt_dashboard.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txt_dashboard.ForeColor = Color.White;
            txt_dashboard.Location = new Point(3, 17);
            txt_dashboard.Margin = new Padding(3, 4, 3, 4);
            txt_dashboard.Name = "txt_dashboard";
            txt_dashboard.Size = new Size(201, 53);
            txt_dashboard.TabIndex = 0;
            txt_dashboard.Text = "Dashboard";
            txt_dashboard.UseVisualStyleBackColor = false;
            txt_dashboard.Click += txt_dashboard_Click;
            // 
            // txt_reservations
            // 
            txt_reservations.FlatAppearance.BorderSize = 0;
            txt_reservations.FlatAppearance.MouseDownBackColor = Color.CadetBlue;
            txt_reservations.FlatStyle = FlatStyle.Flat;
            txt_reservations.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txt_reservations.ForeColor = Color.White;
            txt_reservations.Location = new Point(3, 78);
            txt_reservations.Margin = new Padding(3, 4, 3, 4);
            txt_reservations.Name = "txt_reservations";
            txt_reservations.Size = new Size(201, 53);
            txt_reservations.TabIndex = 2;
            txt_reservations.Text = "Reservations";
            txt_reservations.UseVisualStyleBackColor = true;
            txt_reservations.Click += txt_reservations_Click;
            // 
            // btn_rooms
            // 
            btn_rooms.FlatAppearance.BorderSize = 0;
            btn_rooms.FlatAppearance.MouseDownBackColor = Color.CadetBlue;
            btn_rooms.FlatStyle = FlatStyle.Flat;
            btn_rooms.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_rooms.ForeColor = Color.White;
            btn_rooms.Location = new Point(3, 139);
            btn_rooms.Margin = new Padding(3, 4, 3, 4);
            btn_rooms.Name = "btn_rooms";
            btn_rooms.Size = new Size(201, 53);
            btn_rooms.TabIndex = 1;
            btn_rooms.Text = "Rooms";
            btn_rooms.UseVisualStyleBackColor = true;
            btn_rooms.Click += btn_rooms_Click;
            // 
            // txt_guests
            // 
            txt_guests.FlatAppearance.BorderSize = 0;
            txt_guests.FlatAppearance.MouseDownBackColor = Color.CadetBlue;
            txt_guests.FlatStyle = FlatStyle.Flat;
            txt_guests.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txt_guests.ForeColor = Color.White;
            txt_guests.Location = new Point(3, 200);
            txt_guests.Margin = new Padding(3, 4, 3, 4);
            txt_guests.Name = "txt_guests";
            txt_guests.Size = new Size(201, 53);
            txt_guests.TabIndex = 3;
            txt_guests.Text = "Guests";
            txt_guests.UseVisualStyleBackColor = true;
            txt_guests.Click += txt_guests_Click;
            // 
            // pnl_container
            // 
            pnl_container.Dock = DockStyle.Fill;
            pnl_container.Location = new Point(229, 0);
            pnl_container.Name = "pnl_container";
            pnl_container.Size = new Size(894, 632);
            pnl_container.TabIndex = 1;
            // 
            // btnAdminMenu
            // 
            btnAdminMenu.FlatAppearance.BorderSize = 0;
            btnAdminMenu.FlatAppearance.MouseDownBackColor = Color.CadetBlue;
            btnAdminMenu.FlatStyle = FlatStyle.Flat;
            btnAdminMenu.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAdminMenu.ForeColor = Color.White;
            btnAdminMenu.Location = new Point(3, 261);
            btnAdminMenu.Margin = new Padding(3, 4, 3, 4);
            btnAdminMenu.Name = "btnAdminMenu";
            btnAdminMenu.Size = new Size(201, 53);
            btnAdminMenu.TabIndex = 4;
            btnAdminMenu.Text = "Admin Dashboard";
            btnAdminMenu.UseVisualStyleBackColor = true;
            btnAdminMenu.Click += btnAdminMenu_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 632);
            Controls.Add(pnl_container);
            Controls.Add(pnlContent);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel Reservation and Management System";
            pnlContent.ResumeLayout(false);
            pnl_header.ResumeLayout(false);
            pnl_header.PerformLayout();
            pnl_footer.ResumeLayout(false);
            pnl_sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContent;
        private FlowLayoutPanel pnl_sidebar;
        private Button txt_dashboard;
        private Button btn_rooms;
        private Button txt_reservations;
        private Button txt_guests;
        private Button btn_logout;
        private FlowLayoutPanel pnl_footer;
        private FlowLayoutPanel pnl_header;
        private Label label1;
        private Panel pnl_container;
        private Button btnAdminMenu;
    }
}