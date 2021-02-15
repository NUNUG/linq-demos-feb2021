using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqData.Models;

namespace LinqData
{
	public class MfStoreDataBuilder
	{
		public MfStore Data { get; }

		public MfStoreDataBuilder()
		{
			Data = new MfStore();
			Reset();
		}

		public void Reset()
		{
			Data.Orders.Clear();
			Data.Items.Clear();
			Data.OrderItems.Clear();
			Data.Payments.Clear();
		}

		public MfStoreDataBuilder BuildMfData()
		{
			Data.Orders.AddRange(new[] {
				new Order() {OrderId = 1, CreatedDate = new DateTime(2015, 02, 14), Total = 1.00 },
				new Order() {OrderId = 2, CreatedDate = new DateTime(2015, 01, 13), Total = 51.00 },
				new Order() {OrderId = 3, CreatedDate = new DateTime(2015, 09, 01), Total = 111.00 },
				new Order() {OrderId = 4, CreatedDate = new DateTime(2015, 09, 01), Total = 222.00 },
				new Order() {OrderId = 5, CreatedDate = new DateTime(2015, 09, 1), Total = 9.00 }
			});

			Data.Payments.AddRange(new[] {
				new Payment() { PaymentId = 1, OrderId = 3, Amount = 41.0, CreatedDate = DateTime.Now },
				new Payment() { PaymentId = 2, OrderId = 3, Amount = 10.0, CreatedDate = DateTime.Now },
				new Payment() { PaymentId = 3, OrderId = 4, Amount = 50.0, CreatedDate = DateTime.Now },
				new Payment() { PaymentId = 4, OrderId = 5, Amount = 100.0, CreatedDate = DateTime.Now },
				new Payment() { PaymentId = 5, OrderId = 5, Amount = 100.0, CreatedDate = DateTime.Now },
				new Payment() { PaymentId = 6, OrderId = 6, Amount = 9.0, CreatedDate = DateTime.Now }
			});

			Data.Items.AddRange(new[] {
				new Item() {ItemId = 1, Name = "Widget1", Cost = 1.0 },
				new Item() {ItemId = 2, Name = "Widget2", Cost = 5.0 },
				new Item() {ItemId = 3, Name = "Widget3", Cost = 11.0 },
				new Item() {ItemId = 4, Name = "Widget4", Cost = 41.0 },
				new Item() {ItemId = 5, Name = "Widget51", Cost = 111.0 }
			});

			Data.OrderItems.AddRange(new[] {
				new OrderItem() { OrderItemId = 1, OrderId = 2, ItemId = 1 },
				new OrderItem() { OrderItemId = 2, OrderId = 3, ItemId = 2 },
				new OrderItem() { OrderItemId = 3, OrderId = 3, ItemId = 2 },
				new OrderItem() { OrderItemId = 4, OrderId = 3, ItemId = 4 },
				new OrderItem() { OrderItemId = 5, OrderId = 4, ItemId = 5 },
				new OrderItem() { OrderItemId = 6, OrderId = 5, ItemId = 5 },
				new OrderItem() { OrderItemId = 7, OrderId = 5, ItemId = 5 },
				new OrderItem() { OrderItemId = 8, OrderId = 6, ItemId = 1 },
				new OrderItem() { OrderItemId = 9, OrderId = 6, ItemId = 1 },
				new OrderItem() { OrderItemId = 10, OrderId = 6, ItemId = 1 },
				new OrderItem() { OrderItemId = 11, OrderId = 6, ItemId = 1 },
				new OrderItem() { OrderItemId = 12, OrderId = 6, ItemId = 1 },
				new OrderItem() { OrderItemId = 13, OrderId = 6, ItemId = 1 },
				new OrderItem() { OrderItemId = 14, OrderId = 6, ItemId = 1 },
				new OrderItem() { OrderItemId = 15, OrderId = 6, ItemId = 1 },
				new OrderItem() { OrderItemId = 16, OrderId = 6, ItemId = 1 }
			});

			return this;
		}

		public MfStoreDataBuilder CreateOrder()
		{
			Data.Orders.Add(new Order() { OrderId = Data.Orders.Max(o => o.OrderId) + 1, Total = 0.0, CreatedDate = DateTime.Now });
			return this;
		}

		public MfStoreDataBuilder Createtem(string name, double cost)
		{
			Data.Items.Add(new Item()
			{
				ItemId = Data.Items.Max(i => i.ItemId) + 1,
				Name = name,
				Cost = cost
			});
			return this;
		}

		public MfStoreDataBuilder AddItemsToOrder(Order order, IEnumerable<Item> items)
		{
			foreach (Item item in items)
			{
				Data.OrderItems.Add(new OrderItem()
				{
					OrderItemId = Data.OrderItems.Max(oi => oi.OrderItemId) + 1,
					ItemId = item.ItemId,
					OrderId = order.OrderId
				});
			}
			return this;
		}

		public MfStoreDataBuilder AddPaymentToOrder(Order order, double amount)
		{
			Data.Payments.Add(new Payment()
			{
				PaymentId = Data.Payments.Max(p => p.PaymentId) + 1,
				OrderId = order.OrderId,
				CreatedDate = DateTime.Now,
				Amount = amount
			});
			return this;
		}
	}
}
