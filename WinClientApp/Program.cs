using WinClientApp.Backend;

namespace WinClientApp
{
    internal static class Program
    {
        internal static ClientHttp HttpClient;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            HttpClient = new ClientHttp();
            Form1 mainWindow = new Form1(HttpClient.LogOnName);

            Application.Run(mainWindow);
        }
    }
}
