using LinqData;
using LinqData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqDemos
{
	public class WhereDemo : DemoBase
	{
		public override void Run()
		{
			var data = new MfStoreDataBuilder().BuildMfData().Data;

			var largeOrders = data.Orders
				.Where(order => order.Total >= 100.0);

			Console.WriteLine("All orders: ");
			ShowData(data.Orders);

			Console.WriteLine("Large orders: ");
			ShowData(largeOrders);
		}
	}
}
