using System.Threading;
using System.Threading.Tasks;
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

        public void DoWork2(Process process)
        {
            Clients.All.Notify("Start " + process.Name);

            Task.Run(() => process.Work());
        }
    }
}