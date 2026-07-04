using Roomly.Data;
using Roomly.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Roomly.Services
{
    public static class GuestService
    {
        public static List<Guest> GetAllGuests()
        {
            using (var context = new AppDbContext())
            {
                return context.Guests.ToList();
            }
        }

        public static Guest? GetGuestById(int id)
        {
            using (var context = new AppDbContext())
            {
                return context.Guests.Find(id);
            }
        }

        public static Guest? GetGuestByPhone(string phone)
        {
            using (var context = new AppDbContext())
            {
                return context.Guests.FirstOrDefault(g => g.Phone == phone);
            }
        }

        public static void AddGuest(Guest guest)
        {
            using (var context = new AppDbContext())
            {
                guest.CreatedAt = DateTime.UtcNow;
                context.Guests.Add(guest);
                context.SaveChanges();
            }
        }

        public static void UpdateGuest(Guest guest)
        {
            using (var context = new AppDbContext())
            {
                var existing = context.Guests.Find(guest.Id);
                if (existing != null)
                {
                    // Update fields
                    existing.FirstName = guest.FirstName;
                    existing.LastName = guest.LastName;
                    existing.BirthDate = guest.BirthDate;
                    existing.Email = guest.Email;
                    existing.Phone = guest.Phone;
                    existing.DocumentType = guest.DocumentType;
                    existing.DocumentNumber = guest.DocumentNumber;
                    existing.City = guest.City;
                    existing.Country = guest.Country;
                    existing.Note = guest.Note;
                    existing.LastUpdated = DateTime.UtcNow;

                    context.SaveChanges();
                }
            }
        }

        public static void DeleteGuest(int guestId)
        {
            if (!CanDeleteGuest(guestId))
                throw new InvalidOperationException("Cannot delete: Guest is associated with existing reservations.");

            using (var context = new AppDbContext())
            {
                var guest = context.Guests.Find(guestId);
                if (guest != null)
                {
                    context.Guests.Remove(guest);
                    context.SaveChanges();
                }
            }
        }

        public static List<Guest> SearchGuests(string searchTerm)
        {
            using (var context = new AppDbContext())
            {
                string term = searchTerm.ToLower();
                return context.Guests
                    .Where(g => g.Phone.Contains(term) ||
                                g.FirstName.ToLower().Contains(term) ||
                                g.LastName.ToLower().Contains(term))
                    .ToList();
            }
        }

        public static bool CanDeleteGuest(int guestId)
        {
            using (var context = new AppDbContext())
            {
                // Include the Reservations navigation property
                var guest = context.Guests
                                   .Include(g => g.Reservations)
                                   .FirstOrDefault(g => g.Id == guestId);

                // Can delete if guest doesn't exist or has no reservations
                return guest == null || guest.Reservations.Count == 0;
            }
        }
    }
}