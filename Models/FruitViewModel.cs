using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MvcApplication1.Models
{
    [CustomValidation(typeof(FruitValidator), "IsFruitValid")]
    public class FruitViewModel
    {
        public int[] SelectedFruits
        {
            get
            {
                return Fruits != null && Fruits.Count > 0
                ? Fruits.Where(f => f.Selected == true).Select(f => f.Id).ToArray()
                : new int[0];
            }
            set { }
        }

        public IList<Fruit> Fruits
        {
            get
            {
                if (fruits == null)
                {
                    fruits = new List<Fruit>
                {         
                    new Fruit{Id=1, Name="Apple", Selected = false}, 
                    new Fruit{Id=2, Name="Banana", Selected = false}, 
                    new Fruit{Id=3, Name="Cherry", Selected = false}, 
                    new Fruit{Id=4, Name="Durian", Selected = false}, 
                    new Fruit{Id=5, Name="Elderweiss Grape", Selected = false}   };
                }

                return fruits;
            }

            set
            {
                fruits = value;
            }
        }

        private IList<Fruit> fruits;
        
        public Fruit NewFruit { get; set; }
    }
    
    public class Fruit
    {
        public int Id { get; set; }

        [Display(Name="Fruit Name", Prompt="Enter Fruit Name", Description="Your fav fruit name")]
        [Required(ErrorMessage="Fruit name is required.")]
        public string Name { get; set; }
        public bool Selected { get; set; }
    }

    public class FruitValidator {
        public static ValidationResult IsFruitValid(FruitViewModel vm, ValidationContext context) {
            if (!vm.NewFruit.Name.Contains("Melon") || vm.SelectedFruits.Count() < 1) {
                return new ValidationResult("Fruit is not considered a melon.");
            }
            else {
                return ValidationResult.Success;
            }
        }
    }
}
