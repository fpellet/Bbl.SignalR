using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace Bbl.SignalR.Demo
{
    [HubName("mug")]
    public class MugHub : Hub
    {
        public void Move(int x, int y)
        {
            Clients.Others.moved(x, y);
        }
    }
}