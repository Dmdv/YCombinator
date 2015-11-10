using System;
using System.Collections.Generic;
using System.Linq;

namespace YCombinator
{
	class Third
	{
		public static void Run()
		{
			Console.WriteLine("Third");

			SelfDelegate<Func<int, int>> recur = f => f(f);

			var fact = recur(f => n =>
				{
					if (n < 2) return 1;
					return n * f(f)(n - 1);
				}
			);

			Console.WriteLine(fact(10));
		}
	}
}
