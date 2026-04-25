using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stardewCalendar
{
	internal static class Program
	{
		public enum season { spring, summer, fall, winter, any };

		[STAThread]
		static void Main()
		{
			StreamReader sr = new StreamReader("../../crops.txt");
			String line = sr.ReadLine();
			string n = "";
			string temp = "";
			int c = 0;
			int p = 0;
			int m = 0 ;
			season s;
			int i = 0;
			List<Crop> crops;
			while (line != null) { 
				Console.WriteLine(line);
				string[] splitter = line.Split(',');
				n = splitter[0];
				c = int.Parse(splitter[1]);
				p = int.Parse(splitter[2]);
				temp = splitter[3];
				switch(temp){
					case "spring":
						s = season.spring;
						break;
					case "summer":
						s = season.summer;
						break;
					case "fall":
						s = season.fall;
						break;
					case "winter":
						s = season.winter;
						break;
					default:
						s = season.any;
						break;
				}
				crops.Add(new Crop(n,p,c,s));
				Console.WriteLine(crops[i].count);
				i++;
				line = sr.ReadLine();
			}
			Console.WriteLine();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
