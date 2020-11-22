using SEcommerce.Customer.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEcommerce.Customer.Entites.Concrete
{
    public class Customer : IEntity
    {
        public string CustomerFirstName { get; set; }
        public string CustomerLastName{ get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPassword { get; set; }
        public bool CustomerIsEmployee { get; set; }
    }
}
