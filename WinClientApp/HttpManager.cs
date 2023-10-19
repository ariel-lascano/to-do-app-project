﻿using System.Text;
using System.Text.Json;
using SharedModel;
using WinClientApp.Enums;
using WinClientApp.Properties;

namespace WinClientApp
{
    internal class HttpManager : IDisposable
    {
        private HttpClient _httpClient = new HttpClient();

        private static HttpManager _instance = null;
        internal static HttpManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HttpManager();
                return _instance;
            }
        }

        private HttpManager() { }

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

        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}