﻿using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CorvallisTransit.Startup))]
namespace CorvallisTransit
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            HubConfiguration configuration = new HubConfiguration();
            configuration.EnableDetailedErrors = true;
            configuration.EnableJavaScriptProxies = true;
            app.MapSignalR("/signalr", configuration);
        }
    }
}