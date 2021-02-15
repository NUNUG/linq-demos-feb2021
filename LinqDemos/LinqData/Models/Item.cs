using System;
using System.Collections.Generic;
using System.Text;

#nullable disable

namespace LinqData.Models
{
	public partial class Item
	{
		public long ItemId { get; set; }
		public string Name { get; set; }
		public double? Cost { get; set; }

		public override string ToString()
		{
			return new StringBuilder()
				.Append("{ ")
				.Append("ItemId: ").Append(ItemId.ToString()).Append("; ")
				.Append("Name: ").Append(Name.ToString()).Append("; ")
				.Append("Cost: ").Append(Cost.ToString()).Append("; ")
				.Append("}")
				.ToString();
		}
	}
}
