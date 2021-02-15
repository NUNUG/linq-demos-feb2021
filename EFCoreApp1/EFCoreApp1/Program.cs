// To Build models and DbContext from the database, add these NuGet packages and then execute the scaffold command from the Package Manager Console in Visual Studio 2019.
// NuGet packages:
//     Microsoft.EntityFrameworkCore
//     Microsoft.EntityFrameworkCore.Tools
//     Microsoft.EntityFrameworkCore.Design
//     Microsoft.EntityFrameworkCore.Sqlite
//     Microsoft.EntityFrameworkCore.Sqlite.Core
//     Microsoft.EntityFrameworkCore.Sqlite.Design
// Scaffold command:
//     Scaffold - DbContext "DataSource=C:\Users\Phil\source\repos\presentations\linq\data\mfstore.db" Microsoft.EntityFrameworkCore.Sqlite

using EFCoreLib1;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using EFCoreLib1.Extensions;

namespace EFCoreApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Program p = new Program();
			p.Execute();
			Console.ReadLine();
		}

		private void Execute()
		{
			using var context = new MfStoreContext();

			// You can experiment with EF core, Linq and Query Syntax here!
			// Have a look at the EfCoreLib1's MfStoreContext to see what the database schema looks like.
			// You can also find the actual db file and its creation scripts are in the ../data directory.
			// You can view use the db file directly with a Sqlite3 client.  You an download one here:
			// https://www.sqlite.org/download.html
			var expression = context.Items
				.Where(item => item.ItemId % 2 == 0)
				.Select(item => EntityExtensions.ToString(item));
			
			
			var result = expression.ToListAsync().Result;
			result.ForEach(item => Console.WriteLine(item));
		}
	}
}
