using System.Collections.Generic;

namespace Roomly.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<User> Users { get; set; }
    }
}
