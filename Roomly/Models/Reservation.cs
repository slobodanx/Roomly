using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Roomly.Models
{
    public enum ReservationStatus
    {
        Pending,
        Confirmed,
        CheckedIn,
        CheckedOut,
        Cancelled
    }

    public enum DiscountType
    {
        None,
        Percentage,
        FixedAmount
    }

    public class Reservation
    {
        public int Id { get; set; }

        // --- Relationships ---
        [Required]
        public int GuestId { get; set; }
        [ForeignKey("GuestId")]
        public Guest Guest { get; set; }

        [Required]
        public int RoomId { get; set; }
        [ForeignKey("RoomId")]
        public required Room Room { get; set; }

        // --- Booking Dates ---
        [Required]
        public DateTime CheckInDate { get; set; }

        [Required]
        public DateTime CheckOutDate { get; set; }

        // --- Guest Count Breakdown ---
        [Required]
        public int AdultCount { get; set; } = 1;

        public int ChildrenCount { get; set; } = 0;

        // Optional: If you need to track the ages of children (for specific pricing)
        public string? ChildrenAges { get; set; } // e.g., "5, 8"

        // --- Financials ---
        [Required]
        public decimal BasePrice { get; set; } // The price before discount

        public decimal DiscountValue { get; set; } // Amount or Percentage

        public DiscountType DiscountType { get; set; } = DiscountType.None;

        // This property is NOT stored in the database, it is calculated on the fly
        [NotMapped]
        public decimal FinalPrice
        {
            get
            {
                if (DiscountType == DiscountType.Percentage)
                    return BasePrice - (BasePrice * (DiscountValue / 100));
                if (DiscountType == DiscountType.FixedAmount)
                    return BasePrice - DiscountValue;
                return BasePrice;
            }
        }

        // --- Meta & Status ---
        public ReservationStatus Status { get; set; } = ReservationStatus.Pending;

        [StringLength(500)]
        public string? Note { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}