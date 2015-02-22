using Nancy;

namespace Bbl.SignalR.SharedWhiteboard.Server
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters => View["index"];
        }
    }
}