using System;
using System.Collections.Generic;

#nullable disable

namespace LinqData.Models
{
	public partial class Item
	{
		public Item()
		{
			//OrderItems = new HashSet<OrderItem>();
		}

		public long ItemId { get; set; }
		public string Name { get; set; }
		public double? Cost { get; set; }

		//public virtual ICollection<OrderItem> OrderItems { get; set; }
	}
}
