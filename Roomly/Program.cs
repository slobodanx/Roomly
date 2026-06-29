namespace Roomly
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            using (var context = new Roomly.Data.AppDbContext())
            {
                context.Database.EnsureCreated();

                // Check if Admin exists, if not, create it
                if (!context.Users.Any(u => u.Username == "admin"))
                {
                    context.Users.Add(new Roomly.Models.User
                    {
                        Username = "admin",
                        PasswordHash = BCrypt.Net.BCrypt.HashPassword("admin"),
                        RoleId = 1
                    });
                    context.SaveChanges();
                }
            }

            Application.Run(new Login());
        }
    }
}