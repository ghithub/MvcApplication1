using MvcApplication1.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class FruitController : Controller
    {
        public ActionResult Index()
        {
            FruitViewModel model = new FruitViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(FruitViewModel model)
        {
            if (ModelState.IsValid)
            {
            }

            return View(model);
        }

        public ActionResult Add() {
            Fruit model = new Fruit();
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Fruit model) {
            if (ModelState.IsValid) {
                //save fruit;

                return Json(new {
                    Message = "Fruit is saved."
                });
            }
            else {
                return Json(new {
                    Message = this.ConcatenateErrors()
                });
            }
        }
    }
}
