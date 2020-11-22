using System.Data.Entity;

namespace SEcommerce.Customer.DataAccess.Concrete.EntityFramework
{
    public class SEcommerceCustomerContext : DbContext
    {
        public DbSet<Entites.Concrete.Customer> Customers { get; set; }
    }
}
