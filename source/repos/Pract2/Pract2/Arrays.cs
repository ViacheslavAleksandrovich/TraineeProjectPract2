using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract2
{
	class Arrays
	{
		int[] CurrentArray;
		Random random = new Random();
		public Arrays(int Lenth)
		{
			CurrentArray = new int[Lenth];
			for (int i = 0; i < CurrentArray.Length; i++)
			{
				CurrentArray[i] = random.Next(1, 100);
				Console.Write(CurrentArray[i] + " ");
			}
			Console.WriteLine();

			var even = CurrentArray.Where(CurrentArray => CurrentArray % 2 == 0);
			foreach (int item in even)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();

			var odd = CurrentArray.Where(CurrentArray => CurrentArray % 2 != 0);
			foreach (int item in odd)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();
		}


	}
}
