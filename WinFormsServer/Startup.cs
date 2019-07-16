using Owin;
using Microsoft.Owin.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsServer
{
    class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //CORS need to be enabled for calling SignalR service 
            app.UseCors(CorsOptions.AllowAll);
            //Find and reigster SignalR hubs
            app.MapSignalR();
        }
    }
}
