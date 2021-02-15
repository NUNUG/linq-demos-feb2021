using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqData;
using LinqData.Models;

namespace LinqDemos
{
	public class SingleEnumerationDemo : DemoBase
	{
		public IEnumerable<string> GetItemNames(IEnumerable<Item> items)
		{
			Console.WriteLine("Enumerating /GetItemNames()/");
			foreach (Item item in items)
				yield return item.Name;
		}

		public override void Run()
		{
			var data = new MfStoreDataBuilder().BuildMfData().Data;

			var itemNames = GetItemNames(data.Items);

			// Process the collection twice.  What will happen?
			var upperNames = itemNames.Select(itemName => itemName.ToUpper());
			var lowerNames = itemNames.Select(itemName => itemName.ToLower());

			ShowData(upperNames);
			ShowData(lowerNames);
		}
	}
}
