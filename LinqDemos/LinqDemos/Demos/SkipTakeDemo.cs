using LinqData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemos
{
	public class SkipTakeDemo : DemoBase
	{
		public override void Run()
		{
			var data = new MfStoreDataBuilder().BuildMfData().Data;

			var evenOrders = data.Orders.Where(order => order.OrderId % 2 == 0);
			var firstTwo = data.Orders.Take(2);
			var lastTwo = data.Orders.Skip(data.Orders.Count() - 2);
			var ThreeAndFour = data.Orders.Skip(2).Take(2);

			Console.WriteLine("First two:");
			ShowData(firstTwo);

			Console.WriteLine("Last two:");
			ShowData(lastTwo);

			Console.WriteLine("Third and Fourth:");
			ShowData(ThreeAndFour);
		}
	}
}
