using System;

namespace planets_experimental
{
	public class sResearch
	{
		public int [] ID = {1, 2, 3, 4, 5, 6, 7, 8};
		public string [] nameEnglish = {"Destroyer, class 2", "Cruiser, class 3", "Destroyer, class 1", "Cruiser, class 2", "Battleship, class 3", "Cruiser, class 1", "Battleship, class 2", "Battleship, class 1"};
		public int [] turns = {4, 7, 10, 14, 17, 22, 27, 31};
		public int [] bonusArmor = {10, 15, 25, 40, 55, 70, 100};
		public int [] researchPrice = {1000, 1750, 3250, 4000, 7500, 9000, 14000, 21000};
		public bool [] researchEnded = {false, false, false, false, false, false, false};
	}
}
