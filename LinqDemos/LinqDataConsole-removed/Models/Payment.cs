using System;
using System.Collections.Generic;

#nullable disable

namespace LinqData.Models
{
	public partial class Payment
	{
		public long PaymentId { get; set; }
		public long? OrderId { get; set; }
		public double? Amount { get; set; }
		public DateTime? CreatedDate { get; set; }

		//public virtual Order Order { get; set; }
	}
}
