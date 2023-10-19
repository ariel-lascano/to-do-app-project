using SharedModel;
using WinClientApp.Backend;
using WinClientApp.Enums;
using WinClientApp.Properties;

namespace WinClientApp.ViewModel
{
    internal class ToDoItemViewModel
    {
        private ToDoItem _toDoItemModel;

        internal int ID 
        {
            get => _toDoItemModel.ID;
        }

        internal int Priority 
        {
            get => _toDoItemModel.VisualOrder;
            set => _toDoItemModel.VisualOrder = value;
        }
        internal string Name 
        {
            get => _toDoItemModel.Name;
            set => _toDoItemModel.Name = value;
        }
        internal string? Description 
        {
            get => _toDoItemModel.Description;
            set => _toDoItemModel.Description = value;
        }

        internal TreeNode ItemNode { get; set; }
        internal DataGridViewRow ItemRow { get; set; }

        internal ToDoItemViewModel(ToDoItem toDoItem)
        {
            _toDoItemModel = toDoItem;
        }

        internal void NotifyUpdate()
        {
            Program.HttpClient.Execute(HttpAction.Update, _toDoItemModel);
        }

        internal bool Remove()
        {
            if (Program.HttpClient.Execute(HttpAction.Delete, _toDoItemModel))
            {
                Program.HttpClient.SendNotificationToServer();
                return true;
            }
            return false;
        }

        internal static ToDoItemViewModel GetNew(int nextPriorityValue)
        {
            ToDoItem toDoItem = new ToDoItem(nextPriorityValue, Resources.NEW_ITEM_DEFAULT_NAME, string.Empty);
            toDoItem = Program.HttpClient.Execute<ToDoItem>(HttpAction.Create, toDoItem);

            if (toDoItem != null)
            {
                Program.HttpClient.SendNotificationToServer();
                ToDoItemViewModel toDoItemViewModel = new ToDoItemViewModel(toDoItem);
                return toDoItemViewModel;
            }
            return null;
        }

        internal static IEnumerable<ToDoItemViewModel> InitializeViewModels()
        {
            IEnumerable<ToDoItem> data = Program.HttpClient.Execute<IEnumerable<ToDoItem>>(HttpAction.Read, null);
            
            if (data == null)
                return new List<ToDoItemViewModel>();
            else
                return data.Select(item => new ToDoItemViewModel(item));
        }

        
    }
}
