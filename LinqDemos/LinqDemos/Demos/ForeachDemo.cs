using System;
using System.Collections.Generic;
using System.Text;
using LinqData;

namespace LinqDemos
{
	public class ForeachDemo : DemoBase
	{
		public override void Run()
		{
			var data = new MfStoreDataBuilder().BuildMfData().Data;
			
			// .Foreach() is similar to foreach(var value in collection) { }, 
			// except it takes a function and operates on a List<T>.
			// It is NOT available for IEnumerable<T>.

			data.Orders.ForEach(
				order =>  Console.WriteLine(order.ToString())
			);
		}
	}
}
