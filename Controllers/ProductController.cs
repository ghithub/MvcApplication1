using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers {
    public class ProductController : Controller {
        public ActionResult Add() {
            AddProductViewModel viewModel = new AddProductViewModel { SearchModel = new SearchModel() };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Add(AddProductViewModel viewModel, string productSelection)
        {
            if (viewModel.SearchModel != null)
            {
                if (ModelState.IsValid)
                {                    
                    viewModel = new AddProductViewModel(viewModel.SearchModel.Keywords, productSelection);
                }
            }
            else
            {
                if (ModelState.IsValid)
                {
                    if (productSelection == null)
                    {
                        ModelState.AddModelError("Products", "U must select one product");
                        return View(viewModel);
                    }
                }
                else
                {
                    if (productSelection != null)
                    {
                        foreach(var p in viewModel.AddProductModel.Products)
                        {
                            if (p.Id.ToString() == productSelection)
                            {
                                p.Selected = true;
                                break;
                            }
                        }
                    }
                }
            }

            return View(viewModel);
        }
    }
}
