using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace Bbl.SignalR.Demo
{
    public class ChatConnection : PersistentConnection
    {
        protected override Task OnConnected(IRequest request, string connectionId)
        {
            return Connection.Send(connectionId, "Welcome!");
        }

        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {
            if (data.StartsWith("echo:"))
            {
                return Connection.Send(connectionId, data);
            }

            return Connection.Broadcast(data);
        }
    }
}