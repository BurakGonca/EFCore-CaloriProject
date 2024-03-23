using CaloriProject.BLL.Models;
using CaloriProject.DAL.Entities;
using CaloriProject.UI.Forms;

namespace CaloriProject.UI
{
    internal static class Program
    {
        public static KullaniciModel KullaniciModel { get; set; }

        public static Form AnaSayfa { get; set; }
        public static Form ReferansSayfa { get; set; }
        public static Form AktifSayfa { get; set; } //gelen sayfa

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Giris());

            
        }

       

    }
}