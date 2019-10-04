// This class contains an English translation of planets-experimental.
using System;

namespace planets_experimental
{
	public class Language
	{
		public Language()
		{
			welcome = "Welcome to Planets, a console turn-based strategy game.";
			welcome2 = "Decide which race do you want to play.";
			welcome3 = "They are three of them - Terrain, Lunars and Panyans. Enter 1, 2, or 3 to read more.";
			thisRace = "Choose this race or go back to menu? Type 1 or 2";
			terraininfo = "Terrain is a balanced race with a good population rate.";
			terraininfo2 = "Population + 500 against other races.";
			lunarinfo = "Lunars are very smart and creative. They are good in trading.";
			lunarinfo2 = "Money + 250 against other races.";
			panyaninfo = "Panyans are peaceful. They are concentrated on growing the infrastructure.";
			panyaninfo2 = "Food + 5 against other races.";
			terrainName = "Terrain";
			lunarName = "Lunar";
			panyanName = "Panyan";
			raceChosen = "Good luck! You have chosen race ";
			youPlayAs = "You play as ";
			nowTurn = "Turn: ";
			nowResearch = "Now researching: ";
			reslft1 = "Before research ends it's ";
			reslft2 = " turns left.";
			chooseNext = "Choose: 1 - Next Turn; 2 - Researches; 3 - Resources; 4 - Diplomacy; 5 - War; 6 - Planets";
			nextTurn = "You went on the next turn.";
			currentTurn = "Current turn is ";
			resource1 = "Now you have: ";
			resource2 = " credits, ";
			resource3 = " population on ";
			resource4 = " planet(s), ";
			resource5 = " kilotons of food, ";
			resource6 = " troops on ";
			resource7 = " ships.";
		}
		
		 public string welcome { get; protected set; }
		 public string welcome2 { get; protected set; }
		 public string welcome3 { get; protected set; }
		 public string thisRace { get; protected set; }
		 public string terraininfo { get; protected set; }
		 public string terraininfo2 { get; protected set; }
		 public string lunarinfo { get; protected set; }
		 public string lunarinfo2 { get; protected set; }
		 public string panyaninfo { get; protected set; }
		 public string panyaninfo2 { get; protected set; }
		 public string terrainName { get; protected set; }
		 public string lunarName { get; protected set; }
		 public string panyanName { get; protected set; }
		 public string raceChosen { get; protected set; }
		 public string youPlayAs { get; protected set; }
		 public string nowTurn { get; protected set; }
		 public string nowResearch { get; protected set; }
		 public string reslft1 { get; protected set; }
		 public string reslft2 { get; protected set; }
		 public string chooseNext { get; protected set; }
		 public string nextTurn { get; protected set; }
		 public string currentTurn { get; protected set; }
		 public string resource1 { get; protected set; }
		 public string resource2 { get; protected set; }
		 public string resource3 { get; protected set; }
		 public string resource4 { get; protected set; }
		 public string resource5 { get; protected set; }
		 public string resource6 { get; protected set; }
		 public string resource7 { get; protected set; }
	}
	public class English : Language
	{
		public English()
		{
			
		}
	}
	public class Russian : Language
	{
		public Russian()
		{
			welcome = "Добро пожаловать в Planets, консольную пошаговую стратегию.";
			welcome2 = "Выберите расу, за которую хотите играть.";
			welcome3 = "Их три - Люди, Лунары и Паньяны. Введите 1, 2 или 3, чтобы прочесть больше.";
			thisRace = "Хотите выбрать эту расу или вернуться в меню? Введите 1 или 2";
			terraininfo = "Люди - это сбалансированная раса с хорошим ростом населения.";
			terraininfo2 = "Рост населения + 500 относительно других рас.";
			lunarinfo = "Лунары очень умны и креативны. Они хороши в торговле.";
			lunarinfo2 = "Прибыль + 250 относительно других рас.";
			panyaninfo = "Паньяны мирные. Они сконцентрированы на росте инфраструктуры.";
			panyaninfo2 = "Сбор урожая + 5 относительно других рас.";
			terrainName = "Люди";
			lunarName = "Лунары";
			panyanName = "Паньяны";
			raceChosen = "Удачи в игре! Вы выбрали расу ";
			youPlayAs = "Вы играете за расу ";
			nowTurn = "Текущий ход: ";
			nowResearch = "Сейчас исследуется: ";
			reslft1 = "До конца исследования ещё ";
			reslft2 = " ходов.";
			chooseNext = "Выберите: 1 - Следующий ход; 2 - Исследования; 3 - Ресурсы; 4 - Дипломатия; 5 - Война; 6 - Планеты";
			nextTurn = "Вы перешли на следующий ход.";
			currentTurn = "Текущий ход - ";
			resource1 = "У вас сейчас: ";
			resource2 = " кредитов, ";
			resource3 = " населения на ";
			resource4 = " планете(ах), ";
			resource5 = " килотонн еды, ";
			resource6 = " солдат на ";
			resource7 = " кораблях.";
		}
	}
}
