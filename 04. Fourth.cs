using System;
using System.Collections.Generic;
using System.Linq;

namespace YCombinator
{
	class Fourth
	{
		public static void Run()
		{
			Console.WriteLine("Fourth");

			SelfDelegate<Func<int, int>> recur = f => f(f);

			var fact = recur(f =>
			{
				Func<int, int> g = n => f(f)(n);

				return n =>
				{
					if (n < 2) return 1;
					return n * g(n - 1);
				};
			});

			Console.WriteLine(fact(10));
		}
	}
}
