using System;
using System.Collections.Generic;
using System.Linq;
using LinqData;

namespace LinqDemos
{
	public class OrderByDemo : DemoBase
	{
		public override void Run()
		{
			var data = new MfStoreDataBuilder().BuildMfData().Data;

			var paymentList = data.Payments
				.OrderBy(p => p.Amount)
				.ThenByDescending(p => p.PaymentId)
				.ThenBy(p => p.CreatedDate);

			ShowData(paymentList);
		}
	}
}
