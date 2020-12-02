using SEcommerce.Customer.Business.Abstract;
using SEcommerce.Customer.DataAccess.Abstract;
using System;
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

        public List<Entites.Concrete.Customer> GetCustomers()
        {
            return _customerDal.GetAll();
        }

        public Entites.Concrete.Customer GetCustomerById(int id)
        {
            return _customerDal.Get(c => c.Id == id);
        }

        public Entites.Concrete.Customer GetCustomerByEmail(string email)
        {
            return _customerDal.Get(c => c.CustomerEmail == email);
        }

        public int SaveCustomer(Entites.Concrete.Customer customer)
        {
            var result = _customerDal.Add(customer);
            if (result > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int UpdateCustomer(Entites.Concrete.Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public int DeleteCustomer(Entites.Concrete.Customer customer)
        {
            throw new System.NotImplementedException();
        }
    }
}
