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
	public virtual Program.season Season { get; set; }
	public virtual int growthTime { get; set; }

		public Crop(string name,int sellPrice,int count, int growthTime, Program.season season)
		{
			this.Season = season;
			this.sellPrice = sellPrice;
			this.count = count;
			this.name = name;
			this.growthTime = growthTime;
		}
	}
}
