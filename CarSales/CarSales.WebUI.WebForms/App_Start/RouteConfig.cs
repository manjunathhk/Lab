using Microsoft.AspNet.FriendlyUrls;
using System.Web.Routing;

namespace CarSales.WebUI.WebForms
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.EnableFriendlyUrls();
        }
    }
}
