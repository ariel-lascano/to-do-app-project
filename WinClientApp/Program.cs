using WinClientApp.Backend;
using WinClientApp.Properties;

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
            if (HttpClient.ChannelIR.IsConnected)
            {
                Form1 mainWindow = new Form1(HttpClient.LogOnName);
                Application.Run(mainWindow);
            }
            else
            {
                MessageBox.Show(Resources.CONNECTION_ERROR_MESSAGE, Resources.CONNECTION_ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
