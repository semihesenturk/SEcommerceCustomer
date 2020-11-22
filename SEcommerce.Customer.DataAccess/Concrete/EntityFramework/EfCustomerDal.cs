using SEcommerce.Customer.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SEcommerce.Customer.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : ICustomerDal
    {
        public void Add(Entites.Concrete.Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Entites.Concrete.Customer entity)
        {
            throw new NotImplementedException();
        }

        public Entites.Concrete.Customer Get(Expression<Func<Entites.Concrete.Customer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Entites.Concrete.Customer> GetAll(Expression<Func<Entites.Concrete.Customer, bool>> filter = null)
        {
            using (SEcommerceCustomerContext context = new SEcommerceCustomerContext())
            {
                return context.Customers.ToList();
            }
        }

        public void Update(Entites.Concrete.Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
