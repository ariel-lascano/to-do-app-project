using Microsoft.AspNetCore.SignalR.Client;

namespace WinClientApp.Backend
{
    internal class ChannelIR
    {
        private HubConnection _hubConnection;
        private string _logOnName;


        internal delegate void UpdateEvent(object sender, string from);
        internal event UpdateEvent OnClientUpdateEvent;

        internal bool IsConnected => _hubConnection.State == HubConnectionState.Connected;

        internal ChannelIR(string logOnName)
        {
            _logOnName = logOnName;
            StartConnection().Wait();
        }

        internal async Task StartConnection()
        {
            _hubConnection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5118/notificationHub")  // URL del tuo server SignalR
                .Build();

            _hubConnection.On<string>("ReceiveNotification", logOnName =>
            {
                // Gestisci la notifica ricevuta dal server (es. aggiorna i dati dell'interfaccia utente).
                Update(logOnName);
            });

            try
            {
                await _hubConnection.StartAsync();
            }
            catch 
            {
            }
        }

        private void Update(string from)
        {
            if (from == _logOnName)
                return;

            OnClientUpdateEvent.Invoke(this, from);
        }

        internal async Task SendNotificationToServer()
        {
            // Definisco oggetto di interscambio condiviso:
            // id preso da windows per discriminare la macchina su cui è avvenuta la modifica...
            // ricevo notifica...cosa faccio? 
            // 1) ricarico la datasource e refresho la ui
            // 2) da channelIR a UIControl ci arrivo con un evento?

            await _hubConnection.SendAsync("SendNotification", _logOnName);
        }

    }
}
