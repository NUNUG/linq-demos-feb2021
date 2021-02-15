using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreLib1
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
            Payments = new HashSet<Payment>();
        }

        public long OrderId { get; set; }
        public double? CreatedDate { get; set; }
        public double? Total { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
