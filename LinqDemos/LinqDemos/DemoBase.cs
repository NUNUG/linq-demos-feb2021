using LinqData;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinqDemos
{
	public abstract class DemoBase : IDemo
	{
		public void ShowData<T>(IEnumerable<T> data)
		{
			foreach (T item in data)
				Console.WriteLine($"\t{item}");
		}

		public abstract void Run();
	}
}