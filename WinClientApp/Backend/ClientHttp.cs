using System.Security.Principal;
using System.Text;
using System.Text.Json;
using SharedModel;
using WinClientApp.Enums;
using WinClientApp.Properties;

namespace WinClientApp.Backend
{
    internal class ClientHttp : IDisposable
    {
        private HttpClient _httpClient;

        internal ChannelIR ChannelIR { get; }
        internal string LogOnName { get; }

        internal ClientHttp() 
        {
            WindowsIdentity currentIdentity = WindowsIdentity.GetCurrent();
            LogOnName = currentIdentity.Name;

            _httpClient = new HttpClient();
            ChannelIR = new ChannelIR(LogOnName);
        }

        private void GetRequestData(HttpAction action, ToDoItem data, out HttpMethod method, out string uri, out string dataJson)
        {
            method = HttpMethod.Get;
            uri = string.Empty;
            dataJson = string.Empty;

            if (action == HttpAction.Create)
            {
                method = HttpMethod.Post;
                uri = Resources.BASE_URI;
                dataJson = JsonSerializer.Serialize(data);
            }
            else if (action == HttpAction.Read)
            {
                method = HttpMethod.Get;
                uri = Resources.BASE_URI;
            }
            else if (action == HttpAction.Update)
            {
                method = HttpMethod.Put;
                uri = string.Format(Resources.UPDATE_URI_FORMAT, data.ID);
                dataJson = JsonSerializer.Serialize(data);
            }
            else
            {
                method = HttpMethod.Delete;
                uri = string.Format(Resources.DELETE_URI_FORMAT, data.ID);
            }
        }

        internal bool Execute(HttpAction action, ToDoItem data)
        {
            if (!ChannelIR.IsConnected)
                return false;

            GetRequestData(action, data, out HttpMethod method, out string uri, out string dataJson);

            using (HttpRequestMessage request = new HttpRequestMessage(method, uri))
            {
                if (!string.IsNullOrWhiteSpace(dataJson))
                    request.Content = new StringContent(dataJson, Encoding.UTF8, Resources.JSON_MEDIA_TYPE);

                using (HttpResponseMessage reply = _httpClient.Send(request))
                    return reply.IsSuccessStatusCode;
            }
        }

        internal T Execute<T>(HttpAction action, ToDoItem data)
        {
            if (!ChannelIR.IsConnected)
                return default;

            GetRequestData(action, data, out HttpMethod method, out string uri, out string dataJson);

            using (HttpRequestMessage request = new HttpRequestMessage(method, uri))
            {
                if (!string.IsNullOrWhiteSpace(dataJson))
                    request.Content = new StringContent(dataJson, Encoding.UTF8, Resources.JSON_MEDIA_TYPE);

                using (HttpResponseMessage reply = _httpClient.Send(request))
                {
                    if (reply.IsSuccessStatusCode)
                    {
                        using (Stream stream = reply.Content.ReadAsStream())
                        {
                            using (StreamReader reader = new StreamReader(stream))
                            {
                                string replyContent = reader.ReadToEnd();
                                return JsonSerializer.Deserialize<T>(replyContent);
                            }
                        }
                    }
                }
            }
            return default;
        }

        internal void SendNotificationToServer()
        {
            if (ChannelIR.IsConnected)
                ChannelIR.SendNotificationToServer().Wait();
        }

        public void Dispose()
        {
            _httpClient.Dispose();
            ChannelIR.Dispose();
        }
    }
}