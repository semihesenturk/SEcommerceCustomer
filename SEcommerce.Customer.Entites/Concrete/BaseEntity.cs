using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEcommerce.Customer.Entites.Concrete
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}

