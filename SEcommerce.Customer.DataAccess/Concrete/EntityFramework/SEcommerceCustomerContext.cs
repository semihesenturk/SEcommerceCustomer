using SEcommerce.Customer.Entites.Concrete;
using System.Data.Entity;

namespace SEcommerce.Customer.DataAccess.Concrete.EntityFramework
{
    public class SEcommerceCustomerContext : DbContext
    {
        public DbSet<Entites.Concrete.Customer> Customers { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SEcommerceCustomerContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
