using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class FinAidRegController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            FinAidRegViewModel fagvm = new FinAidRegViewModel();
            return View(fagvm);
        }

        [HttpPost]
        public ActionResult Index(FinAidRegViewModel viewModel)
        {
            if (ModelState.IsValid)
            {

            }

            return View(viewModel);
        }
    }
}
