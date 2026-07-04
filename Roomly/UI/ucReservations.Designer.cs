namespace Roomly.UI
{
    partial class ucReservations
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
            numChildren = new NumericUpDown();
            numAdults = new NumericUpDown();
            label10 = new Label();
            dtpCheckOut = new DateTimePicker();
            dtpCheckIn = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label11 = new Label();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtRoomNumber = new TextBox();
            txtGuestName = new TextBox();
            btnSelectGuest = new Button();
            btnSelectRoom = new Button();
            errProvider = new ErrorProvider(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            txtSearch = new TextBox();
            dgvReservations = new DataGridView();
            pnlDetails = new Panel();
            groupBox5 = new GroupBox();
            txtDescription = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnNew = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            groupBox4 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            txtFinalPrice = new TextBox();
            txtBasePrice = new TextBox();
            cmbStatus = new ComboBox();
            label6 = new Label();
            cmbDiscountType = new ComboBox();
            label8 = new Label();
            numDiscountValue = new NumericUpDown();
            label9 = new Label();
            groupBox2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numChildren).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAdults).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            pnlDetails.SuspendLayout();
            groupBox5.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDiscountValue).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel3);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = Color.DarkSlateGray;
            groupBox2.Location = new Point(0, 93);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(314, 163);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Booking Details";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(numChildren, 1, 3);
            tableLayoutPanel3.Controls.Add(numAdults, 1, 2);
            tableLayoutPanel3.Controls.Add(label10, 0, 2);
            tableLayoutPanel3.Controls.Add(dtpCheckOut, 1, 1);
            tableLayoutPanel3.Controls.Add(dtpCheckIn, 1, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(label3, 0, 1);
            tableLayoutPanel3.Controls.Add(label11, 0, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 23);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(308, 137);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // numChildren
            // 
            numChildren.Dock = DockStyle.Fill;
            numChildren.Location = new Point(157, 105);
            numChildren.Name = "numChildren";
            numChildren.Size = new Size(148, 27);
            numChildren.TabIndex = 11;
            // 
            // numAdults
            // 
            numAdults.Dock = DockStyle.Fill;
            numAdults.Location = new Point(157, 71);
            numAdults.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAdults.Name = "numAdults";
            numAdults.Size = new Size(148, 27);
            numAdults.TabIndex = 10;
            numAdults.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(3, 75);
            label10.Name = "label10";
            label10.Size = new Size(55, 20);
            label10.TabIndex = 8;
            label10.Text = "Adults";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.CustomFormat = "dd.MM.yyyy";
            dtpCheckOut.Format = DateTimePickerFormat.Custom;
            dtpCheckOut.Location = new Point(157, 37);
            dtpCheckOut.MaxDate = new DateTime(2099, 1, 1, 0, 0, 0, 0);
            dtpCheckOut.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(148, 27);
            dtpCheckOut.TabIndex = 7;
            dtpCheckOut.Value = new DateTime(2026, 7, 1, 23, 0, 34, 0);
            dtpCheckOut.ValueChanged += CalculatePrice;
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.CustomFormat = "dd.MM.yyyy";
            dtpCheckIn.Format = DateTimePickerFormat.Custom;
            dtpCheckIn.Location = new Point(157, 3);
            dtpCheckIn.MaxDate = new DateTime(2099, 1, 1, 0, 0, 0, 0);
            dtpCheckIn.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(148, 27);
            dtpCheckIn.TabIndex = 6;
            dtpCheckIn.Value = new DateTime(2026, 7, 1, 23, 0, 34, 0);
            dtpCheckIn.ValueChanged += CalculatePrice;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 7);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Check In";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 41);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 2;
            label3.Text = "Check Out";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Location = new Point(3, 109);
            label11.Name = "label11";
            label11.Size = new Size(71, 20);
            label11.TabIndex = 9;
            label11.Text = "Children ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = Color.DarkSlateGray;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 93);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Guest and Room Selection";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.Controls.Add(txtRoomNumber, 0, 1);
            tableLayoutPanel2.Controls.Add(txtGuestName, 0, 0);
            tableLayoutPanel2.Controls.Add(btnSelectGuest, 1, 0);
            tableLayoutPanel2.Controls.Add(btnSelectRoom, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 23);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(308, 67);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Dock = DockStyle.Fill;
            txtRoomNumber.Location = new Point(3, 36);
            txtRoomNumber.Margin = new Padding(3, 3, 22, 3);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.ReadOnly = true;
            txtRoomNumber.Size = new Size(159, 27);
            txtRoomNumber.TabIndex = 2;
            txtRoomNumber.TextChanged += CalculatePrice;
            // 
            // txtGuestName
            // 
            txtGuestName.Dock = DockStyle.Fill;
            txtGuestName.Location = new Point(3, 3);
            txtGuestName.Margin = new Padding(3, 3, 22, 3);
            txtGuestName.Name = "txtGuestName";
            txtGuestName.ReadOnly = true;
            txtGuestName.Size = new Size(159, 27);
            txtGuestName.TabIndex = 1;
            // 
            // btnSelectGuest
            // 
            btnSelectGuest.BackColor = Color.DarkSlateGray;
            btnSelectGuest.ForeColor = Color.White;
            btnSelectGuest.Location = new Point(187, 3);
            btnSelectGuest.Name = "btnSelectGuest";
            btnSelectGuest.Size = new Size(118, 27);
            btnSelectGuest.TabIndex = 3;
            btnSelectGuest.Text = "Search Guest";
            btnSelectGuest.UseVisualStyleBackColor = false;
            btnSelectGuest.Click += btnSelectGuest_Click;
            // 
            // btnSelectRoom
            // 
            btnSelectRoom.BackColor = Color.DarkSlateGray;
            btnSelectRoom.ForeColor = Color.White;
            btnSelectRoom.Location = new Point(187, 36);
            btnSelectRoom.Name = "btnSelectRoom";
            btnSelectRoom.Size = new Size(118, 28);
            btnSelectRoom.TabIndex = 4;
            btnSelectRoom.Text = "Search Room";
            btnSelectRoom.UseVisualStyleBackColor = false;
            btnSelectRoom.Click += btnSelectRoom_Click;
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
            tableLayoutPanel1.Controls.Add(dgvReservations, 0, 1);
            tableLayoutPanel1.Controls.Add(pnlDetails, 1, 1);
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
            label1.Size = new Size(198, 30);
            label1.TabIndex = 0;
            label1.Text = "Search by Room/Guest:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(207, 10);
            txtSearch.Margin = new Padding(3, 10, 3, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvReservations
            // 
            dgvReservations.AllowUserToAddRows = false;
            dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservations.BackgroundColor = Color.GhostWhite;
            dgvReservations.BorderStyle = BorderStyle.None;
            dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservations.Dock = DockStyle.Fill;
            dgvReservations.Location = new Point(3, 54);
            dgvReservations.MultiSelect = false;
            dgvReservations.Name = "dgvReservations";
            dgvReservations.ReadOnly = true;
            dgvReservations.RowHeadersVisible = false;
            dgvReservations.RowHeadersWidth = 51;
            dgvReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservations.Size = new Size(474, 543);
            dgvReservations.TabIndex = 1;
            dgvReservations.DataBindingComplete += dgvReservations_DataBindingComplete;
            dgvReservations.SelectionChanged += dgvReservations_SelectionChanged;
            // 
            // pnlDetails
            // 
            pnlDetails.AutoScroll = true;
            pnlDetails.Controls.Add(groupBox5);
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
            // groupBox5
            // 
            groupBox5.Controls.Add(txtDescription);
            groupBox5.Dock = DockStyle.Top;
            groupBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox5.ForeColor = Color.DarkSlateGray;
            groupBox5.Location = new Point(0, 418);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(314, 65);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Additional Info";
            // 
            // txtDescription
            // 
            txtDescription.Dock = DockStyle.Top;
            txtDescription.Location = new Point(3, 23);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(308, 40);
            txtDescription.TabIndex = 12;
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
            groupBox4.Controls.Add(tableLayoutPanel5);
            groupBox4.Dock = DockStyle.Top;
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox4.ForeColor = Color.DarkSlateGray;
            groupBox4.Location = new Point(0, 256);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(314, 162);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Financial & Status";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(txtFinalPrice, 1, 1);
            tableLayoutPanel5.Controls.Add(txtBasePrice, 0, 1);
            tableLayoutPanel5.Controls.Add(cmbStatus, 1, 0);
            tableLayoutPanel5.Controls.Add(label6, 0, 0);
            tableLayoutPanel5.Controls.Add(cmbDiscountType, 1, 2);
            tableLayoutPanel5.Controls.Add(label8, 0, 2);
            tableLayoutPanel5.Controls.Add(numDiscountValue, 1, 3);
            tableLayoutPanel5.Controls.Add(label9, 0, 3);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 23);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 4;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.Size = new Size(308, 136);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // txtFinalPrice
            // 
            txtFinalPrice.BackColor = SystemColors.Control;
            txtFinalPrice.Dock = DockStyle.Fill;
            txtFinalPrice.ForeColor = Color.DarkSlateGray;
            txtFinalPrice.Location = new Point(157, 37);
            txtFinalPrice.Name = "txtFinalPrice";
            txtFinalPrice.ReadOnly = true;
            txtFinalPrice.Size = new Size(148, 27);
            txtFinalPrice.TabIndex = 19;
            txtFinalPrice.Text = "Final Price: ";
            // 
            // txtBasePrice
            // 
            txtBasePrice.BackColor = SystemColors.Control;
            txtBasePrice.Dock = DockStyle.Fill;
            txtBasePrice.ForeColor = Color.DarkSlateGray;
            txtBasePrice.Location = new Point(3, 37);
            txtBasePrice.Name = "txtBasePrice";
            txtBasePrice.ReadOnly = true;
            txtBasePrice.Size = new Size(148, 27);
            txtBasePrice.TabIndex = 18;
            txtBasePrice.Text = "Base Price: ";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(157, 3);
            cmbStatus.Margin = new Padding(3, 3, 22, 3);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(119, 28);
            cmbStatus.TabIndex = 17;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 7);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 16;
            label6.Text = "Rsv. Status";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbDiscountType
            // 
            cmbDiscountType.FormattingEnabled = true;
            cmbDiscountType.Location = new Point(157, 71);
            cmbDiscountType.Margin = new Padding(3, 3, 22, 3);
            cmbDiscountType.Name = "cmbDiscountType";
            cmbDiscountType.Size = new Size(119, 28);
            cmbDiscountType.TabIndex = 13;
            cmbDiscountType.SelectedIndexChanged += CalculatePrice;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(3, 75);
            label8.Name = "label8";
            label8.Size = new Size(108, 20);
            label8.TabIndex = 12;
            label8.Text = "Discount Type";
            // 
            // numDiscountValue
            // 
            numDiscountValue.Dock = DockStyle.Fill;
            numDiscountValue.Location = new Point(157, 105);
            numDiscountValue.Name = "numDiscountValue";
            numDiscountValue.Size = new Size(148, 27);
            numDiscountValue.TabIndex = 11;
            numDiscountValue.ValueChanged += CalculatePrice;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(3, 109);
            label9.Name = "label9";
            label9.Size = new Size(130, 20);
            label9.TabIndex = 10;
            label9.Text = "Discount Value %";
            // 
            // ucReservations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ucReservations";
            Size = new Size(800, 600);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numChildren).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAdults).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            pnlDetails.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDiscountValue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private ErrorProvider errProvider;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox txtSearch;
        private DataGridView dgvReservations;
        private Panel pnlDetails;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnNew;
        private Button btnDelete;
        private Button btnSave;
        private GroupBox groupBox4;
        private TextBox txtRoomNumber;
        private TextBox txtGuestName;
        private Button btnSelectGuest;
        private Button btnSelectRoom;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpCheckOut;
        private DateTimePicker dtpCheckIn;
        private GroupBox groupBox5;
        private TextBox txtDescription;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label9;
        private NumericUpDown numDiscountValue;
        private ComboBox cmbDiscountType;
        private Label label8;
        private Label label6;
        private ComboBox cmbStatus;
        private NumericUpDown numChildren;
        private NumericUpDown numAdults;
        private Label label10;
        private Label label11;
        private TextBox txtBasePrice;
        private TextBox txtFinalPrice;
    }
}
