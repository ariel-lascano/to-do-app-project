namespace WinClientApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string logOnName) : this()
        {
            AfterInitializeComponent(logOnName);
        }

        private void AfterInitializeComponent(string logOnName)
        {
            logonButton.Text = logOnName;
            contentControl.AfterInitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Program.HttpClient.Dispose();
            Cursor = Cursors.Default;
        }
    }
}