using Microsoft.Identity.Client;
using System.Configuration;
namespace FlashCardApp
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
            //ApplicationConfiguration.Initialize(); - This was only added in .Net 6.0
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Sets first form to show up
            Application.Run(new Login());
        }
    }
}