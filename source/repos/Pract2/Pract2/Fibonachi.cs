using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pract2
{
	class Fibonachi
	{
		public static int FindElemInFibonachi(int n)
		{
			int number = n - 1; 
			int[] Array = new int[number + 1];
			Array[0] = 0;
			Array[1] = 1;
			for (int i = 2; i <= number; i++)
			{
				Array[i] = Array[i - 2] + Array[i - 1];
			}
			return Array[number];
		}
	}
}
