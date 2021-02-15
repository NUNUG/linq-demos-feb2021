using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace EFCoreLib1.Extensions
{
	public static class EntityExtensions
	{
		//private static string ObjectToString(this object entity)
		//{
		//	var t = entity.GetType();
		//	var props = t.GetProperties();
		//	var sb = new StringBuilder().Append("{ ");
		//	foreach (PropertyInfo p in props)
		//		sb.Append(p.Name)
		//			.Append(": ")
		//			.Append(p.GetValue(entity).ToString())
		//			.Append("; ");
		//	sb.Append("}");
		//	return sb.ToString();
		//}

		public static string ToString(this Item item)
		{
			return new StringBuilder()
				.Append("{ ")
				.Append("ItemId: ").Append(item.ItemId.ToString()).Append("; ")
				.Append("Name: ").Append(item.Name.ToString()).Append("; ")
				.Append("Cost: ").Append(item.Cost.ToString()).Append("; ")
				.Append("}")
				.ToString();
		}

		public static string ToString(this Order order)
		{
			return new StringBuilder()
				.Append("{ ")
				.Append("ItemId: ").Append(order.OrderId.ToString()).Append("; ")
				.Append("CreatedDate: ").Append(order.CreatedDate.ToString()).Append("; ")
				.Append("Total: ").Append(order.Total.ToString()).Append("; ")
				.Append("}")
				.ToString();
		}

		public static string ToString(this OrderItem orderItem)
		{
			return new StringBuilder()
				.Append("{ ")
				.Append("OrderItemId: ").Append(orderItem.OrderItemId.ToString()).Append("; ")
				.Append("OrderId: ").Append(orderItem.OrderId.ToString()).Append("; ")
				.Append("ItemId: ").Append(orderItem.ItemId.ToString()).Append("; ")
				.Append("}")
				.ToString();
		}

		public static string ToString(this Payment payment)
		{
			return new StringBuilder()
				.Append("{ ")
				.Append("PaymentId: ").Append(payment.PaymentId.ToString()).Append("; ")
				.Append("OrderId: ").Append(payment.OrderId.ToString()).Append("; ")
				.Append("Amount: ").Append(payment.Amount.ToString()).Append("; ")
				.Append("CreatedDate: ").Append(payment.CreatedDate.ToString()).Append("; ")
				.Append("}")
				.ToString();
		}
	}
}
