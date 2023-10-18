using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using SharedModel;
using WinClientApp.Properties;

namespace WinClientApp.Managers
{
    internal class HttpManager : IDisposable
    {
        private HttpClient _httpClient;

        internal HttpManager()
        {
            _httpClient = new HttpClient();
        }

        internal async Task<bool> ExecuteCreate(int visualOrder, string name, string description)
        {
            ToDoItem newItem = new ToDoItem(visualOrder, name, description);
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync(Resources.BASE_URI, newItem);

            return response.IsSuccessStatusCode;
        }

        internal async Task<IEnumerable<ToDoItem>> ExecuteGet()
        {
            HttpResponseMessage response = await _httpClient.GetAsync(Resources.BASE_URI);
            if (response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<List<ToDoItem>>();

            return null;
        }

        internal async Task<IEnumerable<ToDoItem>> ExecuteUpdate(ToDoItem toDoItem)
        {
            string requestUri = string.Format(Resources.UPDATE_URI_FORMAT, toDoItem.ID);

            HttpResponseMessage response = await _httpClient.PutAsJsonAsync(requestUri, toDoItem);
            if (response.IsSuccessStatusCode)
            {
                return null;
            }
            return null;
        }

        internal async Task<IEnumerable<ToDoItem>> ExecuteDelete(int toDeleteItem)
        {
            string requestUri = string.Format(Resources.DELETE_URI_FORMAT, toDeleteItem);

            HttpResponseMessage response = await _httpClient.DeleteAsync(requestUri);
            if (response.IsSuccessStatusCode)
            {
                return null;
            }
            return null;
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}
