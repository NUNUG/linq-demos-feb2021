using System;
using System.Collections.Generic;
using System.Linq;
using LinqData;

namespace LinqDemos
{
	public class AnonymousObjectsDemo : DemoBase
	{
		public override void Run()
		{
			var data = new MfStoreDataBuilder().BuildMfData().Data;

			var firstOrder = data.Orders.First(order => order.OrderId == 4);
			var firstPayment = data.Payments
				.First(p => p.OrderId == firstOrder.OrderId);

			// We can just put objects as properties into the anonymous object and the properties will take on the variable name.
			var anonymousObject = new { firstOrder, firstPayment };
			Console.WriteLine(anonymousObject.firstOrder.OrderId);
			Console.WriteLine(anonymousObject.firstPayment.PaymentId);

			// We can also explicitly specify the property name inline as we construct them.
			var explicitAnonymousObject = new { Order = firstOrder, Payment = firstPayment };
			Console.WriteLine(explicitAnonymousObject.Order.OrderId);
			Console.WriteLine(explicitAnonymousObject.Payment.PaymentId);
		}
	}
}
