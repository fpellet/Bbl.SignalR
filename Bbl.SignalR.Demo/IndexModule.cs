using Nancy;

namespace Bbl.SignalR.Demo
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters => View["index"];

            Get["/demo/chat"] = parameters => View["chat"];
            Get["/demo/chatHub"] = parameters => View["chathub"];
            Get["/demo/mug"] = parameters => View["mug"];
            Get["/demo/worker"] = parameters => View["worker"];
        }
    }
}