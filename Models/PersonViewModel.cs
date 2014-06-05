using System.Collections.Generic;
namespace MvcApplication1.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        public string FullName { get {
            return FirstName + " " + LastName;
        } }
    }
}
