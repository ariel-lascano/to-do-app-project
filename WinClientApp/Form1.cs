namespace WinClientApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            HttpManager.Instance.Dispose();
            Cursor = Cursors.Default;
        }
    }
}