using LinqData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqDemos
{
	public class SelectDemo : DemoBase
	{
		public override void Run()
		{
			var data = new MfStoreDataBuilder().BuildMfData().Data;

			var namesOnly = data.Items
				.Select(item => item.Name);

			ShowData(namesOnly);
		}
	}
}
