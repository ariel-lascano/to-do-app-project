using WinClientApp.Enums;
using WinClientApp.ViewModel;

namespace WinClientApp.View
{
    internal static class ContentControlUtils
    {
        private static string TextPattern => "{0} - {1}";

        internal static string GetNodeText(int priority, string name)
        {
            return string.Format(TextPattern, priority, name); 
        }

        internal static TreeNode GetNode(ToDoItemViewModel toDoItemViewModel)
        {
            string text = GetNodeText(toDoItemViewModel.Priority, toDoItemViewModel.Name);

            TreeNode itemTreeNode = new TreeNode(text);
            itemTreeNode.Tag = toDoItemViewModel;

            return itemTreeNode;
        }

        internal static DataGridViewRow GetRow(ToDoItemViewModel toDoItemViewModel)
        {
            DataGridViewCell priorityCell = new DataGridViewTextBoxCell();
            priorityCell.Value = toDoItemViewModel.Priority;
            DataGridViewCell nameCell = new DataGridViewTextBoxCell();
            nameCell.Value = toDoItemViewModel.Name;
            DataGridViewCell descriptionCell = new DataGridViewTextBoxCell();
            descriptionCell.Value = toDoItemViewModel.Description;

            DataGridViewRow dataGridViewRow = new DataGridViewRow();
            dataGridViewRow.Tag = toDoItemViewModel;
            dataGridViewRow.Cells.AddRange(priorityCell, nameCell, descriptionCell);
            return dataGridViewRow;
        }

        internal static void SetEnable(bool status, params Button[] buttons)
        {
            foreach (Button button in buttons)
                button.Enabled = status;
        }

        internal static void SetToolTip(Button button, string text)
        {
            ToolTip newToolTip = new ToolTip();
            newToolTip.SetToolTip(button, text);
        }

        internal static bool CanSwap(SwapDirection direction, TreeNode selectedNode, out TreeNode nearlyNode)
        {
            if (direction == SwapDirection.Up)
                nearlyNode = selectedNode.PrevNode;
            else
                nearlyNode = selectedNode.NextNode;

            return nearlyNode != null;
        }

        internal static void Swap(SwapDirection direction, ToDoItemViewModel selectedItem, DataGridView dataGridView, TreeNode rootNode )
        {
            if (CanSwap(direction, selectedItem.ItemNode, out TreeNode nearlyNode))
            {
                ToDoItemViewModel nearlyItem = nearlyNode.Tag as ToDoItemViewModel;

                int selectedItemPriority = selectedItem.Priority;
                selectedItem.Priority = nearlyItem.Priority;
                nearlyItem.Priority = selectedItemPriority;

                // TODO: Error management
                
                int selectedIndex = selectedItem.ItemNode.Parent.Nodes.IndexOf(selectedItem.ItemNode);
                int nearlyIndex = nearlyItem.ItemNode.Parent.Nodes.IndexOf(nearlyItem.ItemNode);

                SwapNodes(rootNode,selectedIndex, selectedItem, nearlyIndex, nearlyItem);
                SwapRows(dataGridView, selectedIndex, selectedItem, nearlyIndex, nearlyItem);

                nearlyItem.NotifyUpdate();
                selectedItem.NotifyUpdate();

                selectedItem.ItemNode.TreeView.SelectedNode = selectedItem.ItemNode;
            }
        }

        internal static void SwapNodes(TreeNode rootNode, int selectedIndex, ToDoItemViewModel selectedItem, int nearlyIndex, ToDoItemViewModel nearlyItem)
        {
            selectedItem.ItemNode.Text = string.Format(TextPattern, selectedItem.Priority, selectedItem.Name);
            nearlyItem.ItemNode.Text = string.Format(TextPattern, nearlyItem.Priority, nearlyItem.Name);

            TreeNode selectedNodeBackup = selectedItem.ItemNode;
            TreeNode newSelectedNodeClone = (TreeNode)selectedNodeBackup.Clone();
            selectedItem.ItemNode = newSelectedNodeClone;

            TreeNode nearlyNodeBackup = nearlyItem.ItemNode;
            TreeNode nearlyNodeClone = (TreeNode)nearlyNodeBackup.Clone();
            nearlyItem.ItemNode = nearlyNodeClone;

            rootNode.Nodes.Insert(selectedIndex, nearlyItem.ItemNode);
            rootNode.Nodes.Insert(nearlyIndex, selectedItem.ItemNode);

            nearlyNodeBackup.Remove();
            selectedNodeBackup.Remove();
        }

        internal static void SwapRows(DataGridView dataGridView, int selectedIndex, ToDoItemViewModel selectedItem, int nearlyIndex, ToDoItemViewModel nearlyItem)
        {
            DataGridViewRow selectedRowBackup = selectedItem.ItemRow;
            DataGridViewRow selectedRowClone = (DataGridViewRow)selectedRowBackup.Clone();
            
            selectedRowClone.Cells.Clear();
            foreach (DataGridViewCell dataGridViewCell in selectedRowBackup.Cells)
            {
                DataGridViewCell dataGridViewCellClone = (DataGridViewCell)dataGridViewCell.Clone();
                dataGridViewCellClone.Value = dataGridViewCell.Value;
                
                selectedRowClone.Cells.Add(dataGridViewCellClone);
            }

            selectedRowClone.Cells[0].Value = selectedItem.Priority;
            selectedItem.ItemRow = selectedRowClone;

            DataGridViewRow nearlyRowBackup = nearlyItem.ItemRow;
            DataGridViewRow nearlyRowClone = (DataGridViewRow)nearlyRowBackup.Clone();

            nearlyRowClone.Cells.Clear();
            foreach (DataGridViewCell dataGridViewCell in nearlyRowBackup.Cells)
            {
                DataGridViewCell dataGridViewCellClone = (DataGridViewCell)dataGridViewCell.Clone();
                dataGridViewCellClone.Value = dataGridViewCell.Value;

                nearlyRowClone.Cells.Add(dataGridViewCellClone);
            }

            nearlyRowClone.Cells[0].Value = nearlyItem.Priority;
            nearlyItem.ItemRow = nearlyRowClone;
            
            dataGridView.Rows.Insert(selectedIndex, nearlyRowClone);
            dataGridView.Rows.Insert(nearlyIndex, selectedRowClone);
            
            dataGridView.Rows.Remove(selectedRowBackup);
            dataGridView.Rows.Remove(nearlyRowBackup);
        }
    }
}
