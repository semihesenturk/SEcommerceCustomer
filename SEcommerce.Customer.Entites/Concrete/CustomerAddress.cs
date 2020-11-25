using SEcommerce.Customer.Entites.Abstract;
using System;

namespace SEcommerce.Customer.Entites.Concrete
{
    [Serializable]
    public class CustomerAddress : BaseEntity, IEntity
    {
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
    }
}
