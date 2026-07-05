using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Roomly.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public required string Username { get; set; }

        [Required]
        public required string PasswordHash { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        // Foreign key to Role
        public int RoleId { get; set; } = 1;
        public Role? Role { get; set; }     // e.g., "Admin", "Receptionist"

        public bool IsActive { get; set; } = false;
    }
}