using System.Data.SqlClient;
namespace WinFormsApp1123
{
    internal static class Program
    {
        public static SqlConnection Connection = new SqlConnection(@"Server=DESKTOP-SUPS7IP\SQLEXPRESS03;Database=ScienceCrafts;Trusted_Connection=True;");
        public static SqlCommand Command = new SqlCommand();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Home());
        }
    }
}