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

        internal IEnumerable<ToDoItem> ExecuteGet()
        {
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, Resources.BASE_URI);
            HttpResponseMessage httpResponse = _httpClient.Send(httpRequestMessage);

            if (httpResponse.IsSuccessStatusCode)
                return httpResponse.Content.ReadFromJsonAsync<IEnumerable<ToDoItem>>().Result;
            
            return new List<ToDoItem>();
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
