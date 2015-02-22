using Owin;

namespace Bbl.SignalR.SharedWhiteboard.Server
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            app.UseNancy();
        }
    }
}