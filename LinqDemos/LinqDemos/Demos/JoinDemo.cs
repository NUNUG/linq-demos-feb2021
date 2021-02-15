using System;
using System.Collections.Generic;
using System.Linq;
using LinqData;

namespace LinqDemos
{
	public class JoinDemo : DemoBase
	{
		public override void Run()
		{
			var data = new MfStoreDataBuilder().BuildMfData().Data;

			// Join.  This is like a SQL "Inner Join".
			// The output is flat and only includes objects which can be matched.
			var joinedData = data.Orders
				.Join(data.Payments,
					//Order selector.  Pick the part of the order to compare to a part of a payment.
					order => order.OrderId,
					// Payment selector.  Pick the part of the payment to compare to a part of the order.
					payment => payment.OrderId,
					// Projection.  This is the output of the join for each row.
					// You could create a class to hold parts of order and payment, but it's easy to use an anonymous object.
					(order, payment) => new { Order = order, Payment = payment});

			Console.WriteLine("Output");
			ShowData(joinedData.Select(x => $"Order: {x.Order}, Payment: {x.Payment}"));

			Console.WriteLine("Payments:");
			ShowData(data.Payments);

			Console.WriteLine("Orders: ");
			ShowData(data.Orders);
		}
	}
}
