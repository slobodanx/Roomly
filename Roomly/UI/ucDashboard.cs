using Roomly.Models;

namespace Roomly.UI
{
    public partial class ucDashboard : UserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
        }

        private void LoadDashboardData()
        {
            try
            {
                using (var db = new Roomly.Data.AppDbContext())
                {
                    // 1. Available Rooms
                    int totalRooms = db.Rooms.Count();
                    int availableRooms = db.Rooms.Count(r => r.IsAvailable == true);
                    lblAvailableRooms.Text = availableRooms.ToString();

                    // 2. Today's Check-ins
                    DateTime today = DateTime.Today;
                    int checkIns = db.Reservations.Count(r => r.CheckInDate.Date == today && r.Status == ReservationStatus.Confirmed);
                    lblCheckIns.Text = checkIns.ToString();

                    // 3. Today's Check-outs
                    int checkOuts = db.Reservations.Count(r => r.CheckOutDate.Date == today && r.Status == ReservationStatus.CheckedIn);
                    lblCheckOuts.Text = checkOuts.ToString();

                    // 4. Occupancy Rate
                    // Occupied rooms are those where IsAvailable is false
                    int occupiedRooms = totalRooms - availableRooms;

                    double occupancyRate = 0;
                    if (totalRooms > 0)
                    {
                        occupancyRate = (double)occupiedRooms / totalRooms * 100;
                    }

                    // Display as a percentage (e.g., "75%")
                    lblOccupancy.Text = $"{occupancyRate:F0}%";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("LoadDashboardData", ex);
            }
        }

        private void LoadUpcomingEvents()
        {
            try
            {
                using (var db = new Roomly.Data.AppDbContext())
                {
                    var service = new Roomly.Services.ReservationService(db);

                    dgvArrivals.DataSource = service.GetTodayArrivals();
                    dgvDepartures.DataSource = service.GetTodayDepartures();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("LoadUpcomingEvents", ex);
            }

        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDashboardData();
                LoadUpcomingEvents();
            }
            catch (Exception ex)
            {
                throw new Exception("ucDashboard_Load", ex);
            }
        }
    }
}
