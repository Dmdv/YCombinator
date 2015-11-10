using System;
using System.Collections.Generic;
using System.Linq;

namespace YCombinator
{
	class Seventh
	{
		public static void Run()
		{
			Console.WriteLine("Seventh");

			Func<Func<Func<int, int>, Func<int, int>>, Func<int, int>> y =
				h => ((SelfDelegate<Func<int, int>>)(f => f(f)))(b => h(n => b(b)(n)));

			var fact = y(g => n =>
					{
						if (n < 2) return 1;
						return n * g(n - 1);
					});

			Console.WriteLine(fact(10));
		}
	}
}
