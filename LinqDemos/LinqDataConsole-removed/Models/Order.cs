using System;
using System.Collections.Generic;

#nullable disable

namespace LinqData.Models
{
	public partial class Order
	{
		public Order()
		{
			//OrderItems = new HashSet<OrderItem>();
			//Payments = new HashSet<Payment>();
		}

		public long OrderId { get; set; }
		public DateTime? CreatedDate { get; set; }
		public double? Total { get; set; }

		//public virtual ICollection<OrderItem> OrderItems { get; set; }
		//public virtual ICollection<Payment> Payments { get; set; }
	}
}
