// Experimental version of Planets, v0.0.4ex
using System;

namespace planets_experimental
{
	class Program
	{
		public static void Main(string[] args)
		{
			Language lang = new Language();
			Race race = new Race();
			Terrain terrain = new Terrain();
			Lunar lunar = new Lunar();
			Panyan panyan = new Panyan();
			Turn turn = new Turn();
			Choice choice = new Choice();
			Console.WriteLine("Choose language / Выберите язык");
			Console.WriteLine("1 - English / 2 - Русский");
			choice.Language = Convert.ToInt32(Console.ReadLine());
			if (choice.Language==1)
			{
				lang = new English();
				goto Start;
			}
			else if (choice.Language==2)
			{
				lang = new Russian();
				goto Start;
			}

		Start:
			Console.WriteLine(lang.welcome);
			Console.WriteLine(lang.welcome2);
			Console.WriteLine(lang.welcome3);
			choice.RaceBeforeStart = Convert.ToInt32(Console.ReadLine());
			if (choice.RaceBeforeStart==1)
			{
				Console.WriteLine(lang.terraininfo);
				Console.WriteLine(lang.terraininfo2);
				Console.WriteLine(lang.thisRace);
				choice.thatRace = Convert.ToInt32(Console.ReadLine());
				if (choice.thatRace==1) 
				{
					Console.WriteLine(lang.raceChosen + lang.terrainName);
					choice.race = lang.terrainName;
					race = new Terrain();
					goto game;
				}
				else
				{
					goto Start;
				}
			}
			if (choice.RaceBeforeStart==2)
			{
				Console.WriteLine(lang.lunarinfo);
				Console.WriteLine(lang.lunarinfo2);
				Console.WriteLine(lang.thisRace);
				choice.thatRace = Convert.ToInt32(Console.ReadLine());
				if (choice.thatRace==1) 
				{
					Console.WriteLine(lang.raceChosen + lang.lunarName);
					choice.race = lang.lunarName;
					race = new Lunar();
					goto game;
				}
				else
				{
					goto Start;
				}
			}
			if (choice.RaceBeforeStart==3)
			{
				Console.WriteLine(lang.panyaninfo);
				Console.WriteLine(lang.panyaninfo2);
				Console.WriteLine(lang.thisRace);
				choice.thatRace = Convert.ToInt32(Console.ReadLine());
				if (choice.thatRace==1)
				{
					Console.WriteLine(lang.raceChosen + lang.panyanName);
					choice.race = lang.panyanName;
					race = new Panyan();
					goto game;
				}
				else
				{
					goto Start;
				}
			}
			
		game:
			Console.WriteLine(lang.youPlayAs + choice.race + ". " + lang.nowTurn + turn.currentTurn + ". " + lang.nowResearch + turn.currentResearch + ". " + lang.reslft1 + turn.researchTurnsLeft + lang.reslft2);
			Console.WriteLine(lang.chooseNext);
			choice.menuChoice = Convert.ToInt32(Console.ReadLine());
			if (choice.menuChoice==1) 
			{
				turn.currentTurn++;
				Console.WriteLine(lang.nextTurn + lang.currentTurn + turn.currentTurn + ".");
				if (turn.researchTurnsLeft>0)
				{
					turn.researchTurnsLeft--;
					goto game;
				}
				else {
					goto game;
				}
			}
			else if (choice.menuChoice==2)
			{
				Console.WriteLine("In progress..."); // Researches
				goto game;
			}
			else if (choice.menuChoice==3)
			{
				Console.WriteLine(lang.resource1 + race.money + lang.resource2 + race.population + lang.resource3 + race.planets + lang.resource4 + race.food + lang.resource5 + race.troops + lang.resource6 + race.ships + lang.resource7);
				goto game;
			}
			else if (choice.menuChoice==4)
			{
				Console.WriteLine("In progress..."); // Diplomacy
				goto game;
			}
			else if (choice.menuChoice==5)
			{
				Console.WriteLine("In progress..."); // War
				goto game;
			}
			else if (choice.menuChoice==6)
			{
				Console.WriteLine("In progress..."); // Planets
				goto game;
			}
			else
			{
				goto game;
			}
	}
}
	}