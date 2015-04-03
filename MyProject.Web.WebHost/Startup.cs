using System;
using System.Threading.Tasks;
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
            HttpConfiguration config = new HttpConfiguration();

            config.MapHttpAttributeRoutes();

            /*
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            */

            app.UseWebApi(config);
        }
    }
}
