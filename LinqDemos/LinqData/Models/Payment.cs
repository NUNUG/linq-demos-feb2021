using System;
using System.Collections.Generic;
using System.Text;

#nullable disable

namespace LinqData.Models
{
	public partial class Payment
	{
		public long PaymentId { get; set; }
		public long? OrderId { get; set; }
		public double? Amount { get; set; }
		public DateTime? CreatedDate { get; set; }

		public override string ToString()
		{
			return new StringBuilder()
				.Append("{ ")
				.Append("PaymentId: ").Append(PaymentId.ToString()).Append("; ")
				.Append("OrderId: ").Append(OrderId.ToString()).Append("; ")
				.Append("Amount: ").Append(Amount.ToString()).Append("; ")
				.Append("CreatedDate: ").Append(CreatedDate.ToString()).Append("; ")
				.Append("}")
				.ToString();

			}
		}
	}
