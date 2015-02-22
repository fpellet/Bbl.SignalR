using Nancy;

namespace Bbl.SignalR.Demo
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters => View["index"];

            Get["/chat"] = parameters => View["chat"];
        }
    }
}