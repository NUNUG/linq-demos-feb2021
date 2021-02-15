using LinqData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqDemos
{
	public class AggregatesDemo : DemoBase
	{
		public override void Run()
		{
			var data = new MfStoreDataBuilder().BuildMfData().Data;

			var numberOfOrders = data.Orders.Count();
			var numberOfLargeOrders = data.Orders.Count(order => order.Total >= 100);

			var largestOrder = data.Orders.Max(order => order.Total);
			var smallestOrder = data.Orders.Min(order => order.Total);
			var averageOrderTotal = data.Orders.Average(order => order.Total);
			var totalOfAllOrdersPutTogether = data.Orders.Sum(order => order.Total);
			var sumOfOrdersPaidInFull = data.Orders.Aggregate(
				// Starting value:
				0.0,
				// A function to modify the running value based on the current element in data.Orders.
				// Each order is passed to this function one at a time.
				(valueSoFar, currentOrder) =>
					{
						double totalOwed = currentOrder.Total ?? 0;
						double totalPaid = data.Payments.Where(p => p.OrderId == currentOrder.OrderId).Sum(p => p.Amount ?? 0.0);
						bool paidInFull = totalPaid >= totalOwed;
						if (paidInFull)
							return valueSoFar + totalOwed;
						else
							return valueSoFar;
					});


			Console.WriteLine($"Number of orders      : {numberOfOrders}");
			Console.WriteLine($"Number of large orders: {numberOfLargeOrders}");
			Console.WriteLine($"Largest order         : {largestOrder}");
			Console.WriteLine($"Smallest order        : {smallestOrder}");
			Console.WriteLine($"Average order total   : {averageOrderTotal}");
			Console.WriteLine($"Total of all orders put together          : {totalOfAllOrdersPutTogether}");
			Console.WriteLine($"Sum of orders which have been paid in full: {sumOfOrdersPaidInFull}");

		}
	}
}
