using System;
using System.Collections.Generic;
using System.Linq;

namespace YCombinator
{
	class First
	{
		public static void Run()
		{
			Console.WriteLine("First");

			Func<int, int> fact = null;

			fact = n => {
				if (n < 2) return 1;
				return n * fact(n - 1);
			};

			Console.WriteLine(fact(10));
		}
	}
}
