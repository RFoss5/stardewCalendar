using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stardewCalendar
{
	internal class regrowableCrop : Crop
	{
		public virtual int RegrowTime { get; set; }

		public regrowableCrop(int regrowTime, string name, int sellPrice, int count, int growthTime, Program.season season):base(name, sellPrice, count, growthTime, season){
			this.RegrowTime = regrowTime;
		}
	}
}
