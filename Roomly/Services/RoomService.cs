using Microsoft.EntityFrameworkCore;
using Roomly.Data;
using Roomly.Models;

public static class RoomService
{
    // Fetches all rooms from the database
    public static List<Room> GetAllRooms()
    {
        using (var context = new AppDbContext()) // Your DbContext
        {
            return context.Rooms.ToList();
        }
    }

    // Handles adding a new room
    public static void AddRoom(Room room)
    {
        using (var context = new AppDbContext())
        {
            context.Rooms.Add(room);
            context.SaveChanges();
        }
    }

    // Handles updating an existing room
    public static void UpdateRoom(Room room)
    {
        using (var context = new AppDbContext())
        {
            context.Rooms.Update(room);
            context.SaveChanges();
        }
    }

    public static void DeleteRoom(int roomId)
    {
        // Validate if deletion is permitted
        if (!CanDeleteRoom(roomId))
        {
            throw new InvalidOperationException("Cannot delete: Room is associated with existing reservations.");
        }

        using (var context = new AppDbContext())
        {
            var room = context.Rooms.Find(roomId);
            if (room != null)
            {
                context.Rooms.Remove(room);
                context.SaveChanges();
            }
        }
    }

    public static bool CanDeleteRoom(int roomId)
    {
        using (var context = new AppDbContext())
        {
            // Check if the room has any associated reservations
            var room = context.Rooms
                              .Include(r => r.Reservations)
                              .FirstOrDefault(r => r.Id == roomId);

            // Safe to delete if room doesn't exist or has no reservations
            return room == null || room.Reservations.Count == 0;
        }
    }
}