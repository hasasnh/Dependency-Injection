using System.Web.Mvc;
using System.Web.Routing;

namespace BridgeMiles
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            Feature.Reports.RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
