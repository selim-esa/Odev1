using System;
using System.Collections.Generic;

namespace Deneme.Models
{
    public partial class CustomerCustomerDemo
    {
        public string CustomerId { get; set; } = null!;
        public string CustomerTypeId { get; set; } = null!;

        public virtual CustomerDemographic CustomerType { get; set; } = null!;
    }
}
