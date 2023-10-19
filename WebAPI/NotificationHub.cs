using Microsoft.AspNetCore.SignalR;

namespace WebAPI
{
    /// <summary>
    /// Called from a single client after data change from AppUI, 
    /// then this class propagate in broadcast a 'refresh request' for all other clients alive.
    /// </summary>
    public class NotificationHub : Hub
    {
        public async Task SendNotification(string message)
        {
            await Clients.All.SendAsync("ReceiveNotification", message);
        }
    }
}
