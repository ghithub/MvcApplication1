using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public PartialViewResult GetAddress()
        {
            Address a = new Address { Line1 = "123 4th Ave SW", Line2="APT 202", City = "Washington", State="DC", Zip="20028" };
            return PartialView(@"~/Views/Shared/_Address.cshtml", a);
        }
    }
}
