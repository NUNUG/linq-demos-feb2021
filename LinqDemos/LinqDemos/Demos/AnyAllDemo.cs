using LinqData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemos
{
	public class AnyAllDemo : DemoBase
	{
		public override void Run()
		{
			var data = new MfStoreDataBuilder().BuildMfData().Data;

			bool order1HasPayments = data.Payments.Any(p => p.OrderId == 1);
			bool order3HasPayments = data.Payments.Any(p => p.OrderId == 3);
			bool allPaymentsAreOnOrder2 = data.Payments.All(p => p.OrderId == 2);

			Console.WriteLine($"Order 1 has any payments: {order1HasPayments}");
			Console.WriteLine($"Order 3 has any payments: {order3HasPayments}");
			Console.WriteLine($"All payments are on order 2: {allPaymentsAreOnOrder2}");
		}
	}
}
