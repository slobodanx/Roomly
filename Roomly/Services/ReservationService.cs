using Roomly.Models;
using Roomly.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Roomly.Services
{
    public static class ReservationService
    {
        // --- CRUD Operations ---

        public static void Add(Reservation reservation)
        {
            using (var context = new AppDbContext())
            {
                context.Entry(reservation.Guest).State = EntityState.Unchanged;
                context.Entry(reservation.Room).State = EntityState.Unchanged;

                context.Reservations.Add(reservation);
                context.SaveChanges();
            }
        }

        public static List<Reservation> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.Reservations
                    .Include(r => r.Guest)
                    .Include(r => r.Room)
                    .ToList();
            }
        }

        public static void Update(Reservation reservation)
        {
            using (var context = new AppDbContext())
            {
                // 1. Fetch the existing entity from the database
                var existingReservation = context.Reservations.Find(reservation.Id);

                if (existingReservation != null)
                {
                    // 2. Update the properties of the tracked entity
                    context.Entry(existingReservation).CurrentValues.SetValues(reservation);

                    // 3. Save changes
                    context.SaveChanges();
                }
            }
        }

        public static void Delete(int id)
        {
            using (var context = new AppDbContext())
            {
                var reservation = context.Reservations.Find(id);
                if (reservation != null)
                {
                    context.Reservations.Remove(reservation);
                    context.SaveChanges();
                }
            }
        }

        // --- Existing Dashboard Features ---

        public static List<object> GetTodayArrivals()
        {
            using (var context = new AppDbContext())
            {
                DateTime today = DateTime.Today;
                return context.Reservations
                    .Include(r => r.Guest)
                    .Include(r => r.Room)
                    .Where(r => r.CheckInDate.Date == today && r.Status == ReservationStatus.Confirmed)
                    .Select(r => new { Guest = r.Guest.FullName, Room = r.Room.RoomNumber })
                    .ToList<object>();
            }
        }

        public static List<object> GetTodayDepartures()
        {
            using (var context = new AppDbContext())
            {
                DateTime today = DateTime.Today;
                return context.Reservations
                    .Include(r => r.Guest)
                    .Include(r => r.Room)
                    .Where(r => r.CheckOutDate.Date == today && r.Status == ReservationStatus.CheckedIn)
                    .Select(r => new { Guest = r.Guest.FullName, Room = r.Room.RoomNumber })
                    .ToList<object>();
            }
        }

        // --- Helper for Availability Check ---

        public static bool IsRoomAvailable(int roomId, DateTime checkIn, DateTime checkOut, int excludeReservationId = -1)
        {
            using (var context = new AppDbContext())
            {
                return !context.Reservations.Any(r =>
                    r.RoomId == roomId &&
                    r.Id != excludeReservationId && // Exclude the record we are currently updating
                    r.Status != ReservationStatus.Cancelled &&
                    r.CheckInDate < checkOut &&
                    r.CheckOutDate > checkIn);
            }
        }

        // --- Search ---

        public static List<Reservation> Search(string searchTerm)
        {
            using (var context = new AppDbContext())
            {
                string term = searchTerm.ToLower();
                return context.Reservations
                    .Include(r => r.Guest)
                    .Include(r => r.Room)
                    .Where(r => r.Guest.FirstName.ToLower().Contains(term) ||
                                r.Guest.LastName.ToLower().Contains(term) ||
                                r.Room.RoomNumber.ToString().Contains(term))
                    .ToList();
            }
        }
    }
}