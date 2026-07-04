
namespace Roomly.UI
{
    public partial class frmSelector : Form
    {
        public frmSelector(Control controlToHost, string title)
        {
            InitializeComponent();
            this.Text = title;

            // 1. Host the control inside your Panel
            controlToHost.Dock = DockStyle.Fill;
            pnlHost.Controls.Add(controlToHost);
        }
    }
}
