using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LinqData;

namespace LinqDemos
{
	public class GroupByDemo : DemoBase
	{
		public override void Run()
		{
			var data = new MfStoreDataBuilder().BuildMfData().Data;

			// ---- ---- ---- ---- ---- ---- ---- ---- 
			// NOTE:  Linq's GroupBy is probably NOT what you think it is.  It's not the same as the SQL Group-By.  It has little to do with aggregates by itself.
			// ---- ---- ---- ---- ---- ---- ---- ---- 

			var paymentsByOrder = data.Payments.GroupBy(
				// The key selector.  Use it to pick the part of the object to act as a non-unique key.
				// We use the order Id.  Now each grouping will represent a single order and will contain all the payments for that order inside it.
				payment => payment.OrderId);

			// Now paymentsByOrder is a list of IGrouping<>, and each IGrouping<> is an object which is an IEnumerable<T> but also has a KEY property.

			var numberOfGroupings = paymentsByOrder.Count();
			Console.WriteLine($"Number of groupings: {numberOfGroupings}");

			foreach (var grouping in paymentsByOrder)
			{
				// Display each grouping.  
				// Each grouping has two parts: Itself is an IEnumerable of payments, and it also has an additional property named Key.
				Console.WriteLine($"Group (Key = {grouping.Key})");
				ShowData(grouping);
			}
		}
	}
}
