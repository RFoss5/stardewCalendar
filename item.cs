using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stardewCalendar
{
	abstract class Item
	{
		public virtual int sellPrice { get; set; }
		public virtual int count { get; set; }
		public virtual string name{ get; set; }
	}
}
