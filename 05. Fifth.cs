using System;
using System.Collections.Generic;
using System.Linq;

namespace YCombinator
{
	class Fifth
	{
		public static void Run()
		{
			Console.WriteLine("Fifth");

			SelfDelegate<Func<int, int>> recur = f => f(f);

			Func<Func<Func<int, int>, Func<int, int>>, Func<int, int>> wrap = h => recur(f =>
				{
					Func<int, int> g = n => f(f)(n);
					return h(g);
				});

			var fact = wrap(g => n =>
				{
					if (n < 2) return 1;
					return n * g(n - 1);
				});

			Console.WriteLine(fact(10));
		}
	}
}
