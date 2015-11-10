using System;
using System.Collections.Generic;
using System.Linq;

namespace YCombinator
{
	class Fact
	{
		public static int Run(Func<int, int> next, int n)
		{
			if (n < 2) return 1;
			return n * next(n - 1);
		}
	}
}
