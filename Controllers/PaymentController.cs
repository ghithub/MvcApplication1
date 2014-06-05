using MvcApplication1.Models;
using System;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class PaymentController : Controller
    {
        public ActionResult Index()
        {
            PaymentViewModel model = new PaymentViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(PaymentViewModel model)
        {
            if (ModelState.IsValid)
            {

               
            }

            return View(model);
        }

        public ActionResult Add()
        {
            var model = new Fruit();
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Fruit fruit)
        {
            if (ModelState.IsValid)
            {
                //save fruit;

                return Json(new
                {
                    Message = "Fruit is saved."
                });
            }
            else
            {
                return Json(new
                {
                    Message = this.ConcatenateErrors()
                });
            }
        }
    }

    public static class ModelStateExtension
    {
        public static string ConcatenateErrors(this Controller controller)
        {
            StringBuilder concatenatedErrors = new StringBuilder("Errors\n");

            foreach (var key in controller.ModelState.Keys)
            {
                if (controller.ModelState[key].Errors.Count > 0)
                {
                    foreach (var modelError in controller.ModelState[key].Errors)
                    {
                        concatenatedErrors.Append(modelError.ErrorMessage);
                        concatenatedErrors.Append(Environment.NewLine);
                    }
                }
            }

            return concatenatedErrors.ToString();
        }
    }
}
