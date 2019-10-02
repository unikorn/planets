// Planets v0.0.2dbg Pre-Alpha. (c) Aqualabs, 2019. Game is shared via GNU LGPLv3 License.
// ToDo: Researches 1/2, War, Diplomacy
// Done: Resources, Selecting race, Next Turn, Researches 1/2
// Changelog:
// Added researches, but without ability to, actually, research. Some code fixes.

using System;
using System.Text;

	namespace Planets {
        class Program {
            public static void Main (string[] args) {
			
			string Language = "russian"; // Язык по умолчанию
			// ДОБАВИТЬ АНГЛИЙСКИЙ ПЕРЕВОД!!
			// string start_en = "Welcome to Planets, a CLI turn-based strategy."
			// string start_ru = "Добро пожаловать в Planets - консольную пошаговую стратегию."
			
                // Здесь описываются доступные расы.
                int race; // От значения этого числа зависит выбранная нами раса.
                const int TerrainRace = 1;
                const int LunarRace = 2;
                const int PanyanRace = 3;
                // Здесь перечень доступных показателей.
                int money; // Деньги
                int resources; // Ресурсы
                int researches; // Количество открытых исследований
                int food; // Еда
                int troops; // Солдаты
                int ships; // Корабли
                int planets; // Планеты
                int population; // Население
                int turn; // Текущий ход
                int researchTurnsLeft = 0; // Сколько ходов осталось до завершения исследования
                string currentResearch = "ничего";
                
                // Здесь начинается список доступных исследований.
                // При необходимости добавить новое исследование просто дописываем его.
                string combatResearch1 = "Ультрафиолетовый лазер";
                string combatResearch2 = "Термоядерные боеголовки";
                string combatResearch3 = "Генератор молний";
                string combatResearch4 = "Пульс-лазерный дезинтегратор";
                string combatResearch5 = "Боеголовка на основе антиматерии";
                string combatResearch6 = "Генератор чёрной дыры";
                
                string shipsResearch1 = "Улучшенный эсминец, класс 3";
                string shipsResearch2 = "Улучшенный эсминец, класс 2";
                string shipsResearch3 = "Крейсер, класс 3";
                string shipsResearch4 = "Улучшенный эсминец, класс 1";
                string shipsResearch5 = "Крейсер, класс 2";
                string shipsResearch6 = "Элитный эсминец";
                string shipsResearch7 = "Линкор, класс 3";
                string shipsResearch8 = "Крейсер, класс 1";
                string shipsResearch9 = "Линкор, класс 2";
                string shipsResearch10 = "Линкор, класс 1";
                
                string infrastructureResearch1 = "Орбитальные перинатальные центры";
                string infrastructureResearch2 = "Терраформер, класс 3";
                
                int combatResearched = 0; // Сколько у нас уже готовых исследований по оружию
                int shipsResearched = 0; // Сколько у нас уже готовых исследований по кораблям
                int infrastructureReseacrhed = 0; // Сколько у нас уже готовых исследований по инфраструктуре
                
                // Отсюда начинается вступление в игру.
                Console.WriteLine("Добро пожаловать в Planets - консольную пошаговую стратегию.");
                Console.WriteLine("Для начала, выберите одну из трёх рас, доступных в игре.");
                goto raceSelect;
                raceSelect:
                    Console.WriteLine("1 - Люди; 2- Лунары; 3 - Паньяны");
                    Console.WriteLine("Выберите номер расы, чтобы прочесть о ней подробнее..");
                    int rscslc;
                    rscslc = Convert.ToInt32(Console.ReadLine());
                    if (rscslc==1) {
                    	goto terraininfo; }
                    else if (rscslc==2) {
                    	goto lunarinfo; }
                    else if (rscslc==3) {
                    	goto panyaninfo; }
                    else {
                    	Console.ReadKey(); }
                   
                terraininfo:
                    // Информация о расе Людей
                    Console.WriteLine("Люди - любители и мира, и войны. Главное их преимущество - быстрый рост популяции, за счёт чего можно колонизировать больше планет.");
                    Console.WriteLine("При этом лунары лучше в торговле, а паньяны - в производстве ресурсов");
                    Console.WriteLine("Хотите выбрать эту расу или вернутся назад? Введите 1 или 2 соответственно");
                    int terrainchoice;
                    terrainchoice = Convert.ToInt32(Console.ReadLine());
                    if (terrainchoice==1) {
                    	race = TerrainRace;
                    	goto GameStart; }
                    else {
                    	goto raceSelect; }
                    
                lunarinfo:
                    // Информация о расе Лунаров
                    Console.WriteLine("Лунары - раса, преуспевающая в торговле. Лунары очень хитры и умны.");
                    Console.WriteLine("При этом люди обладают лучшей популяцией, а паньяны - производством ресурсов");
                    Console.WriteLine("Хотите выбрать эту расу или вернутся назад? Введите 1 или 2 соответственно");
                    int lunarchoice;
                    lunarchoice = Convert.ToInt32(Console.ReadLine());
                    if (lunarchoice==1) {
                    	race = LunarRace;
                    	goto GameStart; }
                    else {
                    	goto raceSelect; }
                    
                panyaninfo:
                    // Информация о расе Паньянов
                    Console.WriteLine("Паньяны - мирная раса, сосредоточенная на производстве ресурсов и развитии инфраструктуры.");
                    Console.WriteLine("При этом люди обладают лучшей популяцией, а лунары - большим заработком.");
                    Console.WriteLine("Хотите выбрать эту расу или вернутся назад? Введите 1 или 2 соответственно");
                    int panyanchoice;
                    panyanchoice = Convert.ToInt32(Console.ReadLine());
                    if (panyanchoice==1) {
                    	race = PanyanRace;
                    	goto GameStart; }
                    else {
                    	goto raceSelect; }
                    
                   GameStart:
                    // Отображает текущую выбранную расу и отправляет в меню игры.
                    string whichRace;
                    if (race==1) {
                    	Console.WriteLine("Вы выбрали Людей. Ваш стартовый капитал - 10000 кредитов.");
                    	Console.WriteLine("Каждый ход вам будет начислено 250 кредитов.");
                    	whichRace="Люди";
                    	turn = 1;
                    	money = 10000;
                    	food = 200;
                    	population = 100000;
                    	planets = 1;
                    	goto Game;
                    }
                    else if (race==2) {
                    	Console.WriteLine("Вы выбрали Лунаров. Ваш стартовый капитал - 10000 кредитов.");
                    	Console.WriteLine("Каждый ход вам будет начислено 500 кредитов.");
                    	whichRace="Лунары";
                    	turn = 1;
                    	money = 10000;
                    	food = 200;
                    	population = 100000;
                    	planets = 1;
                    	goto Game;
                    }
                    else if (race==3) {
                    	Console.WriteLine("Вы выбрали Паньянов. Ваш стартовый капитал - 10000 кредитов.");
                    	Console.WriteLine("Каждый ход вам будет начислено 250 кредитов.");
                    	whichRace="Паньяны";
                    	turn = 1;
                    	money = 10000;
                    	food = 200;
                    	population = 100000;
                    	planets = 1;
                    	goto Game;
                    }
                    else {
                    	goto raceSelect;
                    }
                    
                   Game:
                    // Непосредственно игровое поле.
                    int menuChoice;
                    Console.WriteLine("Вы играете за расу " + whichRace + ". Текущий ход: " + turn);
                    Console.WriteLine("У вас " + money + " кредитов, населения - " + population + " на " + planets + " планете (ах), количество еды - " + food + ".");
                    Console.WriteLine("Выберите пункт меню.");
                    Console.WriteLine("1 - Следующий ход. 2 - Исследования. 3 - Дипломатия. 4 - Планеты. 5 - Армия. 6 - Корабли. 7 - Война");
                    menuChoice = Convert.ToInt32(Console.ReadLine());
                    if (menuChoice==1) {
                    	goto nextTurn; }
                    else if (menuChoice==2) {
                    	goto researches;
                    }
                    else {
                    	Console.ReadKey();
                    }
                    
                   nextTurn:
                    // Переход на следующий ход.
                    // Прогресс исследований добавлен 02.10.19
                    if (race==1) {
                    	money = money + 250;
                    	food = food + 5;
                    	population = population + 1000;
                    	turn++;
                    	Console.WriteLine("Вы перешли на новый ход. До окончания исследования " + currentResearch + " осталось " + researchTurnsLeft + " ходов.");
                    	goto Game;
                    }
                    else if (race==2) {
                    	money = money + 500;
                    	food = food + 5;
                    	population = population + 500;
                    	turn++;
                    	Console.WriteLine("Вы перешли на новый ход. До окончания исследования " + currentResearch + " осталось " + researchTurnsLeft + " ходов.");
                    	goto Game;
                    }
                    else if (race==3) {
                    	money = money + 250;
                    	food = food + 10;
                    	population = population + 1000;
                    	turn++;
                    	Console.WriteLine("Вы перешли на новый ход. До окончания исследования " + currentResearch + " осталось " + researchTurnsLeft + " ходов.");
                    	goto Game;
                    }
                    
                   researches:
                    // Наши исследования.
                    Console.WriteLine("Список текущих доступных вам исследований:");
                    if (combatResearched==0 && shipsResearched==0 && infrastructureReseacrhed==0) {
                    	Console.WriteLine("Оружие - " + combatResearch1 + "; корабли - " + shipsResearch1 + "; инфраструктура - " + infrastructureResearch1 + ".");
                    	Console.ReadKey();
                    }
		}
	}
}