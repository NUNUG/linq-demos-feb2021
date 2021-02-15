using System;
using System.Collections.Generic;
using System.Linq;
using LinqData;

namespace LinqDemos
{
	public class GroupJoinDemo : DemoBase
	{
		public override void Run()
		{
			var data = new MfStoreDataBuilder().BuildMfData().Data;

			// ---- ---- ---- ---- ---- ---- ---- ---- 
			// GroupJoin looks complicated but it's not really.  It's just a little verbose.
			// GroupJoin is equivalent to a Left Outer Join in SQL.
			// ---- ---- ---- ---- ---- ---- ---- ---- 


			var groupData = data.Orders.GroupJoin(
				// Second collection
				data.Payments,
				// Outer key selector
				order => order.OrderId,
				// Inner key selector
				payment => payment.OrderId,
				// So far this looks like a .Join(), right?  But it's different.  We can have missing data on one side or the other.
				// Project the result.
				(order, paymentsForThisOrder) => new { Order = order, Payments = paymentsForThisOrder });

			// Now we have a list of anonymous objects which contain pairs that look something like this:
			// { Order: Order, Payments: IEnumerable<Payment> }
			// That's a 1 to many structure.  To make it a flat list of single pairs, we must follow up with a .SelectMany().
			// However, if the Payments member is an empty IEnumerable<Payment>, we will have errors in .SelectMany().
			// To fix that, we use Payments.DefaultIfEmpty().
			// This translates an empty collection to an IEnumerable<Payment> with one null element.
			// Then we can then join on that element.

			var flatRows = groupData.SelectMany(
				// Selector for the inner collection.  Don't forget the .DefaultIfEmpty()!
				x => x.Payments.DefaultIfEmpty(), 
				// Projection.  It takes the original object plus a single extracted element from the inner collection.  
				(x, p) => new { Order = x.Order, Payment = p });

			Console.WriteLine("Flattened rows: ");
			foreach (var row in flatRows)
				Console.WriteLine($"Order: {row.Order}, Payment: {row.Payment}");
		}
	}
}
