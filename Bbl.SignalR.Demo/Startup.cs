﻿using Owin;

namespace Bbl.SignalR.Demo
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy();
        }
    }
}