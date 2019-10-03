// Experimental version of Planets, v0.0.1ex
using System;

namespace planets_experimental
{
	class Program
	{
		public static void Main(string[] args)
		{
			int Language;
			Terrain terrain = new Terrain();
			Lunar lunar = new Lunar();
			Panyan panyan = new Panyan();
			Turn turn = new Turn();
			Choice choice = new Choice();
			English english = new English();
			
			Console.WriteLine("Choose language / Выберите язык");
			Console.WriteLine("1 - English / 2 - Русский");
			choice.Language = Convert.ToInt32(Console.ReadLine());
			if (choice.Language==1) {
				goto English;
			}
			else if (choice.Language==2) {
				Console.ReadKey(); // goto Russian;
			}
			else {
				Console.ReadKey();
			}

		English:
			Console.WriteLine(english.welcome);
			Console.WriteLine(english.welcome2);
			Console.WriteLine(english.welcome3);
			choice.RaceBeforeStart = Convert.ToInt32(Console.ReadLine());
			if (choice.RaceBeforeStart==1) {
				Console.WriteLine(terrain.infoEnglish);
				Console.WriteLine(terrain.infoEnglish2);
				Console.WriteLine(english.thisRace);
				choice.thatRace = Convert.ToInt32(Console.ReadLine());
				if (choice.thatRace==1) {
					Console.WriteLine("Your choice is " + terrain.nameEnglish + ". Now welcome to the game.");
					Console.ReadKey();
				}
				else {
					goto English;
				}
			}
			else if (choice.RaceBeforeStart==2) {
				Console.WriteLine(lunar.infoEnglish);
				Console.WriteLine(lunar.infoEnglish2);
				Console.WriteLine(english.thisRace);
				choice.thatRace = Convert.ToInt32(Console.ReadLine());
				if (choice.thatRace==1) {
					Console.WriteLine("Your choice is " + lunar.nameEnglish + ". Now welcome to the game.");
					Console.ReadKey();
				}
				else {
					goto English;
				}
			}
			else if (choice.RaceBeforeStart==3) {
				Console.WriteLine(panyan.infoEnglish);
				Console.WriteLine(panyan.infoEnglish2);
				Console.WriteLine(english.thisRace);
				choice.thatRace = Convert.ToInt32(Console.ReadLine());
				if (choice.thatRace==1) {
					Console.WriteLine("Your choice is " + panyan.nameEnglish + ". Now welcome to the game.");
					Console.ReadKey();
				}
				else {
					goto English;
				}
				
	}
}
	}
}