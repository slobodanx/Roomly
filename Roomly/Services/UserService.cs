using Microsoft.EntityFrameworkCore;
using Roomly.Data;
using Roomly.Models;
using System.Linq;

namespace Roomly.Services
{
    public class UserService
    {
        public User? Authenticate(string username, string password)
        {
            using (var db = new AppDbContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Username == username);

                // If user is found and password matches
                if (user != null && BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
                {
                    return user; // Return the user object if login succeeds
                }

                return null; // Return null if it fails
            }
        }
    }
}