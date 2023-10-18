using SharedModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinClientApp.ViewModel
{
    internal class ToDoItemViewModel
    {
        private ToDoItem _toDoItemModel;

        public int Priority 
        {
            get => _toDoItemModel.VisualOrder;
            set => _toDoItemModel.VisualOrder = value;
        }
        public string Name 
        {
            get => _toDoItemModel.Name;
            set => _toDoItemModel.Name = value;
        }
        public string? Description 
        {
            get => _toDoItemModel.Description;
            set => _toDoItemModel.Description = value;
        }

        internal ToDoItemViewModel(ToDoItem toDoItem)
        {
            _toDoItemModel = toDoItem;
        }



    }
}
