using System;
using System.Collections.Generic;
using System.Linq;

namespace YCombinator
{
	class Sixth
	{
		public static void Run()
		{
			Console.WriteLine("Sixth");

			SelfDelegate<Func<int, int>> recur = f => f(f);

			Func<Func<Func<int, int>, Func<int, int>>, Func<int, int>> wrap =
				h => recur(f => h(n => f(f)(n)));

			var fact = wrap(g => n =>
				{
					if (n < 2) return 1;
					return n * g(n - 1);
				});

			Console.WriteLine(fact(10));
		}
	}
}
