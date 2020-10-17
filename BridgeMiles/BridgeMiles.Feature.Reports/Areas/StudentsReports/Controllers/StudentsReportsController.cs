using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BridgeMiles.Feature.Reports.Areas.StudentsReports.Controllers
{
    public class StudentsReportsController : Controller
    {
        // GET: StudentsReports/StudentsReports
        public ActionResult StudentsAttendance()
        {
            return View();
        }
    }
}