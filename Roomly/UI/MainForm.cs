
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
            this.Text = "Hotel Reservation and Management System > Dashboard";
        }

        private void btn_rooms_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucRooms());
            this.Text = "Hotel Reservation and Management System > Rooms";
        }

        private void txt_reservations_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucReservations());
            this.Text = "Hotel Reservation and Management System > Reservations";
        }

        private void txt_guests_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucGuests());
            this.Text = "Hotel Reservation and Management System > Guests";
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
