using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LinqData;
using LinqData.Models;

namespace LinqDemos
{
	public class DeferredExecutionDemo : DemoBase
	{
		public IEnumerable<string> GetItemNames(IEnumerable<Item> items)
		{
			Console.WriteLine("1) GetItemNames() is executing.");
			foreach (Item item in items)
				yield return item.Name;
			Console.WriteLine("2) GetItemNames() is returning.");
		}

		public override void Run()
		{
			var data = new MfStoreDataBuilder().BuildMfData().Data;

			Console.WriteLine("A) Calling GetItemNames...");
			var itemNames = GetItemNames(data.Items);
			Console.WriteLine("B) Returned from GetItemNames call.");

			Console.WriteLine("C) Calling itemNames.ToString()...");
			var itemNamesList = itemNames.ToList();

			Console.WriteLine("D) Displaying itemNamesList.");
			ShowData(itemNamesList);

			Console.WriteLine("E) Done.");
		}
	}
}
