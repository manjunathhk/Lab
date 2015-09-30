using System.Web.Http;

namespace CarSales.Web.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(name: "ControllerAndAction", routeTemplate: "api/{controller}/{action}/{name}");

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            config.Routes.MapHttpRoute(
            name: "ApiById",
            routeTemplate: "api/{controller}/{id}",
            defaults: new { id = RouteParameter.Optional },
            constraints: new { id = @"^[0-9]+$" }
        );

            config.Routes.MapHttpRoute(
                name: "ApiByName",
                routeTemplate: "api/{controller}/{action}/{name}",
                defaults: null,
                constraints: new { name = @"^[a-z]+$" }
            );

            config.Routes.MapHttpRoute(
                name: "ApiByAction",
                routeTemplate: "api/{controller}/{action}",
                defaults: new {action = "GetAll"});

            config.Routes.MapHttpRoute(
                name: "ApiForGetAction",
                routeTemplate: "api/{controller}/{action}",
                defaults: new { action = "Get" });

            //var json = config.Formatters.JsonFormatter;
            //json.SerializerSettings.Culture = new CultureInfo("en-US");
            //config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}
