﻿using SEcommerce.Customer.Entites.Abstract;

namespace SEcommerce.Customer.Entites.Concrete
{
    public class Customer : BaseEntity, IEntity
    {
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPassword { get; set; }
        public bool CustomerIsEmployee { get; set; }
    }
}
