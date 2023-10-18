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
using WinClientApp.ViewModel;

namespace WinClientApp.View
{
    public partial class ContentControl : UserControl
    {
        private List<ToDoItemViewModel> _dataSource;
        private TreeNode _rootNode;

        public ContentControl()
        {
            InitializeComponent();
            _dataSource = ItemsManager.Instance.GetAll()
                .Select(item => new ToDoItemViewModel(item))
                .ToList();
            _rootNode = treeView1.Nodes[0];

            LoadData();
        }

        private void LoadData()
        {
            TreeNode[] childNodes = _dataSource.Select(item =>
                {
                    TreeNode itemTreeNode = new TreeNode(item.Name);
                    itemTreeNode.Tag = item;

                    return itemTreeNode;
                }
            ).ToArray();

            _rootNode.Nodes.AddRange(childNodes);
            _rootNode.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            propertyGrid1.SelectedObject = e.Node.Tag;
        }
    }
}
