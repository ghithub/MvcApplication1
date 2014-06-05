using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace MvcApplication1.Models
{
    public class AddProductViewModel
    {
        public AddProductViewModel()
        {

        }

        public AddProductViewModel(string keyword, string selectedProductId)
        {
            AddProductModel = new AddProductModel { SelectedProductId = selectedProductId };

            Product p1 = new Product { Id = 1, Name = "iPad", Description = "An apple product" };
            Product p2 = new Product { Id = 2, Name = "iPhone", Description = "Also an apple product" };
            Product p3 = new Product { Id = 3, Name = "iPod", Description = "Yet another apple product" };
            Product p4 = new Product { Id = 4, Name = "AppleTV", Description = "Still another apple product" };

            var productList = new List<Product> { p1, p2, p3, p4 };
            
            AddProductModel.Products = productList;
            AddProductModel.SetSelectedProduct();
        }

        public SearchModel SearchModel { get; set; }
        public AddProductModel AddProductModel { get; set; }

    }

    public class SearchModel
    {
        [Required]
        public string Keywords { get; set; }
    }

    public class AddProductModel
    {
        public IList<Product> Products { get; set; }

        [Required]
        public string SelectedProductId { get; set; }
        [Required]
        public string Notes { get; set; }

        public void SetSelectedProduct()
        {
            foreach(var p in Products)
            {
                if (p.Id.ToString() == SelectedProductId)
                {
                    p.Selected = true;
                }
            }
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }        
        public bool Selected {get; set; }
    }
}
