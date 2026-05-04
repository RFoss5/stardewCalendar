using System;
namespace stardewCalendar{
	internal class generateCrops
	{
		public static Crop[] crops = new Crop[] {
		//spring
			new Crop("Blue Jazz", 50, 0, 7, Program.season.spring),
			new Crop("Carrot", 35, 0, 3, Program.season.spring),
			new Crop("Cauliflower", 175, 0, 12, Program.season.spring),
			new Crop("Garlic", 60, 0, 4, Program.season.spring),
			new Crop("Kale",110, 0, 6, Program.season.spring),
			new Crop("Parsnip", 35, 0, 4, Program.season.spring),
			new Crop("Potato", 80, 0, 6, Program.season.spring),
			new Crop("Rhubarb", 220, 0, 13, Program.season.spring),
			new Crop("Tulip", 30, 0, 6, Program.season.spring),
			new Crop("Rice",30,0, 6, Program.season.spring),

		//spring regrowable
			new regrowableCrop(2, "Coffee Bean", 15, 0, 10, Program.season.spring),
			new regrowableCrop(3, "Green Bean", 40, 0, 10, Program.season.spring),
			new regrowableCrop(4, "Strawberry", 120, 0, 8, Program.season.spring),


		//summer
			new Crop("Melon", 250, 0, 12, Program.season.summer),
			new Crop("Poppy", 140, 0, 7, Program.season.summer),
			new Crop("Radish", 90, 0, 6, Program.season.summer),
			new Crop("Red Cabbage", 260, 0, 9, Program.season.summer),
			new Crop("Starfruit", 750, 0, 13, Program.season.summer),
			new Crop("Summer Spangle", 90, 0, 8, Program.season.summer),
			new Crop("Sunflower", 80, 0, 8, Program.season.summer),
			new Crop("Wheat", 25, 0, 4, Program.season.summer),

		//summer regrowable
			new regrowableCrop(4, "Blueberry", 50, 0, 13, Program.season.summer),
			new regrowableCrop(2, "Coffee Bean", 15, 0, 10, Program.season.summer),
			new regrowableCrop(4,"Corn", 50, 0, 14, Program.season.summer),
			new regrowableCrop(1, "Hops", 25, 0, 11, Program.season.summer),
			new regrowableCrop(3, "Hot Pepper", 80, 0, 5, Program.season.summer),
			new regrowableCrop(3, "Summer Squash", 45, 0, 6, Program.season.summer),
			new regrowableCrop(4, "Tomato", 60, 0, 11, Program.season.summer),


		//fall
			new Crop("Wheat", 25, 0, 4, Program.season.summer),
			new Crop("Sunflower", 80, 0, 8, Program.season.summer),
			new Crop("Amaranth", 150, 0, 7, Program.season.fall),
			new Crop("Artichoke", 160, 0, 8, Program.season.fall),
			new Crop("Beet", 100, 0, 6, Program.season.fall),
			new Crop("Bok Choy", 80, 0, 4, Program.season.fall),
			new Crop("Fairy Rose", 290, 0, 12, Program.season.fall),
			new Crop("Pumpkin",320, 0, 13, Program.season.fall),
			new Crop("Yam", 160, 0, 10, Program.season.fall),
			new Crop("Sweet Gem Berry",3000, 0, 24, Program.season.fall),


		//fall regrowable
			new regrowableCrop(5, "Cranberries", 75, 0, 7, Program.season.fall),
			new regrowableCrop(4, "Corn", 50, 0, 14, Program.season.fall),
			new regrowableCrop(4, "Broccoli", 70, 0, 8, Program.season.fall),
			new regrowableCrop(5, "Eggplant", 60, 0, 5, Program.season.fall),
			new regrowableCrop(3, "Grape", 80, 0, 10, Program.season.fall),



		//winter
			new Crop("Powdermelon", 60, 0, 7, Program.season.winter),

		//any
			new Crop("Taro Root", 100, 0, 7, Program.season.any),

		//any regrowable
			new regrowableCrop(3, "Cactus Fruit", 75, 0, 12, Program.season.any),
			new regrowableCrop(7, "Pineapple", 300, 0, 14, Program.season.any),
			new regrowableCrop(7, "Ancient Fruit", 550, 0, 28, Program.season.any)
		};
	}
}