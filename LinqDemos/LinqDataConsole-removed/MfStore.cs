using System;
using System.Collections.Generic;
using System.Text;
using LinqData.Models; 

namespace LinqData
{
	public class MfStore
	{
		public List<Item> Items { get; }
		public List<Order> Orders { get; }
		public List<OrderItem> OrderItems { get; }
		public List<Payment> Payments { get; }

		public MfStore()
		{
			this.Items = new List<Item>();
			this.Orders = new List<Order>();
			this.OrderItems = new List<OrderItem>();
			this.Payments = new List<Payment>();
		}
	}
}
