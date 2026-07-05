
namespace Roomly.UI
{
    public partial class MainForm : Form
    {
        public MainForm(Models.User user)
        {
            InitializeComponent();
            //menu visible only for admin role
            btnAdminMenu.Visible = (user.RoleId == 1);
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
            var confirm = MessageBox.Show("Are you sure you want to log out?",
                                  "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                // Simply closing the form now returns control to the loop in Program.cs
                this.Close();
            }
        }

        private void btnAdminMenu_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucAdminDashboard());
            this.Text = "Hotel Reservation and Management System > Admin Dashboard";
        }
    }
}
