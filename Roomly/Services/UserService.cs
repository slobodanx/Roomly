using Microsoft.EntityFrameworkCore;
using Roomly.Data;
using Roomly.Models;
using System.Linq;

namespace Roomly.Services
{
    public class UserService
    {
        public AuthResult Authenticate(string username, string password)
        {
            using (var db = new AppDbContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Username == username);

                // 1. User doesn't exist
                if (user == null)
                    return new AuthResult { Message = "Invalid username or password." };

                // 2. Password mismatch
                if (!BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
                    return new AuthResult { Message = "Invalid username or password." };

                // 3. User is inactive (Pending approval)
                if (!user.IsActive)
                    return new AuthResult { Message = "Your account is pending administrator approval." };

                // 4. Success
                return new AuthResult { User = user };
            }
        }
    }
}