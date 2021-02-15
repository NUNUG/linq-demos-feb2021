using System;
using System.Collections.Generic;
using System.Linq;
using LinqData;

namespace LinqDemos
{
	public class DictionaryDemo : DemoBase
	{
		public override void Run()
		{
			var data = new MfStoreDataBuilder().BuildMfData().Data;

			// This will create a dictionary whose key is Order.OrderId and whose value is Order.  We can then look up orders by Id.
			var orderLookupTable = data.Orders.ToDictionary(
				// Selector function to extract a key from orders
				order => order.OrderId);

			Console.WriteLine("Order for Id 5:");
			Console.WriteLine($"\t{orderLookupTable[5]}");

			// This will create a dictionary whose key is the order and whose value is a collection of payments.
			var orderPaymentsTable = data.Orders.ToDictionary(
				// Selector function to extract a key from an order.  We can use the entire order object.
				order => order,
				// Selector function to extract a value from the order.
				order => data.Payments.Where(p => p.OrderId == order.OrderId).ToList());

			Console.WriteLine("Payments for order 3:");
			// Notice I use FIRST() instead of TAKE(1)... it returns a single element instead of an IEnumerable<T> with one element.
			ShowData(orderPaymentsTable[data.Orders.Skip(2).First()]);
			

		}
	}
}
