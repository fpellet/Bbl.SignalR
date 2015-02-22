using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace Bbl.SignalR.SharedWhiteboard.Server
{
    public class DrawingBoard : Hub
    {
        public Task BroadcastPoint(int x, int y)
        {
            return Clients.Others.drawPoint(x, y, Clients.Caller.color);
        }
        public Task BroadcastClear()
        {
            return Clients.Others.clear();
        }
    }
}