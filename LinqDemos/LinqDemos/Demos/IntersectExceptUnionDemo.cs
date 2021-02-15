using LinqData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemos
{
	public class IntersectExceptUnionDemo : DemoBase
	{
		public override void Run()
		{
			var data = new MfStoreDataBuilder().BuildMfData().Data;

			// Concat
			var duplicateOrders = data.Orders
				.Concat(data.Orders).ToList();
			Console.WriteLine("Concat: ");
			ShowData(duplicateOrders);

			// Distinct
			var distinctData = duplicateOrders
				.Distinct()
				.ToList();
			Console.WriteLine("Distinct data (based on duplicate data):");
			ShowData(distinctData);

			// Except
			var theFirstTwo = data.Orders.Take(2);
			var allButTheFirstTwo = data.Orders
				.Except(theFirstTwo)
				.ToList();
			Console.WriteLine("Except data (all but the frst two):");
			ShowData(allButTheFirstTwo);

			// Union
			var theFirstFour = duplicateOrders.Take(4);
			var theLastFour = duplicateOrders.Skip(data.Orders.Count() - 4).Take(4);
			var firstAndLastFour = theFirstFour
				.Union(theLastFour)
				.ToList();
			Console.WriteLine("Union (between first and last four in duplicate data):");
			ShowData(firstAndLastFour);

			// Intersect
			var itemsInCommon = theFirstFour
				.Intersect(theLastFour)
				.ToList();
			Console.WriteLine("Intersection (between first and last four):");
			ShowData(itemsInCommon);
		}
	}
}
