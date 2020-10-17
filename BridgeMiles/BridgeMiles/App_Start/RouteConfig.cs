using System.Web.Mvc;
using System.Web.Routing;

namespace BridgeMiles.Feature.Reports
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "StudentsReports/{controller}/{action}/{id}",
                defaults: new { controller = "StudentsReports", action = "StudentsAttendance", id = UrlParameter.Optional }
            );
        }
    }
}
