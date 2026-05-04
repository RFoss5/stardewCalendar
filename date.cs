using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stardewCalendar
{
	internal class date
	{
		public Program.season season;
		public int day;
		public Crop[] crops;

		public void addCrop(Crop crop){
			Array.Resize(ref crops, crops.Length + 1);
			crops[crops.Length-1] = crop;
		}
		public date(Program.season season, int day, Crop[] crops){
			this.season = season;
			this.day = day;
			this.crops = crops;
		}
	}
}
