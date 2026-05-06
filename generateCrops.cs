using System;
namespace stardewCalendar{
	internal class generateCrops
	{
		public static Crop[] crops = new Crop[] {
		//spring
			new Crop("Blue Jazz", 50, 7, Program.season.spring),
			new Crop("Carrot", 35, 3, Program.season.spring),
			new Crop("Cauliflower", 175, 12, Program.season.spring),
			new Crop("Garlic", 60, 4, Program.season.spring),
			new Crop("Kale",110, 6, Program.season.spring),
			new Crop("Parsnip", 35, 4, Program.season.spring),
			new Crop("Potato", 80, 6, Program.season.spring),
			new Crop("Rhubarb", 220, 13, Program.season.spring),
			new Crop("Tulip", 30, 6, Program.season.spring),
			new Crop("Rice",30,6, Program.season.spring),

		//spring regrowable
			new Crop("Coffee Bean", 15, 10, Program.season.spring, 2),
			new Crop("Green Bean", 40, 10, Program.season.spring,3),
			new Crop("Strawberry", 120, 8, Program.season.spring,4),


		//summer
			new Crop("Melon", 250, 12, Program.season.summer),
			new Crop("Poppy", 140, 7, Program.season.summer),
			new Crop("Radish", 90, 6, Program.season.summer),
			new Crop("Red Cabbage", 260, 9, Program.season.summer),
			new Crop("Starfruit", 750, 13, Program.season.summer),
			new Crop("Summer Spangle", 90, 8, Program.season.summer),
			new Crop("Sunflower", 80, 8, Program.season.summer),
			new Crop("Wheat", 25, 4, Program.season.summer),

		//summer regrowable
			new Crop("Blueberry", 50, 13, Program.season.summer,4),
			new Crop("Coffee Bean", 15, 10, Program.season.summer,2),
			new Crop("Corn", 50, 14, Program.season.summer,4),
			new Crop("Hops", 25, 11, Program.season.summer,1),
			new Crop("Hot Pepper", 80, 5, Program.season.summer,3),
			new Crop("Summer Squash", 45, 6, Program.season.summer,3),
			new Crop("Tomato", 60, 11, Program.season.summer,4),


		//fall
			new Crop("Wheat", 25,  4, Program.season.summer),
			new Crop("Sunflower", 80, 8, Program.season.summer),
			new Crop("Amaranth", 150,  7, Program.season.fall),
			new Crop("Artichoke", 160,  8, Program.season.fall),
			new Crop("Beet", 100, 6, Program.season.fall),
			new Crop("Bok Choy", 80, 4, Program.season.fall),
			new Crop("Fairy Rose", 290, 12, Program.season.fall),
			new Crop("Pumpkin",320, 13, Program.season.fall),
			new Crop("Yam", 160, 10, Program.season.fall),
			new Crop("Sweet Gem Berry",3000, 24, Program.season.fall),


		//fall regrowable
			new Crop("Cranberries", 75, 7, Program.season.fall,5),
			new Crop("Corn", 50, 14, Program.season.fall,4),
			new Crop("Broccoli", 70, 8, Program.season.fall,4),
			new Crop("Eggplant", 60, 5, Program.season.fall,5),
			new Crop("Grape", 80, 10, Program.season.fall,3),



		//winter
			new Crop("Powdermelon", 60, 7, Program.season.winter),

		//any
			new Crop("Taro Root", 100, 7, Program.season.any),

		//any regrowable
			new Crop("Cactus Fruit", 75,  12, Program.season.any,3),
			new Crop("Pineapple", 300, 14, Program.season.any,7),
			new Crop("Ancient Fruit", 550, 28, Program.season.any,7)
		};
	}
}