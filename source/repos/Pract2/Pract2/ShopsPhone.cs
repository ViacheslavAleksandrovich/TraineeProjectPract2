using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract2
{
	class ShopsPhone
	{
		public Phone modelPhone { get; set; }
		public Shops modelShops { get; set; }

		public ShopsPhone(Phone modelPhone, Shops modelShops)
		{
			this.modelPhone = modelPhone;
			this.modelShops = modelShops;
		}
	}
}
