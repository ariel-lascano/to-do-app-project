using SharedModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinClientApp.Managers
{
    internal class ItemsManager
    {
        private static ItemsManager _instance = null;
        internal static ItemsManager Instance 
        {
            get
            {
                if (_instance == null)
                    _instance = new ItemsManager();

                return _instance;
            }
        }



        private HttpManager HttpManager { get; }

        private ItemsManager()
        {
            HttpManager = new HttpManager();
        }

        internal IEnumerable<ToDoItem> GetAll()
        {
            return HttpManager.ExecuteGet();
        }

    }
}
