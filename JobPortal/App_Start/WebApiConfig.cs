using System.Configuration;
using System.Web.Http;
using System.Web.Http.Cors;

namespace JobPortal
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var cors = new EnableCorsAttribute(ConfigurationManager.AppSettings["enableCorsUrl"], "*", "*");
            //var cors = new EnableCorsAttribute("http://localhost:3000,http://localhost:8000", "*", "*");
            // Web API routes
            config.MapHttpAttributeRoutes();
            config.EnableCors(cors);
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}