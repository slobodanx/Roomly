namespace Roomly.UI
{
    partial class ucRooms
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
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            txtSearch = new TextBox();
            dgvRooms = new DataGridView();
            pnlDetails = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnNew = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            groupBox4 = new GroupBox();
            txtDescription = new TextBox();
            groupBox3 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            chk_meals = new CheckBox();
            chk_wifi = new CheckBox();
            chk_towels = new CheckBox();
            chk_pets = new CheckBox();
            chk_smoking = new CheckBox();
            chk_hasFridge = new CheckBox();
            groupBox2 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label6 = new Label();
            txtPrice = new TextBox();
            chkAvailable = new CheckBox();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtRoomNumber = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbRoomType = new ComboBox();
            cmbRoomView = new ComboBox();
            numMaxOccupancy = new NumericUpDown();
            errProvider = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            pnlDetails.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMaxOccupancy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvRooms, 0, 1);
            tableLayoutPanel1.Controls.Add(pnlDetails, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 600);
            tableLayoutPanel1.TabIndex = 0;
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
            label1.Size = new Size(217, 30);
            label1.TabIndex = 0;
            label1.Text = "Search by Room Number:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(226, 10);
            txtSearch.Margin = new Padding(3, 10, 3, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvRooms
            // 
            dgvRooms.AllowUserToAddRows = false;
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRooms.BackgroundColor = Color.GhostWhite;
            dgvRooms.BorderStyle = BorderStyle.None;
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRooms.Dock = DockStyle.Fill;
            dgvRooms.Location = new Point(3, 54);
            dgvRooms.MultiSelect = false;
            dgvRooms.Name = "dgvRooms";
            dgvRooms.ReadOnly = true;
            dgvRooms.RowHeadersVisible = false;
            dgvRooms.RowHeadersWidth = 51;
            dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRooms.Size = new Size(474, 543);
            dgvRooms.TabIndex = 1;
            dgvRooms.SelectionChanged += dgvRooms_SelectionChanged;
            // 
            // pnlDetails
            // 
            pnlDetails.AutoScroll = true;
            pnlDetails.Controls.Add(flowLayoutPanel2);
            pnlDetails.Controls.Add(groupBox4);
            pnlDetails.Controls.Add(groupBox3);
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
            groupBox4.Location = new Point(0, 394);
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
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel4);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox3.ForeColor = Color.DarkSlateGray;
            groupBox3.Location = new Point(0, 269);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(314, 125);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Amenities";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(chk_meals, 1, 2);
            tableLayoutPanel4.Controls.Add(chk_wifi, 0, 2);
            tableLayoutPanel4.Controls.Add(chk_towels, 1, 1);
            tableLayoutPanel4.Controls.Add(chk_pets, 0, 1);
            tableLayoutPanel4.Controls.Add(chk_smoking, 1, 0);
            tableLayoutPanel4.Controls.Add(chk_hasFridge, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 23);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel4.Size = new Size(308, 99);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // chk_meals
            // 
            chk_meals.Anchor = AnchorStyles.Left;
            chk_meals.AutoSize = true;
            chk_meals.Location = new Point(157, 70);
            chk_meals.Name = "chk_meals";
            chk_meals.Size = new Size(72, 24);
            chk_meals.TabIndex = 11;
            chk_meals.Text = "Meals";
            chk_meals.UseVisualStyleBackColor = true;
            // 
            // chk_wifi
            // 
            chk_wifi.Anchor = AnchorStyles.Left;
            chk_wifi.AutoSize = true;
            chk_wifi.Location = new Point(3, 70);
            chk_wifi.Name = "chk_wifi";
            chk_wifi.Size = new Size(60, 24);
            chk_wifi.TabIndex = 10;
            chk_wifi.Text = "Wifi";
            chk_wifi.UseVisualStyleBackColor = true;
            // 
            // chk_towels
            // 
            chk_towels.Anchor = AnchorStyles.Left;
            chk_towels.AutoSize = true;
            chk_towels.Location = new Point(157, 37);
            chk_towels.Name = "chk_towels";
            chk_towels.Size = new Size(79, 24);
            chk_towels.TabIndex = 9;
            chk_towels.Text = "Towels";
            chk_towels.UseVisualStyleBackColor = true;
            // 
            // chk_pets
            // 
            chk_pets.Anchor = AnchorStyles.Left;
            chk_pets.AutoSize = true;
            chk_pets.Location = new Point(3, 37);
            chk_pets.Name = "chk_pets";
            chk_pets.Size = new Size(61, 24);
            chk_pets.TabIndex = 8;
            chk_pets.Text = "Pets";
            chk_pets.UseVisualStyleBackColor = true;
            // 
            // chk_smoking
            // 
            chk_smoking.Anchor = AnchorStyles.Left;
            chk_smoking.AutoSize = true;
            chk_smoking.Location = new Point(157, 4);
            chk_smoking.Name = "chk_smoking";
            chk_smoking.Size = new Size(92, 24);
            chk_smoking.TabIndex = 7;
            chk_smoking.Text = "Smoking";
            chk_smoking.UseVisualStyleBackColor = true;
            // 
            // chk_hasFridge
            // 
            chk_hasFridge.Anchor = AnchorStyles.Left;
            chk_hasFridge.AutoSize = true;
            chk_hasFridge.Location = new Point(3, 4);
            chk_hasFridge.Name = "chk_hasFridge";
            chk_hasFridge.Size = new Size(75, 24);
            chk_hasFridge.TabIndex = 6;
            chk_hasFridge.Text = "Fridge";
            chk_hasFridge.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel3);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = Color.DarkSlateGray;
            groupBox2.Location = new Point(0, 172);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(314, 97);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pricing and Status";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel3.Controls.Add(label6, 0, 0);
            tableLayoutPanel3.Controls.Add(txtPrice, 1, 0);
            tableLayoutPanel3.Controls.Add(chkAvailable, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 23);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(308, 71);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 7);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 0;
            label6.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Dock = DockStyle.Fill;
            txtPrice.Location = new Point(126, 3);
            txtPrice.Margin = new Padding(3, 3, 22, 3);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(160, 27);
            txtPrice.TabIndex = 4;
            txtPrice.TextChanged += ClearError_Event;
            // 
            // chkAvailable
            // 
            chkAvailable.Anchor = AnchorStyles.Left;
            chkAvailable.AutoSize = true;
            chkAvailable.Location = new Point(126, 41);
            chkAvailable.Name = "chkAvailable";
            chkAvailable.Size = new Size(95, 24);
            chkAvailable.TabIndex = 5;
            chkAvailable.Text = "Available";
            chkAvailable.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = Color.DarkSlateGray;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 172);
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
            tableLayoutPanel2.Controls.Add(txtRoomNumber, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 2);
            tableLayoutPanel2.Controls.Add(label5, 0, 3);
            tableLayoutPanel2.Controls.Add(cmbRoomType, 1, 1);
            tableLayoutPanel2.Controls.Add(cmbRoomView, 1, 2);
            tableLayoutPanel2.Controls.Add(numMaxOccupancy, 1, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 23);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(308, 146);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Dock = DockStyle.Fill;
            txtRoomNumber.Location = new Point(126, 3);
            txtRoomNumber.Margin = new Padding(3, 3, 22, 3);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(160, 27);
            txtRoomNumber.TabIndex = 0;
            txtRoomNumber.TextChanged += ClearError_Event;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 8);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 0;
            label2.Text = "Room Number";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 44);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 1;
            label3.Text = "Room Type";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 80);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 2;
            label4.Text = "View";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 117);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 3;
            label5.Text = "MaxOccupancy";
            // 
            // cmbRoomType
            // 
            cmbRoomType.Dock = DockStyle.Fill;
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Location = new Point(126, 39);
            cmbRoomType.Margin = new Padding(3, 3, 22, 3);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(160, 28);
            cmbRoomType.TabIndex = 1;
            cmbRoomType.SelectedValueChanged += ClearError_Event;
            // 
            // cmbRoomView
            // 
            cmbRoomView.Dock = DockStyle.Fill;
            cmbRoomView.FormattingEnabled = true;
            cmbRoomView.Location = new Point(126, 75);
            cmbRoomView.Margin = new Padding(3, 3, 22, 3);
            cmbRoomView.Name = "cmbRoomView";
            cmbRoomView.Size = new Size(160, 28);
            cmbRoomView.TabIndex = 2;
            cmbRoomView.SelectedValueChanged += ClearError_Event;
            // 
            // numMaxOccupancy
            // 
            numMaxOccupancy.Dock = DockStyle.Fill;
            numMaxOccupancy.Location = new Point(126, 111);
            numMaxOccupancy.Margin = new Padding(3, 3, 22, 3);
            numMaxOccupancy.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMaxOccupancy.Name = "numMaxOccupancy";
            numMaxOccupancy.Size = new Size(160, 27);
            numMaxOccupancy.TabIndex = 3;
            numMaxOccupancy.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // errProvider
            // 
            errProvider.ContainerControl = this;
            // 
            // ucRooms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            Controls.Add(tableLayoutPanel1);
            Name = "ucRooms";
            Size = new Size(800, 600);
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            pnlDetails.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMaxOccupancy).EndInit();
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox txtSearch;
        private DataGridView dgvRooms;
        private Panel pnlDetails;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label6;
        private TextBox txtPrice;
        private CheckBox chkAvailable;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel4;
        private CheckBox chk_meals;
        private CheckBox chk_wifi;
        private CheckBox chk_towels;
        private CheckBox chk_pets;
        private CheckBox chk_smoking;
        private CheckBox chk_hasFridge;
        private GroupBox groupBox4;
        private TextBox txtDescription;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnNew;
        private Button btnDelete;
        private Button btnSave;
        private TextBox txtRoomNumber;
        private ComboBox cmbRoomType;
        private ComboBox cmbRoomView;
        private NumericUpDown numMaxOccupancy;
        private ErrorProvider errProvider;
    }
}
