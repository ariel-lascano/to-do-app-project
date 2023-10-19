using WinClientApp.Enums;
using WinClientApp.ViewModel;

namespace WinClientApp.View
{
    internal static class ContentControlUtils
    {
        private static string TextPattern => "{0} - {1}";

        internal static TreeNode GetNode(ToDoItemViewModel toDoItemViewModel)
        {
            string text = string.Format(TextPattern, toDoItemViewModel.Priority, toDoItemViewModel.Name);

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
                HttpManager.Instance.Execute(HttpAction.Update, selectedItem.GetModel());
                HttpManager.Instance.Execute(HttpAction.Update, nearlyItem.GetModel());

                int selectedIndex = selectedItem.ItemNode.Parent.Nodes.IndexOf(selectedItem.ItemNode);
                int nearlyIndex = nearlyItem.ItemNode.Parent.Nodes.IndexOf(nearlyItem.ItemNode);

                SwapNodes(rootNode,selectedIndex, selectedItem, nearlyIndex, nearlyItem);
                SwapRows(dataGridView, selectedIndex, selectedItem, nearlyIndex, nearlyItem);
            }
        }

        internal static void SwapNodes(TreeNode rootNode, int selectedIndex, ToDoItemViewModel selectedItem, int nearlyIndex, ToDoItemViewModel nearlyItem)
        {
            selectedItem.ItemNode.Remove();
            nearlyItem.ItemNode.Remove();
            
            selectedItem.ItemNode.Text = string.Format(TextPattern, selectedItem.Priority, selectedItem.Name);
            nearlyItem.ItemNode.Text = string.Format(TextPattern, nearlyItem.Priority, nearlyItem.Name);

            rootNode.Nodes.Insert(nearlyIndex, selectedItem.ItemNode);
            rootNode.Nodes.Insert(selectedIndex, nearlyItem.ItemNode);
        }

        internal static void SwapRows(DataGridView dataGridView, int selectedIndex, ToDoItemViewModel selectedItem, int nearlyIndex, ToDoItemViewModel nearlyItem)
        {
            DataGridViewRow selectedRow = selectedItem.ItemRow;
            DataGridViewRow nearlyRow = nearlyItem.ItemRow;

            dataGridView.Rows.Remove(selectedRow);
            dataGridView.Rows.Remove(nearlyRow);

            selectedRow.Cells[0].Value = selectedItem.Priority;
            nearlyRow.Cells[0].Value = nearlyItem.Priority;

            if (dataGridView.Rows.Count > nearlyIndex)
                dataGridView.Rows.Insert(nearlyIndex, selectedRow);
            else
                dataGridView.Rows.Add(selectedRow);

            if (dataGridView.Rows.Count > selectedIndex)
                dataGridView.Rows.Insert(selectedIndex, nearlyRow);
            else
                dataGridView.Rows.Add(nearlyRow);
        }
    }
}
