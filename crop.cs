using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace stardewCalendar
{
	internal class Crop : Item
	{
		Program.season season;

		public Crop(string name,int sellPrice,int count, Program.season season)
		{
			this.season = season;
			this.sellPrice = sellPrice;
			this.count = count;
			this.name = name;
		}
	}
}
