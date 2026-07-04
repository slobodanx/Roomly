namespace Roomly.UI
{
    partial class ucGuests
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox2 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtDocNum = new TextBox();
            label8 = new Label();
            label6 = new Label();
            txtDocType = new TextBox();
            label9 = new Label();
            label10 = new Label();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtCountry = new TextBox();
            txtCity = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpBirthDate = new DateTimePicker();
            label7 = new Label();
            errProvider = new ErrorProvider(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            txtSearch = new TextBox();
            dgvGuests = new DataGridView();
            pnlDetails = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnNew = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            groupBox4 = new GroupBox();
            txtDescription = new TextBox();
            btnAssign = new Button();
            groupBox2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuests).BeginInit();
            pnlDetails.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel3);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = Color.DarkSlateGray;
            groupBox2.Location = new Point(0, 199);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(314, 180);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Details";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel3.Controls.Add(txtEmail, 1, 3);
            tableLayoutPanel3.Controls.Add(txtPhone, 1, 2);
            tableLayoutPanel3.Controls.Add(txtDocNum, 1, 1);
            tableLayoutPanel3.Controls.Add(label8, 0, 1);
            tableLayoutPanel3.Controls.Add(label6, 0, 0);
            tableLayoutPanel3.Controls.Add(txtDocType, 1, 0);
            tableLayoutPanel3.Controls.Add(label9, 0, 2);
            tableLayoutPanel3.Controls.Add(label10, 0, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 23);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(308, 154);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(126, 117);
            txtEmail.Margin = new Padding(3, 3, 22, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(160, 27);
            txtEmail.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Location = new Point(126, 79);
            txtPhone.Margin = new Padding(3, 3, 22, 3);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(160, 27);
            txtPhone.TabIndex = 9;
            txtPhone.TextChanged += ClearError_Event;
            // 
            // txtDocNum
            // 
            txtDocNum.Dock = DockStyle.Fill;
            txtDocNum.Location = new Point(126, 41);
            txtDocNum.Margin = new Padding(3, 3, 22, 3);
            txtDocNum.Name = "txtDocNum";
            txtDocNum.Size = new Size(160, 27);
            txtDocNum.TabIndex = 8;
            txtDocNum.TextChanged += ClearError_Event;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(3, 47);
            label8.Name = "label8";
            label8.Size = new Size(102, 20);
            label8.TabIndex = 5;
            label8.Text = "Doc. Number";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 9);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 0;
            label6.Text = "Doc. Type";
            // 
            // txtDocType
            // 
            txtDocType.Dock = DockStyle.Fill;
            txtDocType.Location = new Point(126, 3);
            txtDocType.Margin = new Padding(3, 3, 22, 3);
            txtDocType.Name = "txtDocType";
            txtDocType.Size = new Size(160, 27);
            txtDocType.TabIndex = 4;
            txtDocType.TextChanged += ClearError_Event;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(3, 85);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 6;
            label9.Text = "Phone";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(3, 124);
            label10.Name = "label10";
            label10.Size = new Size(47, 20);
            label10.TabIndex = 7;
            label10.Text = "Email";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = Color.DarkSlateGray;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 199);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Basic Information";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.Controls.Add(txtCountry, 1, 4);
            tableLayoutPanel2.Controls.Add(txtCity, 1, 3);
            tableLayoutPanel2.Controls.Add(txtLastName, 1, 1);
            tableLayoutPanel2.Controls.Add(txtFirstName, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 2);
            tableLayoutPanel2.Controls.Add(label5, 0, 3);
            tableLayoutPanel2.Controls.Add(dtpBirthDate, 1, 2);
            tableLayoutPanel2.Controls.Add(label7, 0, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 23);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(308, 173);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // txtCountry
            // 
            txtCountry.Dock = DockStyle.Fill;
            txtCountry.Location = new Point(126, 139);
            txtCountry.Margin = new Padding(3, 3, 22, 3);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(160, 27);
            txtCountry.TabIndex = 8;
            // 
            // txtCity
            // 
            txtCity.Dock = DockStyle.Fill;
            txtCity.Location = new Point(126, 105);
            txtCity.Margin = new Padding(3, 3, 22, 3);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(160, 27);
            txtCity.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Dock = DockStyle.Fill;
            txtLastName.Location = new Point(126, 37);
            txtLastName.Margin = new Padding(3, 3, 22, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(160, 27);
            txtLastName.TabIndex = 4;
            txtLastName.TextChanged += ClearError_Event;
            // 
            // txtFirstName
            // 
            txtFirstName.Dock = DockStyle.Fill;
            txtFirstName.Location = new Point(126, 3);
            txtFirstName.Margin = new Padding(3, 3, 22, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(160, 27);
            txtFirstName.TabIndex = 0;
            txtFirstName.TextChanged += ClearError_Event;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 7);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 0;
            label2.Text = "First Name";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 41);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 1;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 75);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 2;
            label4.Text = "Birth Date";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 109);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 3;
            label5.Text = "City";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CustomFormat = "dd.MM.yyyy";
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(126, 71);
            dtpBirthDate.MaxDate = new DateTime(2099, 1, 1, 0, 0, 0, 0);
            dtpBirthDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(160, 27);
            dtpBirthDate.TabIndex = 5;
            dtpBirthDate.Value = new DateTime(2026, 7, 1, 23, 0, 34, 0);
            dtpBirthDate.ValueChanged += ClearError_Event;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 144);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 6;
            label7.Text = "Country";
            // 
            // errProvider
            // 
            errProvider.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvGuests, 0, 1);
            tableLayoutPanel1.Controls.Add(pnlDetails, 1, 1);
            tableLayoutPanel1.Controls.Add(btnAssign, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 600);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(txtSearch);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(474, 45);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(3, 10);
            label1.Margin = new Padding(3, 10, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 30);
            label1.TabIndex = 0;
            label1.Text = "Search by Phone/Name:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(211, 10);
            txtSearch.Margin = new Padding(3, 10, 3, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvGuests
            // 
            dgvGuests.AllowUserToAddRows = false;
            dgvGuests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGuests.BackgroundColor = Color.GhostWhite;
            dgvGuests.BorderStyle = BorderStyle.None;
            dgvGuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGuests.Dock = DockStyle.Fill;
            dgvGuests.Location = new Point(3, 54);
            dgvGuests.MultiSelect = false;
            dgvGuests.Name = "dgvGuests";
            dgvGuests.ReadOnly = true;
            dgvGuests.RowHeadersVisible = false;
            dgvGuests.RowHeadersWidth = 51;
            dgvGuests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGuests.Size = new Size(474, 543);
            dgvGuests.TabIndex = 1;
            dgvGuests.DataBindingComplete += dgvGuests_DataBindingComplete;
            dgvGuests.SelectionChanged += dgvGuests_SelectionChanged;
            // 
            // pnlDetails
            // 
            pnlDetails.AutoScroll = true;
            pnlDetails.Controls.Add(flowLayoutPanel2);
            pnlDetails.Controls.Add(groupBox4);
            pnlDetails.Controls.Add(groupBox2);
            pnlDetails.Controls.Add(groupBox1);
            pnlDetails.Dock = DockStyle.Fill;
            pnlDetails.Location = new Point(483, 54);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(314, 543);
            pnlDetails.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnNew);
            flowLayoutPanel2.Controls.Add(btnDelete);
            flowLayoutPanel2.Controls.Add(btnSave);
            flowLayoutPanel2.Dock = DockStyle.Bottom;
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(0, 489);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(314, 54);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Right;
            btnNew.BackColor = Color.DarkSlateGray;
            btnNew.FlatAppearance.BorderColor = Color.DarkSlateGray;
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatAppearance.MouseDownBackColor = Color.CadetBlue;
            btnNew.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(217, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 35);
            btnNew.TabIndex = 15;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Right;
            btnDelete.BackColor = Color.DarkSlateGray;
            btnDelete.Enabled = false;
            btnDelete.FlatAppearance.BorderColor = Color.DarkSlateGray;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.CadetBlue;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(117, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 35);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Right;
            btnSave.BackColor = Color.DarkSlateGray;
            btnSave.FlatAppearance.BorderColor = Color.DarkSlateGray;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.CadetBlue;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(17, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 35);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtDescription);
            groupBox4.Dock = DockStyle.Top;
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox4.ForeColor = Color.DarkSlateGray;
            groupBox4.Location = new Point(0, 379);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(314, 90);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Additional Info";
            // 
            // txtDescription
            // 
            txtDescription.Dock = DockStyle.Top;
            txtDescription.Location = new Point(3, 23);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(308, 60);
            txtDescription.TabIndex = 12;
            // 
            // btnAssign
            // 
            btnAssign.Anchor = AnchorStyles.None;
            btnAssign.BackColor = Color.DarkSlateGray;
            btnAssign.FlatAppearance.BorderColor = Color.DarkSlateGray;
            btnAssign.FlatAppearance.BorderSize = 0;
            btnAssign.FlatAppearance.MouseDownBackColor = Color.CadetBlue;
            btnAssign.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAssign.ForeColor = Color.White;
            btnAssign.Location = new Point(565, 5);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(150, 40);
            btnAssign.TabIndex = 14;
            btnAssign.Text = "ASSIGN";
            btnAssign.UseVisualStyleBackColor = false;
            btnAssign.Visible = false;
            btnAssign.Click += btnAssign_Click;
            // 
            // ucGuests
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ucGuests";
            Size = new Size(800, 600);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuests).EndInit();
            pnlDetails.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label6;
        private TextBox txtDocType;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtFirstName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ErrorProvider errProvider;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox txtSearch;
        private DataGridView dgvGuests;
        private Panel pnlDetails;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnNew;
        private Button btnDelete;
        private Button btnSave;
        private GroupBox groupBox4;
        private TextBox txtDescription;
        private TextBox txtLastName;
        private DateTimePicker dtpBirthDate;
        private Label label7;
        private TextBox txtCountry;
        private TextBox txtCity;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtDocNum;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnAssign;
    }
}
