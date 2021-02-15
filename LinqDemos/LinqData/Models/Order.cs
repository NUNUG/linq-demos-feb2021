using System;
using System.Collections.Generic;
using System.Text;

#nullable disable

namespace LinqData.Models
{
	public partial class Order
	{
		public long OrderId { get; set; }
		public DateTime? CreatedDate { get; set; }
		public double? Total { get; set; }

		public override string ToString()
		{
			return new StringBuilder()
				.Append("{ ")
				.Append("OrderId: ").Append(OrderId.ToString()).Append("; ")
				.Append("CreatedDate: ").Append(CreatedDate.ToString()).Append("; ")
				.Append("Total: ").Append(Total.ToString()).Append("; ")
				.Append("}")
				.ToString();
		}
	}
}
