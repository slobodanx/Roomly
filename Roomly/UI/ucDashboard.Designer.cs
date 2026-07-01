namespace Roomly.UI
{
    partial class ucDashboard
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlStat4 = new Panel();
            lblOccupancy = new Label();
            label4 = new Label();
            pnlStat2 = new Panel();
            lblCheckOuts = new Label();
            label3 = new Label();
            pnlStat3 = new Panel();
            lblCheckIns = new Label();
            label2 = new Label();
            pnlStat1 = new Panel();
            lblAvailableRooms = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvArrivals = new DataGridView();
            dgvDepartures = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            pnlStat4.SuspendLayout();
            pnlStat2.SuspendLayout();
            pnlStat3.SuspendLayout();
            pnlStat1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArrivals).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDepartures).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlStat4
            // 
            pnlStat4.BackColor = Color.PaleGreen;
            pnlStat4.Controls.Add(lblOccupancy);
            pnlStat4.Controls.Add(label4);
            pnlStat4.Dock = DockStyle.Fill;
            pnlStat4.Location = new Point(598, 13);
            pnlStat4.Name = "pnlStat4";
            pnlStat4.Size = new Size(189, 94);
            pnlStat4.TabIndex = 2;
            // 
            // lblOccupancy
            // 
            lblOccupancy.Anchor = AnchorStyles.None;
            lblOccupancy.AutoSize = true;
            lblOccupancy.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblOccupancy.Location = new Point(75, 35);
            lblOccupancy.Name = "lblOccupancy";
            lblOccupancy.Size = new Size(43, 50);
            lblOccupancy.TabIndex = 2;
            lblOccupancy.Text = "0";
            lblOccupancy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(28, 9);
            label4.Name = "label4";
            label4.Size = new Size(137, 23);
            label4.TabIndex = 0;
            label4.Text = "Occupancy Rate";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlStat2
            // 
            pnlStat2.BackColor = Color.LemonChiffon;
            pnlStat2.Controls.Add(lblCheckOuts);
            pnlStat2.Controls.Add(label3);
            pnlStat2.Dock = DockStyle.Fill;
            pnlStat2.Location = new Point(403, 13);
            pnlStat2.Name = "pnlStat2";
            pnlStat2.Size = new Size(189, 94);
            pnlStat2.TabIndex = 2;
            // 
            // lblCheckOuts
            // 
            lblCheckOuts.Anchor = AnchorStyles.None;
            lblCheckOuts.AutoSize = true;
            lblCheckOuts.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblCheckOuts.Location = new Point(73, 35);
            lblCheckOuts.Name = "lblCheckOuts";
            lblCheckOuts.Size = new Size(43, 50);
            lblCheckOuts.TabIndex = 2;
            lblCheckOuts.Text = "0";
            lblCheckOuts.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(19, 9);
            label3.Name = "label3";
            label3.Size = new Size(161, 23);
            label3.TabIndex = 0;
            label3.Text = "Today's Check-outs";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlStat3
            // 
            pnlStat3.BackColor = Color.LightBlue;
            pnlStat3.Controls.Add(lblCheckIns);
            pnlStat3.Controls.Add(label2);
            pnlStat3.Dock = DockStyle.Fill;
            pnlStat3.Location = new Point(208, 13);
            pnlStat3.Name = "pnlStat3";
            pnlStat3.Size = new Size(189, 94);
            pnlStat3.TabIndex = 2;
            // 
            // lblCheckIns
            // 
            lblCheckIns.Anchor = AnchorStyles.None;
            lblCheckIns.AutoSize = true;
            lblCheckIns.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblCheckIns.Location = new Point(75, 35);
            lblCheckIns.Name = "lblCheckIns";
            lblCheckIns.Size = new Size(43, 50);
            lblCheckIns.TabIndex = 2;
            lblCheckIns.Text = "0";
            lblCheckIns.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(24, 9);
            label2.Name = "label2";
            label2.Size = new Size(149, 23);
            label2.TabIndex = 0;
            label2.Text = "Today's Check-ins";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlStat1
            // 
            pnlStat1.BackColor = Color.LightPink;
            pnlStat1.Controls.Add(lblAvailableRooms);
            pnlStat1.Controls.Add(label1);
            pnlStat1.Dock = DockStyle.Fill;
            pnlStat1.Location = new Point(13, 13);
            pnlStat1.Name = "pnlStat1";
            pnlStat1.Size = new Size(189, 94);
            pnlStat1.TabIndex = 1;
            // 
            // lblAvailableRooms
            // 
            lblAvailableRooms.Anchor = AnchorStyles.None;
            lblAvailableRooms.AutoSize = true;
            lblAvailableRooms.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblAvailableRooms.Location = new Point(67, 35);
            lblAvailableRooms.Name = "lblAvailableRooms";
            lblAvailableRooms.Size = new Size(43, 50);
            lblAvailableRooms.TabIndex = 1;
            lblAvailableRooms.Text = "0";
            lblAvailableRooms.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(143, 23);
            label1.TabIndex = 0;
            label1.Text = "Available Rooms";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dgvArrivals, 0, 1);
            tableLayoutPanel1.Controls.Add(dgvDepartures, 1, 1);
            tableLayoutPanel1.Controls.Add(label6, 1, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 120);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 480);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // dgvArrivals
            // 
            dgvArrivals.BackgroundColor = Color.GhostWhite;
            dgvArrivals.BorderStyle = BorderStyle.None;
            dgvArrivals.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvArrivals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvArrivals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArrivals.Dock = DockStyle.Fill;
            dgvArrivals.Location = new Point(13, 43);
            dgvArrivals.MultiSelect = false;
            dgvArrivals.Name = "dgvArrivals";
            dgvArrivals.ReadOnly = true;
            dgvArrivals.RowHeadersWidth = 51;
            dgvArrivals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArrivals.Size = new Size(384, 424);
            dgvArrivals.TabIndex = 0;
            // 
            // dgvDepartures
            // 
            dgvDepartures.BackgroundColor = Color.GhostWhite;
            dgvDepartures.BorderStyle = BorderStyle.None;
            dgvDepartures.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvDepartures.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvDepartures.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartures.Dock = DockStyle.Fill;
            dgvDepartures.Location = new Point(403, 43);
            dgvDepartures.MultiSelect = false;
            dgvDepartures.Name = "dgvDepartures";
            dgvDepartures.ReadOnly = true;
            dgvDepartures.RowHeadersWidth = 51;
            dgvDepartures.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDepartures.Size = new Size(384, 424);
            dgvDepartures.TabIndex = 1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(403, 15);
            label6.Name = "label6";
            label6.Size = new Size(183, 25);
            label6.TabIndex = 3;
            label6.Text = "Today's Departures";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(13, 15);
            label5.Name = "label5";
            label5.Size = new Size(150, 25);
            label5.TabIndex = 2;
            label5.Text = "Today's Arrivals";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(pnlStat4, 3, 0);
            tableLayoutPanel2.Controls.Add(pnlStat1, 0, 0);
            tableLayoutPanel2.Controls.Add(pnlStat2, 2, 0);
            tableLayoutPanel2.Controls.Add(pnlStat3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(10);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(800, 120);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // ucDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Name = "ucDashboard";
            Size = new Size(800, 600);
            Load += ucDashboard_Load;
            pnlStat4.ResumeLayout(false);
            pnlStat4.PerformLayout();
            pnlStat2.ResumeLayout(false);
            pnlStat2.PerformLayout();
            pnlStat3.ResumeLayout(false);
            pnlStat3.PerformLayout();
            pnlStat1.ResumeLayout(false);
            pnlStat1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArrivals).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDepartures).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlStat4;
        private Panel pnlStat2;
        private Panel pnlStat3;
        private Panel pnlStat1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblAvailableRooms;
        private Label lblOccupancy;
        private Label lblCheckOuts;
        private Label lblCheckIns;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvArrivals;
        private DataGridView dgvDepartures;
        private Label label5;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
