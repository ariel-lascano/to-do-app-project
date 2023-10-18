using SharedModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinClientApp.Managers;

namespace WinClientApp.View
{
    public partial class FormContent : UserControl
    {
        public FormContent()
        {
            InitializeComponent();
            AfterInitializeComponent();
        }

        private void AfterInitializeComponent()
        {
            IEnumerable<ToDoItem> dataSource = ItemsManager.Instance.GetAll();
            // ...
        }
    }
}
