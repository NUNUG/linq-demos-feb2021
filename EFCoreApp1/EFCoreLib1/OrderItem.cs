using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreLib1
{
    public partial class OrderItem
    {
        public long OrderItemId { get; set; }
        public long? OrderId { get; set; }
        public long? ItemId { get; set; }

        public virtual Item Item { get; set; }
        public virtual Order Order { get; set; }
    }
}
