
namespace Roomly.UI
{
    public partial class MainForm : Form
    {
        public MainForm(Models.User user)
        {
            InitializeComponent();
        }
        private void LoadUserControl(UserControl uc)
        {
            pnl_container.Controls.Clear(); // Remove previous control
            uc.Dock = DockStyle.Fill;     // Make it fill the container
            pnl_container.Controls.Add(uc); // Show the new control
        }

        private void txt_dashboard_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucDashboard());
        }

        private void btn_rooms_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucRooms());
        }

        private void txt_reservations_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucReservations());
        }

        private void txt_guests_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucGuests());
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
