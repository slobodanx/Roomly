using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Roomly.Models
{
    public class Guest
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public required string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public required string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [Phone]
        public required string Phone { get; set; }
        public string? DocumentType { get; set; }
        public string? DocumentNumber { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }

        [StringLength(500)]
        public string? Note { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? LastUpdated { get; set; }
        public string? ModifiedBy { get; set; }
        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
        public string FullName => $"{FirstName} {LastName}";
    }
}