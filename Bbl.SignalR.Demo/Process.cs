using System.Threading;
using Microsoft.AspNet.SignalR;

namespace Bbl.SignalR.Demo
{
    public class Process
    {
        public string Name { get; set; }

        public void Work()
        {
            var hub = GlobalHost.ConnectionManager.GetHubContext<WorkerHub>();

            for (var i = 0; i < 100; i++)
            {
                hub.Clients.All.SetProgress(i);
                Thread.Sleep(2000);
            }

            hub.Clients.All.Notify("End");
        }
    }
}