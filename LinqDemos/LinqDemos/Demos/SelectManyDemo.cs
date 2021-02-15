using System;
using System.Collections.Generic;
using System.Linq;
using LinqData;

namespace LinqDemos
{
	public class SelectManyDemo : DemoBase
	{
		public override void Run()
		{
			var data = new MfStoreDataBuilder().BuildMfData().Data;

			// SelectMany will flatten nested IEnumerables (a list of lists).
			// It takes a type of IEnumerable<IEnumerable<T>>.  It returns IEnumerable<T>.

			var outerList = new int[][] {
				new int[] { 1, 2, 3 },
				new int[] { 3, 4, 5 },
				new int[] { 5, 6, 7 }
			};

			Console.WriteLine("The nested (outer) list:");
			ShowData(outerList);

			Console.WriteLine("Inner list 0:");
			ShowData(outerList.First());
			Console.WriteLine("Inner list 1:");
			ShowData(outerList.Skip(1).First());
			Console.WriteLine("Inner list 2:");
			ShowData(outerList.Skip(2).First());

			var flattenedList = outerList.SelectMany(
				// This function takes an inner list and outputs a transformation of it.  We can just return it if we don't want a transformation.
				innerList => innerList);

			Console.WriteLine("The flattened list: ");
			ShowData(flattenedList);
		}
	}
}
