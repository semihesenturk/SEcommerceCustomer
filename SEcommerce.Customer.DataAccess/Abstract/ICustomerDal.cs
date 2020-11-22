using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEcommerce.Customer.Entites.Concrete;

namespace SEcommerce.Customer.DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Entites.Concrete.Customer>
    {
    }
}
