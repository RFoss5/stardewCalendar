using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stardewCalendar
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			List<Model> lt = new List<Model>(){};
			for(int i= 0; i < generateCrops.crops.Length; i++){
   				lt.Add(new Model() { name = generateCrops.crops[i].name, icon = Properties.Resources.ResourceManager.GetObject(generateCrops.crops[i].name) as Image });
			}
			cropChooser.Items.Clear();
			cropChooser.Items.AddRange(lt.Select(x => x.name).ToArray());
		}
		public class Model
		{
			public string name { get; set; }
			public Image icon { get; set; }
		}

		private void button1_Click(object sender, EventArgs e)
		{
			for(int i=0;i<generateCrops.crops.Length; i++)
			{
				if(generateCrops.crops[i].name == cropChooser.GetItemText(cropChooser.Text)){
					if ((generateCrops.crops[i].Season.ToString().ToLower() == seasonChooser.GetItemText(seasonChooser.Text).ToLower())||(generateCrops.crops[i].Season.ToString().ToLower()=="any"))
					{
						if((dateChooser.SelectedIndex + generateCrops.crops[i].growthTime) > 28)
						{
							bool nextSeason = false;
							int seasDay;
							for(int j=i+1;j<generateCrops.crops.Length;j++){
								switch (generateCrops.crops[i].Season.ToString().ToLower())
								{
									case "spring":
										if((generateCrops.crops[i].name==generateCrops.crops[j].name) &&(generateCrops.crops[j].Season==Program.season.summer)){
											seasDay = (dateChooser.SelectedIndex + (generateCrops.crops[i].growthTime - 28));
											addToCalendar(generateCrops.crops[i], (dateChooser.SelectedIndex + (generateCrops.crops[i].growthTime - 28)), Program.season.summer);
										}
										nextSeason = true;
										break;

									case "summer":
										if ((generateCrops.crops[i].name==generateCrops.crops[j].name) && (generateCrops.crops[j].Season == Program.season.fall)){
											seasDay = (dateChooser.SelectedIndex + (generateCrops.crops[i].growthTime - 28));
											addToCalendar(generateCrops.crops[i], seasDay, Program.season.fall);
										}
										nextSeason = true;
										break;

									case "fall":
										if ((generateCrops.crops[i].name==generateCrops.crops[j].name) && (generateCrops.crops[j].Season == Program.season.winter)){
											seasDay = (dateChooser.SelectedIndex + (generateCrops.crops[i].growthTime - 28));
											addToCalendar(generateCrops.crops[i],seasDay, Program.season.winter);
										}
										nextSeason = true;
										break;

									case "winter":
										if ((generateCrops.crops[i].name == generateCrops.crops[j].name) && (generateCrops.crops[j].Season == Program.season.spring)){
											seasDay = (dateChooser.SelectedIndex + (generateCrops.crops[i].growthTime - 28));
											addToCalendar(generateCrops.crops[i], seasDay, Program.season.spring);
										}
											nextSeason = true;
										break;
								}
							}
							if(!nextSeason)
								MessageBox.Show("This crop will not be ready to harvest during " + seasonChooser.GetItemText(seasonChooser.Text) + ".");
							return;

						}
						else{


						}
						addToCalendar(generateCrops.crops[i], dateChooser.SelectedIndex + generateCrops.crops[i].growthTime, generateCrops.crops[i].Season);
					}

					else{
					}
				}
			}
		}

		private void addToCalendar(Crop crop, int day, Program.season season){
			switch(season){
   				case Program.season.spring:
 					SCalendar.Spring[day+1].Add(crop);
					if(crop.regrowTime>0){
						while(day+crop.regrowTime<29){
							SCalendar.Spring[day+crop.regrowTime].Add(crop);
							day+=crop.regrowTime;
						}
					}
					break;
				case Program.season.summer:
					SCalendar.Summer[day+1].Add(crop);
					if (crop.regrowTime > 0)
					{
						while (day + crop.regrowTime < 29)
						{
							SCalendar.Summer[day + crop.regrowTime].Add(crop);
							day += crop.regrowTime;
						}
					}
					break;
				case Program.season.fall:
					SCalendar.Fall[day+1].Add(crop);
					if (crop.regrowTime > 0)
					{
						while (day + crop.regrowTime < 29)
						{
							SCalendar.Fall[day + crop.regrowTime].Add(crop);
							day += crop.regrowTime;
						}
					}
					break;
				case Program.season.winter:
					SCalendar.Winter[day+1].Add(crop);
					if (crop.regrowTime > 0)
					{
						while (day + crop.regrowTime < 29)
						{
							SCalendar.Winter[day + crop.regrowTime].Add(crop);
							day += crop.regrowTime;
						}
					}
					break;
			}
			if (crop.regrowTime == 0)
				MessageBox.Show(crop.name + " will be ready to harvest on day " + (day + 1) + " of " + season.ToString() + ".");
			else
				MessageBox.Show(crop.name + " will be ready to harvest on day " + (day) + " of " + season.ToString() + ".");

		}

		private void spr1_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Spring[1].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void spr2_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Spring[2].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}



		private void spr3_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Spring[3].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void spr4_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Spring[4].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void spr5_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Spring[5].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void spr6_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Spring[6].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void spr7_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Spring[7].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}
		private void spr8_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Spring[8].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void spr9_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Spring[9].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void spr10_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Spring[10].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void spr11_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Spring[11].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void spr12_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Spring[12].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void spr13_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Spring[13].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void spr14_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Spring[14].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void spr15_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Spring[15].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void spr16_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Spring[16].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void spr17_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Spring[17].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void spr18_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Spring[18].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void spr19_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Spring[19].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void spr20_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Spring[20].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void spr21_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Spring[21].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void spr22_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Spring[22].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void spr23_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Spring[23].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void spr24_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Spring[24].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void spr25_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Spring[25].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void spr26_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Spring[26].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void spr27_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Spring[27].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void spr28_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Spring[28].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void sum1_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Summer[1].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void sum2_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Summer[2].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void sum3_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Summer[3].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void sum4_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Summer[4].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void sum5_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Summer[5].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void sum6_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Summer[6].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void sum7_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Summer[7].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void sum8_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Summer[8].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void sum9_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Summer[9].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void sum10_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Summer[10].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void sum11_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Summer[11].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void sum12_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Summer[12].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void sum13_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Summer[13].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void sum14_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Summer[14].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void sum15_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Summer[15].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void sum16_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Summer[16].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void sum17_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Summer[17].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void sum18_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Summer[18].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void sum19_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Summer[19].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void sum20_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Summer[20].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void sum21_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Summer[21].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void sum22_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Summer[22].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void sum23_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Summer[23].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void sum24_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Summer[24].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void sum25_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Summer[25].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void sum26_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Summer[26].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void sum27_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Summer[27].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void sum28_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Summer[28].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void fall1_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Fall[1].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void fall2_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Fall[2].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void fall3_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Fall[3].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void fall4_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Fall[4].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void fall5_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Fall[5].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void fall6_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Fall[6].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void fall7_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Fall[7].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void fall8_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Fall[8].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void fall9_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Fall[9].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void fall10_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Fall[10].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void fall11_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Fall[11].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void fall12_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Fall[12].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void fall13_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Fall[13].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void fall14_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Fall[14].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void fall15_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Fall[15].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void fall16_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Fall[16].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void fall17_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Fall[17].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void fall18_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Fall[18].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void fall19_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Fall[19].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void fall20_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Fall[20].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void fall21_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Fall[21].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void fall22_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Fall[22].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void fall23_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Fall[23].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void fall24_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Fall[24].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void fall25_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Fall[25].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void fall26_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Fall[26].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void fall27_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Fall[27].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void fall28_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Fall[28].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void win1_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Winter[1].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void win2_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Winter[2].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void win3_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Winter[3].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void win4_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Winter[4].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void win5_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Winter[5].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void win6_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Winter[6].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void win7_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Winter[7].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void win8_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Winter[8].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void win9_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Winter[9].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void win10_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Winter[10].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void win11_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Winter[12].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void win12_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Winter[13].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void win13_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Winter[13].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void win14_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Winter[14].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void win15_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Winter[15].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void win16_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Winter[16].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void win17_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Winter[17].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void win18_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Winter[18].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void win19_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Winter[19].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void win20_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Winter[20].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void win21_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Winter[21].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void win22_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Winter[22].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void win23_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Winter[23].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void win24_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Winter[24].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void win25_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Winter[25].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void win26_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Winter[26].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void win27_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Winter[27].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}

		private void win28_Click(object sender, EventArgs e)
		{
			string total = " ";
			Crop[] SCSpring = SCalendar.Winter[28].ToArray();
			foreach (Crop crop in SCSpring)
			{
				total = total + crop.name + ", ";
				Console.WriteLine(total);
			}
			MessageBox.Show(total);
			display.Text = total;
		}
	}
}
