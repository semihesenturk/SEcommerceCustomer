using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEcommerce.Customer.Business.Abstract
{
    public interface ICustomerService
    {
        List<Entites.Concrete.Customer> GetCustomers();
    }
}
