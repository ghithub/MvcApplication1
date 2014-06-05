using MvcApplication1.Core;
using MvcApplication1.Models;
using System.Web.Mvc;

namespace MvcApplication1.Controllers {
    public class RegistrationController : Controller
    {
        public ActionResult Index() {
            PropertyRegistrationViewModel viewModel = new PropertyRegistrationViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(PropertyRegistrationViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                //save registration.
            }

            return View(viewModel);
        }
    }
}
