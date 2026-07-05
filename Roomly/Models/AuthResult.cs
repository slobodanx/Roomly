namespace Roomly.Models
{
    public class AuthResult
    {
        public User? User { get; set; }
        public string Message { get; set; } = string.Empty;
        public bool Success => User != null;
    }
}