using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MvcApplication1.Models
{
    public class PaymentViewModel
    {
        [Required(ErrorMessage="You must select a payment method.")]
        public int SelectedPaymentMethod
        {
            get;
            set;
        }

        public IList<PaymentMethod> PaymentMethods
        {
            get
            {
                if (paymentMethods == null)
                {
                    paymentMethods = new List<PaymentMethod>
                {   
                    new PaymentMethod{Id=1, Name="Visa"}, 
                    new PaymentMethod{Id=2, Name="Master"}, 
                    new PaymentMethod{Id=3, Name="Amex"}, 
                    new PaymentMethod{Id=4, Name="Discover"}, 
                    new PaymentMethod{Id=5, Name="Diner's Club"}   };
                }

                return paymentMethods;
            }

            set
            {
                paymentMethods = value;
            }
        }

        private IList<PaymentMethod> paymentMethods;

        public Address Address
        {
            get
            {
                return new Address
                {
                    Line1 = "1234 Elm St.",
                    Line2 = "APT 5",
                    City = "Urbana",
                    State = "MD",
                    Zip = "20899"
                };
            }
        }
    }

    public class PaymentMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Selected { get; set; }
    }
}
