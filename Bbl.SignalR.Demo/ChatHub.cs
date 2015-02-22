using Microsoft.AspNet.SignalR;

namespace Bbl.SignalR.Demo
{
    public class ChatHub : Hub
    {
        public void Send(string message)
        {
            Clients.All.newMessage(message);
        }

        public void Echo(string message)
        {
            Clients.Caller.newMessage(message);
        }
    }
}