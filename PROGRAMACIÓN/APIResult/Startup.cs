

using Owin;
using System.Web.Http;

namespace ApiResult
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

