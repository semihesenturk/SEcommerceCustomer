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

        Entites.Concrete.Customer GetCustomerById(int id);

        Entites.Concrete.Customer GetCustomerByEmail(string email);

        int SaveCustomer(Entites.Concrete.Customer customer);

        int UpdateCustomer(Entites.Concrete.Customer customer);

        int DeleteCustomer(Entites.Concrete.Customer customer);

    }
}
