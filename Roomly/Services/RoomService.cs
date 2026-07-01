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
}