using MvcApplication1.Models;
using System.Linq;
using System.Web.Mvc;

namespace MvcApplication1.Controllers {
    public class PeopleController : Controller
    {
        public ActionResult Index()
        {
            Person model = new Person();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(Person model)
        {
            if (ModelState.IsValid)
            {
               if (model.FirstName == "john")
               {
                   model.FirstName = "jon";
               }
            }
            
            return View(model);
        }

    }
}
