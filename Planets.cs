// Planets v0.0.3dbg Pre-Alpha. (c) Aqualabs, 2019. Game is shared via GNU LGPLv3 License.

using System;
using System.Text;

	namespace Planets {
        class Program {
            public static void Main (string[] args) {
			
			// string Language = "russian"; // Язык по умолчанию
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
                string currentResearch = "";
                
                // Здесь начинается список доступных исследований.
                // При необходимости добавить новое исследование просто дописываем его.
                int [] crGoX = {3, 5, 7, 9, 11, 13, 15};
                int [] srGoX = {4, 7, 11, 14, 17, 21, 25};
                int [] irGoX = {3, 5, 7, 9, 11, 14};
                int crGo = 0;
                int srGo = 0;
                int irGo = 0;
                bool researchActive = false; // активно исследование или нет
                int rscChoice = 0; // выбор в меню исследований
                bool crActive = false; // Сейчас изучается оружие
                bool srActive = false; // Сейчас изучаются корабли
                bool irActive = false; // Сейчас изучается инфраструктура
                // Массив с доступными исследованиями по оружию.
                string [] combatResearches;
                combatResearches = new string[] {"Ультрафиолетовый лазер", "Термоядерные боеголовки", "Генератор молний", "Пульс-лазерный дезинтегратор", "Боеголовка на основе антиматерии", "Генератор чёрной дыры"};
                string [] crTurns;
                crTurns = new string[] {"3 хода для изучения", "5 ходов для изучения", "7 ходов для изучения", "9 ходов для изучения", "11 ходов для изучения", "13 ходов для изучения", "15 ходов для изучения"};
                // Массив с доступными исследованиями по кораблям.
                string [] shipsResearches;
                shipsResearches = new string[] {"Улучшенный эсминец, класс 3", "Улучшенный эсминец, класс 2", "Крейсер, класс 3", "Улучшенный эсминец, класс 1", "Крейсер, класс 2", "Элитный эсминец", "Линкор, класс 3", "Крейсер, класс 1", "Линкор, класс 2", "Линкор, класс 1"};
                string [] srTurns;
                srTurns = new string[] {"4 хода для изучения", "7 ходов для изучения", "11 ходов для изучения", "14 ходов для изучения", "17 ходов для изучения", "21 ход для изучения", "25 ходов для изучения"};
                // Массив с доступными исследованиями по инфраструктуре.
                string [] infrastructureResearches;
                infrastructureResearches = new string[] {"Орбитальные перинатальные центры", "Терраформер, класс 3", "Модификация ДНК", "Терраформер, класс 2", "Люди из пробирки", "Терраформер, класс 1"};
                string [] irTurns;
                irTurns = new string[] {"3 хода для изучения", "5 ходов для изучения", "7 ходов для изучения", "9 ходов для изучения", "11 ходов для изучения", "14 ходов для изучения"};
                
                int combatResearched = 0; // Сколько у нас уже готовых исследований по оружию
                int shipsResearched = 0; // Сколько у нас уже готовых исследований по кораблям
                int infrastructureResearched = 0; // Сколько у нас уже готовых исследований по инфраструктуре
                
                string combatResearchCurrent = "";
                string shipsResearchCurrent = "";
                string infrastructureResearchCurrent = "";
                
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
                    if (researchTurnsLeft>0 & researchActive==true) {
                    	researchTurnsLeft-- ;
                    }
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
                    // Меню исследований начинается отсюда.
                    if (researchActive==true)
                    {
                    	goto researchActiveMenu;
                    }
                    else {
                    	goto researchInactiveMenu;
                    }
                    
                  researchActiveMenu:
                    // Если исследование сейчас активно
                    if (researchTurnsLeft>0 & researchActive==true) {
                    	Console.WriteLine("Сейчас изучается " + currentResearch + ". Осталось " + researchTurnsLeft + " ходов.");
                    	goto Game;
                    }
                    else if (researchTurnsLeft==0 & researchActive==false) {
                    	goto researchInactiveMenu;
                    }
                    
                   researchInactiveMenu:
                    // Если текущего исследования нет.
                    	Console.WriteLine("Сейчас вам доступны такие исследования:");
                    	Console.WriteLine("1. Оружие - " + combatResearches[crGo] + ", " + crTurns[crGo] + ".");
                    	Console.WriteLine("2. Корабли - " + shipsResearches[srGo] + ", " + srTurns[srGo] + ".");
                    	Console.WriteLine("3. Инфраструктура - " + infrastructureResearches[irGo] + ", " + irTurns[irGo] + ".");
                    	Console.WriteLine("Введите номер желаемого исследования, чтобы начать его.");
                    	rscChoice = Convert.ToInt32(Console.ReadLine());
                    	switch (rscChoice) {
                    		case 1:
                    			goto combatsrc;
                    		case 2:
                    			goto shipssrc;
                    		case 3:
                    			goto infrastructuresrc;
                    		default:
                    			goto Game;
                    	}                  
                   
                   // При выборе исследования оружия 
                   combatsrc:
                    researchActive = true;
                    researchTurnsLeft = crGoX[crGo];
                    crActive = true;
                    Console.WriteLine("Вы начали исследование " + combatResearches[crGo] + "." + "Осталось " + crGoX[crGo] + " ходов.");
                    combatResearchCurrent = combatResearches[crGo];
                    currentResearch = combatResearchCurrent;
                    crGo++;
                    goto Game;
                   // При выборе исследования кораблей 
                   shipssrc:
                    researchActive = true;
                    srActive = true;
                    researchTurnsLeft = srGoX[srGo];
                    Console.WriteLine("Вы начали исследование " + shipsResearches[crGo] + "." + "Осталось " + srGoX[srGo] + " ходов.");
                    shipsResearchCurrent = shipsResearches[srGo];
                    currentResearch = shipsResearchCurrent;
                    srGo++;
                    goto Game;
                   // При выборе исследования инфраструктуры 
                   infrastructuresrc:
                    researchActive = true;
                    irActive = true;
                    researchTurnsLeft = irGoX[irGo];
                    Console.WriteLine("Вы начали исследование " + infrastructureResearches[irGo] + "." + "Осталось " + irGoX[irGo] + " ходов.");
                    infrastructureResearchCurrent = infrastructureResearches[irGo];
                    currentResearch = infrastructureResearchCurrent;
                    irGo++;
                    goto researchEnd;
                    
                  // Завершение исследования
                  researchEnd:
                   if (crActive==true & researchTurnsLeft==0) {
                   	combatResearched++;
                   	crActive = false;
                   	Console.WriteLine("Исследование " + combatResearchCurrent + "завершено.");
                   	researchActive = false;
                   	goto researches;
                   }
                   else if (srActive==true & researchTurnsLeft==0) {
                   	shipsResearched++;
                   	srActive = false;
                   	Console.WriteLine("Исследование " + shipsResearchCurrent + "завершено.");
                   	researchActive = false;
                   	goto researches;
                   }
                   else if (irActive==true & researchTurnsLeft==0) {
                   	infrastructureResearched++;
                   	irActive = false;
                   	Console.WriteLine("Исследование " + infrastructureResearchCurrent + "завершено.");
                   	researchActive = false;
                   	goto researches;
                   }
		}
		}
	}