using System;

namespace planets_experimental
{
	public class Race
	{
		public Race()
		{
			money = 10000;
			moneyIncome = 350;
			population = 100000;
			populationGrowth = 750;
			food = 200;
			foodIncome = 7;
			attackPower = 100;
			defencePower = 100;
		}
		
		public int money { get; set; }
		public int moneyIncome { get; set; }
		public int population { get; set; }
		public int populationGrowth { get; set; }
		public int food { get; set; }
		public int foodIncome { get; set; }
		public int attackPower { get; set; }
		public int defencePower { get; set; }
	}
	
	public class Terrain : Race
	{
		public Terrain()
		{
			moneyIncome = 250;
			populationGrowth = 1000;
			foodIncome = 5;
		}
	}
	public class Lunar : Race
	{
		public Lunar()
		{
			moneyIncome = 500;
			populationGrowth = 500;
			foodIncome = 5;
		}
	}
	public class Panyan : Race
	{
		public Panyan()
		{
			moneyIncome = 250;
			populationGrowth = 500;
			foodIncome = 10;
		}
	}
	
}
