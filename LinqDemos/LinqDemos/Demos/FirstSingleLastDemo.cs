using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqDemos
{
	public class FirstSingleLastDemo : DemoBase
	{
		public override void Run()
		{
			List<int> emptyNumbersList = new List<int>();
			List<int> singleItemList = new List<int>() { 1 };
			List<int> numbersList = Enumerable.Range(0, 10).ToList();
			List<int> duplicateNumbersList = new List<int>(Enumerable.Range(0, 10).Concat(Enumerable.Range(0, 10)));

			// First, Single and Last can all be used as-is.
			Console.WriteLine($"First item  : {numbersList.First()}");
			Console.WriteLine($"Single item : {singleItemList.Single()}");
			Console.WriteLine($"Last item   : {numbersList.Last()}");

			// First, Single and Last can all be given a filter.
			Console.WriteLine($"First even item: {numbersList.First(n => n > 2)}");
			Console.WriteLine($"Single matching item: {numbersList.Single(n => n == 5)}");
			Console.WriteLine($"Last multiple of 3 item: {numbersList.Last(n => n % 3 == 0)}");

			// First, Single and Last all have an "...OrDefault" version for flexibility.
			Console.WriteLine($"First missing item: {numbersList.FirstOrDefault(n => n == 15)}");
			Console.WriteLine($"Single missing item: {numbersList.SingleOrDefault(n => n == 15)}");
			Console.WriteLine($"Last missing item: {numbersList.LastOrDefault(n => n == 15)}");

			// First, Single and Last will throw exceptions in situations that they can't handle, like empty sets.
			// This is often a useful feature when using .Single().
			try
			{
				var thereIsNotAFirstElement = emptyNumbersList.First();
			}
			catch (Exception ex)
			{
				Console.WriteLine($"When there are no elements, First() threw an exception: {ex.Message}");
			}

			try
			{
				var thereIsNotASingularElement = emptyNumbersList.Single();
			}
			catch (Exception ex)
			{
				Console.WriteLine($"When there are no elements, Single() threw an exception: {ex.Message}");
			}

			try
			{
				var thereAreMultipleElements = numbersList.Single();
			}
			catch (Exception ex)
			{
				Console.WriteLine($"When there are multiple elements, Single() threw an exception: {ex.Message}");
			}

			try
			{
				var thereIsNotALastElement = emptyNumbersList.Last();
			}
			catch (Exception ex)
			{
				Console.WriteLine($"When there are no elements, Last() threw an exception: {ex.Message}");
			}

			try
			{
				var thereAreMultipleMatchingElements = duplicateNumbersList.Single(n => n == 5);
			}
			catch (Exception ex)
			{
				Console.WriteLine($"When there are multiple elements matching the filter, Single() threw an exception: {ex.Message}");
			}

		}
	}
}
