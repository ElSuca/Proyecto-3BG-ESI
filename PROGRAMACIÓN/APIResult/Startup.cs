using Owin;
using System.Web.Http;
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
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );
            appBuilder.UseWebApi(CONFIG);
            var appXmlType = CONFIG.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            CONFIG.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);
        }
    }
}
