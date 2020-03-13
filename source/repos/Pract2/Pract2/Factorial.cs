using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract2
{
	class Factorial
	{
		static int Sum = 0;
		public static int FindFactorial(int Elem)
		{
			if (Elem == 0)
			{
				Sum += 1;
				return Sum;
			}
			else
			{
				Sum = Elem * FindFactorial(Elem - 1);
				return Sum;
			}
		}
	}
}
