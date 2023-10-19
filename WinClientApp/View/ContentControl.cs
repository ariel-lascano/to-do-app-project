using SharedModel;
using WinClientApp.Enums;
using WinClientApp.Properties;
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
            AfterInitializeComponent();
        }

        private void AfterInitializeComponent()
        {
            // Retrive data from web service:
            _dataSource = ToDoItemViewModel.InitializeViewModels().OrderBy(oi => oi.Priority).ToList();
            _rootNode = treeView.Nodes[0];

            ContentControlUtils.SetToolTip(upButton, Resources.MOVE_UP);
            ContentControlUtils.SetToolTip(downButton, Resources.MOVE_DOWN);
            ContentControlUtils.SetToolTip(cancelButton, Resources.DELETE_SELECTED);

            LoadData();
        }

        private void LoadData()
        {
            int itemsCount = _dataSource.Count;
            TreeNode[] childNodes = new TreeNode[itemsCount];
            DataGridViewRow[] childRows = new DataGridViewRow[itemsCount];


            for (int index = 0; index < itemsCount; index++)
            {
                ToDoItemViewModel toDoItemViewModel = _dataSource[index];
                toDoItemViewModel.ItemNode = ContentControlUtils.GetNode(toDoItemViewModel);
                childNodes[index] = toDoItemViewModel.ItemNode;

                toDoItemViewModel.ItemRow = ContentControlUtils.GetRow(toDoItemViewModel);
                childRows[index] = toDoItemViewModel.ItemRow;

            }
            _rootNode.Nodes.AddRange(childNodes);
            dataGridView.Rows.AddRange(childRows);

            _rootNode.ExpandAll();

            dataGridView.CellValueChanged += dataGridView_CellValueChanged;
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cellAfterEdit = dataGridView[e.ColumnIndex, e.RowIndex];
            ToDoItemViewModel toDoItemsViewModel = cellAfterEdit.OwningRow.Tag as ToDoItemViewModel;

            if (e.ColumnIndex == 1)
                toDoItemsViewModel.Name = cellAfterEdit.Value.ToString();
            else
                toDoItemsViewModel.Description = cellAfterEdit.Value.ToString();

            // TODO: Error management
            HttpManager.Instance.Execute(HttpAction.Update, toDoItemsViewModel.GetModel());
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            bool isRoot = e.Node == _rootNode;

            ContentControlUtils.SetEnable(!isRoot, cancelButton, upButton, downButton);
            dataGridView.ClearSelection();

            if (!isRoot)
            {
                ToDoItemViewModel toDoItemViewModel = e.Node.Tag as ToDoItemViewModel;
                dataGridView.Rows[toDoItemViewModel.ItemRow.Index].Selected = true;
            }
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            ContentControlUtils.Swap(SwapDirection.Up, treeView.SelectedNode.Tag as ToDoItemViewModel, dataGridView, _rootNode);
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            ContentControlUtils.Swap(SwapDirection.Down, treeView.SelectedNode.Tag as ToDoItemViewModel, dataGridView, _rootNode);
        }

        private void newItemButton_Click(object sender, EventArgs e)
        {
            int? maxPriority = _dataSource.Max(i => i?.Priority);
            int nextPriorityValue = maxPriority == null ? 1 : (int)maxPriority + 1;

            ToDoItemViewModel toDoItemViewModel = new ToDoItemViewModel(nextPriorityValue, Resources.NEW_ITEM_DEFAULT_NAME, string.Empty);
            ToDoItem createdItem = HttpManager.Instance.Execute<ToDoItem>(HttpAction.Create, toDoItemViewModel.GetModel());

            if (createdItem == null)
            {
                // Error management...
            }
            else
            {
                toDoItemViewModel.SetModel(createdItem);
                toDoItemViewModel.ItemNode = ContentControlUtils.GetNode(toDoItemViewModel);
                toDoItemViewModel.ItemRow = ContentControlUtils.GetRow(toDoItemViewModel);

                _rootNode.Nodes.Add(toDoItemViewModel.ItemNode);
                dataGridView.Rows.Add(toDoItemViewModel.ItemRow);
                _dataSource.Add(toDoItemViewModel);

                treeView.SelectedNode = toDoItemViewModel.ItemNode;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode.Tag is ToDoItemViewModel)
            {
                ToDoItemViewModel cancelViewModel = treeView.SelectedNode.Tag as ToDoItemViewModel;

                string messageFormat = string.Format(Resources.DELETE_MESSAGE, cancelViewModel.Name);

                if (MessageBox.Show(messageFormat, Resources.WARNING, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (HttpManager.Instance.Execute(HttpAction.Delete, cancelViewModel.GetModel()))
                    {
                        cancelViewModel.ItemNode.Remove();
                        dataGridView.Rows.Remove(cancelViewModel.ItemRow);

                        _dataSource.Remove(cancelViewModel);
                    }
                    else
                    {
                        // MessageBox.Show("Eccezzione...")
                    }
                }
            }
        }
    }
}
