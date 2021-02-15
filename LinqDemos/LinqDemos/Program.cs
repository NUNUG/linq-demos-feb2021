using LinqData;
using System;

namespace LinqDemos
{
	class Program
	{
		static void Main(string[] args)
		{
			Program p = new Program();
			p.Execute();
		}

		private void Execute()
		{
			IDemo demo = null;

			// Uncomment any of the demos below to see how they work or to tinker with them.

			//demo = new ForeachDemo();
			//demo = new DeferredExecutionDemo();
			//demo = new SingleEnumerationDemo();
			//demo = new SelectDemo();
			//demo = new WhereDemo();
			//demo = new FirstSingleLastDemo();
			//demo = new AggregatesDemo();
			//demo = new AnonymousObjectsDemo();
			//demo = new ZipDemo();
			//demo = new SkipTakeDemo();
			//demo = new IntersectExceptUnionDemo();
			//demo = new DictionaryDemo();
			//demo = new SelectManyDemo();
			//demo = new JoinDemo();
			//demo = new GroupByDemo();
			//demo = new GroupJoinDemo();
			//demo = new AnyAllDemo();
			//demo = new OrderByDemo();

			demo.Run();
		}
	}
}
