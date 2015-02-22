using Nancy;

namespace Bbl.SignalR.StockTicker
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters => View["index"];
        }
    }
}