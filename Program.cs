using System.Windows.Forms;

namespace EasyFTPServer
{
    internal static class Program
    {
        public static Mutex mutex;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createdNew;
            mutex = new Mutex(true, "EasyFTPServer0x00", out createdNew);
            if (createdNew)
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new MainForm());
                mutex.ReleaseMutex();
            }
        }
    }
}