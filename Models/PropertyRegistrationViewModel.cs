using System.ComponentModel.DataAnnotations;

namespace MvcApplication1.Models
{
    public class PropertyRegistrationViewModel
    {
        public PropertyRegistrationViewModel()
        {

        }

        public Property Property { get; set; }
        public Agent Agent { get; set; }
    }

    public class Property
    {
        public int HouseNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        //[Required(ErrorMessage="You must enter the price.")]
        [Range(1000, 10000000, ErrorMessage="Bad price.")]
        public int? Price { get; set; }
    }

    public class Agent
    {
        [Required(ErrorMessage="First Name is required.")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage="You must enter your annual sales.")]
        [Range(10000, 5000000, ErrorMessage="Bad range.")]
        public int AnnualSales { get; set; }

        public Address Address { get; set; }
    }
}
