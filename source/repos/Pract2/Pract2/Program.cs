using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Factorial 3 = " + Factorial.FindFactorial(3));

			Console.WriteLine("Fibonachi 8n in sequence = " + Fibonachi.FindElemInFibonachi(8));

			Arrays arrays = new Arrays(20);

			Console.WriteLine();

			List<ShopsPhone> ListShopsPhones = new List<ShopsPhone>();

			ShopsPhone[] ArrayShopsPhone = new ShopsPhone[10];
			ArrayShopsPhone[0] = new ShopsPhone( Phone.IPhone, Shops.Comfy);
			ArrayShopsPhone[1] = new ShopsPhone(Phone.Meizu, Shops.Foxtrot);
			ArrayShopsPhone[2] = new ShopsPhone(Phone.Nokia, Shops.Foxtrot);
			ArrayShopsPhone[3] = new ShopsPhone(Phone.Xiaomi, Shops.Allo);
			ArrayShopsPhone[4] = new ShopsPhone(Phone.Samsung, Shops.Foxtrot);
			ArrayShopsPhone[5] = new ShopsPhone(Phone.Samsung, Shops.Comfy);
			ArrayShopsPhone[6] = new ShopsPhone(Phone.IPhone, Shops.Comfy);
			ArrayShopsPhone[7] = new ShopsPhone(Phone.Samsung, Shops.Comfy);
			ArrayShopsPhone[8] = new ShopsPhone(Phone.IPhone, Shops.Allo);
			ArrayShopsPhone[9] = new ShopsPhone(Phone.Meizu, Shops.Comfy);

			for (int i = 0;i < ArrayShopsPhone.Count();i++)
			{
				ListShopsPhones.Add(ArrayShopsPhone[i]);
			}

			var LinqShop = ListShopsPhones.Where(l => l.modelShops == Shops.Comfy).OrderByDescending(sort => sort.modelPhone);
			var LinqPhone = ListShopsPhones.Where(ph => ph.modelPhone == Phone.Samsung).OrderByDescending(sort => sort.modelShops);

			foreach (var item in LinqShop)
			{
				Console.WriteLine(item.modelPhone + " " + item.modelShops);
			}
			Console.WriteLine();
			foreach (var item in LinqPhone)
			{
				Console.WriteLine(item.modelPhone + " " + item.modelShops);
			}


			Console.Read();
		}
	}
}
