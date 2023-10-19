using Microsoft.AspNetCore.SignalR.Client;
using System.Security.Principal;

namespace WinClientApp.Backend
{
    internal class ChannelIR
    {
        private HubConnection _hubConnection;
        private string _logOnName;

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

            _hubConnection.On<string>("ReceiveNotification", message =>
            {
                // Gestisci la notifica ricevuta dal server (es. aggiorna i dati dell'interfaccia utente).
                UpdateUI(message);
            });

            await _hubConnection.StartAsync();
        }

        private void UpdateUI(string identity)
        {
            if (identity == _logOnName)
                return;
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
