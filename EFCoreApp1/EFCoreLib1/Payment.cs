using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreLib1
{
    public partial class Payment
    {
        public long PaymentId { get; set; }
        public long? OrderId { get; set; }
        public double? Amount { get; set; }
        public double? CreatedDate { get; set; }

        public virtual Order Order { get; set; }
    }
}
