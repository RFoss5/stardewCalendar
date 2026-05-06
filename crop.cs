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

	public virtual int regrowTime { get; set; }

		public Crop(string name,int sellPrice, int growthTime, Program.season season, int regrowTime=0)
		{
			this.Season = season;
			this.sellPrice = sellPrice;
			this.name = name;
			this.growthTime = growthTime;
			this.regrowTime = regrowTime;
		}
	}
}
