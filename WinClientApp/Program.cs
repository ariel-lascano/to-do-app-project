namespace WinClientApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}

// HttpCaller e = new HttpCaller();
// //await e.ExecuteGet(0, "ciao", "pluto");
// await e.ExecuteUpdate(new SharedModel.ToDoItem(6, 0, "ciao", "pluto"));
