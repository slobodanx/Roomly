using System.ComponentModel.DataAnnotations;

namespace Roomly.Models
{
    public class Room
    {
        public int Id { get; set; }

        [Required]
        public required string RoomNumber { get; set; }

        public required RoomType RoomType { get; set; } // e.g., "Single", "Double", "Suite"
        public RoomView View { get; set; } = RoomView.Standard;

        public int MaxOccupancy { get; set; }

        public decimal PricePerNight { get; set; }

        // Amenities
        public bool HasFridge { get; set; }
        public bool IsSmokingAllowed { get; set; }
        public bool AllowsPets { get; set; }
        public bool HasTowels { get; set; }
        public bool HasWifi { get; set; }
        public bool IncludesMeals { get; set; }

        public bool IsAvailable { get; set; } = true;

        [StringLength(200)]
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}