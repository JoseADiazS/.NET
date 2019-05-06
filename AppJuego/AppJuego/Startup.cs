using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartup(typeof(AppJuego.signalr.Startup))]
namespace AppJuego.signalr
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}