namespace Roomly.UI
{
    partial class frmSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelector));
            pnlHost = new Panel();
            SuspendLayout();
            // 
            // pnlHost
            // 
            pnlHost.Dock = DockStyle.Fill;
            pnlHost.Location = new Point(0, 0);
            pnlHost.Name = "pnlHost";
            pnlHost.Size = new Size(882, 653);
            pnlHost.TabIndex = 0;
            // 
            // frmSelector
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 653);
            Controls.Add(pnlHost);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(900, 700);
            Name = "frmSelector";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmSelector";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHost;
    }
}