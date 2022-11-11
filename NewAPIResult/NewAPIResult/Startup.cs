using System;
using Owin;
using System.Web.Http;
using System.Net.Http;
using System.Linq;
    
namespace NewAPIResult
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            HttpConfiguration CONFIG = new HttpConfiguration();
            CONFIG.EnableCors();
            CONFIG.Routes.MapHttpRoute(
                name: "ApiResults",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );
            appBuilder.UseWebApi(CONFIG);

        }
    }
}
