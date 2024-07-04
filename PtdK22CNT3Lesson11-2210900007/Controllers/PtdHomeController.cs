using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PtdK22CNT3Lesson11_2210900007.Controllers
{
    public class PtdHomeController : Controller
    {
        public ActionResult PtdIndex()
        {
            return View();
        }

        public ActionResult PtdAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult PtdContact()
        {
            ViewBag.msv = "2210900007";
            ViewBag.fullname = "Pham Thanh Dat";

            return View();
        }
    }
}