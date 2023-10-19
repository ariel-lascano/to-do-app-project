using SharedModel;
using WinClientApp.Enums;

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

        internal ToDoItemViewModel(int visualOrder, string name, string description)
        {
            _toDoItemModel = new ToDoItem(visualOrder, name, description);
        }

        internal ToDoItemViewModel(ToDoItem toDoItem)
        {
            _toDoItemModel = toDoItem;
        }

        internal ToDoItem GetModel()
        {
            return _toDoItemModel; 
        }

        internal void SetModel(ToDoItem model)
        {
            _toDoItemModel = model;
        }

        internal static IEnumerable<ToDoItemViewModel> InitializeViewModels()
        {
            IEnumerable<ToDoItem> data = HttpManager.Instance.Execute<IEnumerable<ToDoItem>>(HttpAction.Read, null);
            
            if (data == null)
                return new List<ToDoItemViewModel>();
            else
                return data.Select(item => new ToDoItemViewModel(item));
        }
    }
}
