using System;
using System.Collections.Generic;
using System.Text;

#nullable disable

namespace LinqData.Models
{
	public partial class OrderItem
	{
		public long OrderItemId { get; set; }
		public long? OrderId { get; set; }
		public long? ItemId { get; set; }

		public override string ToString()
		{
			return new StringBuilder()
				.Append("{ ")
				.Append("OrderItemId: ").Append(OrderItemId.ToString()).Append("; ")
				.Append("OrderId: ").Append(OrderId.ToString()).Append("; ")
				.Append("ItemId: ").Append(ItemId.ToString()).Append("; ")
				.Append("}")
				.ToString();
		}
	}
}
