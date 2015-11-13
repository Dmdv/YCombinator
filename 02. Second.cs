using System;
using System.Collections.Generic;
using System.Linq;

namespace YCombinator
{
	class Second
	{
		public static void Run()
		{
			Console.WriteLine("Second");

			var fact = ((SelfDelegate<Func<int, int>>)(f => n =>
				{
					if (n < 2) return 1;
					return n * f(f)(n - 1);
				}))
				(f => n =>
				{
					if (n < 2) return 1;
					return n * f(f)(n - 1);
				});

			Console.WriteLine(fact(10));

			SelfDelegate<Func<int, int>> func2 = f => n =>
				{
					if (n < 2) return 1;
					return n * f(f)(n - 1);
				};

			var fact2 = func2(func2);

			Console.WriteLine(fact2(10));
		}
	}
}
