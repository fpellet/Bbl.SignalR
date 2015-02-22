using System.Threading;
using Microsoft.AspNet.SignalR;

namespace Bbl.SignalR.Demo
{
    public class WorkerHub : Hub
    {
        public void DoWork(Process process)
        {
            Clients.All.Notify("Start " + process.Name + " by " + Clients.Caller.Name);

            for (int i = 0; i < 100; i++)
            {
                Clients.All.SetProgress(i);
                Thread.Sleep(2000);
            }

            Clients.All.Notify("End");
        }
    }
}