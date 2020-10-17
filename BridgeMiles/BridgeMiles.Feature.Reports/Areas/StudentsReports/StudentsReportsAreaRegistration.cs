using System.Web.Mvc;

namespace BridgeMiles.Feature.Reports.Areas.StudentsReports
{
    public class StudentsReportsAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "StudentsReports";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "StudentsReports_default",
                "StudentsReports/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}