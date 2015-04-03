using System.Web.Http;

using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MyProject.Web.WebHost.Startup))]

namespace MyProject.Web.WebHost
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            config.MapHttpAttributeRoutes();

            app.UseWebApi(config);
        }
    }
}
