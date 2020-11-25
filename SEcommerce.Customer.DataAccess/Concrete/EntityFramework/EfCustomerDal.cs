using SEcommerce.Customer.DataAccess.Abstract;
namespace SEcommerce.Customer.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer.Entites.Concrete.Customer, SEcommerceCustomerContext>, ICustomerDal
    {

    }
}
