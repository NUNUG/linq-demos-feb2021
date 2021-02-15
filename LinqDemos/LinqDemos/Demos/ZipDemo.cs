using System;
using System.Collections.Generic;
using System.Linq;
using LinqData;

namespace LinqDemos
{
	public class ZipDemo : DemoBase
	{
		public override void Run()
		{
			var data = new MfStoreDataBuilder().BuildMfData().Data;
			
			var orderItemCount = data.OrderItems.Count;
			var lineLabels = Enumerable.Range(1, orderItemCount).Select(i => $"Line #{i}");

			Console.WriteLine("Line labels: ");
			ShowData(lineLabels);

			Console.WriteLine("OrderItems: ");
			ShowData(data.OrderItems);

			var zippedData = lineLabels.Zip(
				data.OrderItems,
				(lineLabel, orderItem) => new { LineLabel = lineLabel, OrderItem = orderItem });

			Console.WriteLine("Zipped data:");
			foreach (var x in zippedData)
				Console.WriteLine($"\t {{ LineLabel: \"{x.LineLabel}\", OrderItem: {x.OrderItem} }}");
		}
	}
}
