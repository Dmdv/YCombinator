using System;
using System.Collections.Generic;
using System.Linq;

namespace YCombinator
{
	class Ninth
	{
		public static void Run()
		{
			Console.WriteLine("Ninth");

			var fact = Y<int, int>(g => n =>
				{
					if (n < 2) return 1;
					return n * g(n - 1);
				});

			Console.WriteLine(fact(10));

			var fact2 = Y<int, int>(Fact.Run);

			Console.WriteLine(fact2(10));
		}

		private static Func<T, TR> Y<T, TR>(Func<Func<T, TR>, Func<T, TR>> h)
		{
			SelfDelegate<Func<T, TR>> t = b => h(n => b(b)(n));
			return t(t);
		}

		private static Func<T, TR> Y<T, TR>(Func<Func<T, TR>, T, TR> h)
		{
			SelfDelegate<Func<T, TR>> t = b => n => h(b(b), n); 
			return t(t);
		}
	}
}
