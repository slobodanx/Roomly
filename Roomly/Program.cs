using Microsoft.EntityFrameworkCore;
using Roomly.UI;

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
                context.Database.Migrate();

                if (!context.Users.Any())
                {
                    using (var setup = new Register(true))
                    {
                        if (setup.ShowDialog() != DialogResult.OK) return;
                    }
                }

                // Keep the application running in a loop
                bool loggedIn = true;
                while (loggedIn)
                {
                    using (var login = new Login())
                    {
                        if (login.ShowDialog() == DialogResult.OK)
                        {
                            // Run the main form and wait for it to close
                            Application.Run(new MainForm(login.LoggedInUser!));
                        }
                        else
                        {
                            // If login is cancelled, exit the loop and app
                            break;
                        }
                    }
                }
            }
        }
    }
}