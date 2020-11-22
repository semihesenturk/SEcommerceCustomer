using SEcommerce.Customer.Business.Abstract;
using SEcommerce.Customer.DataAccess.Abstract;
using System.Collections.Generic;

namespace SEcommerce.Customer.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public List<Entites.Concrete.Customer> GetAll()
        {
            return _customerDal.GetAll();
        }
    }
}
