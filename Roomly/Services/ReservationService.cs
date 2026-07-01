using Roomly.Models;

namespace Roomly.Services
{
    public class ReservationService
    {
        private readonly Data.AppDbContext _db;

        public ReservationService(Data.AppDbContext db)
        {
            _db = db;
        }

        public List<object> GetTodayArrivals()
        {
            DateTime today = DateTime.Today;
            return _db.Reservations
                .Where(r => r.CheckInDate.Date == today && r.Status == ReservationStatus.Confirmed)
                .Select(r => new { Guest = r.Guest.FullName, Room = r.Room.RoomNumber })
                .ToList<object>(); 
        }

        public List<object> GetTodayDepartures()
        {
            DateTime today = DateTime.Today;
            return _db.Reservations
                .Where(r => r.CheckOutDate.Date == today && r.Status == ReservationStatus.CheckedIn)
                .Select(r => new { Guest = r.Guest.FullName, Room = r.Room.RoomNumber })
                .ToList<object>(); 
        }
    }
}