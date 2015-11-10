using System;
using System.Collections.Generic;
using System.Linq;

namespace YCombinator
{
	delegate TR SelfDelegate<TR>(SelfDelegate<TR> self);
}
