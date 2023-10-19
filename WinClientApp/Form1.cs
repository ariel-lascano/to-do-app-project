using System.Windows.Forms;
using WinClientApp.Properties;
using WinClientApp.ViewModel;

namespace WinClientApp
{
    public partial class Form1 : Form
    {
        public Button RefreshButton => refreshButton;

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
            Program.HttpClient.Dispose();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            contentControl.Refresh();
            refreshButton.Visible = false;
            contentControl.Enabled = true;
        }
    }
}