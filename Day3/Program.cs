﻿using Day3;

string data = ".242......276....234............682.......................958..695..742................714......574..............833.........159....297.686.\r\n.............*............................612*......304..*..........*.......@175...#...*...........*890...........*.............*..*........\r\n..........346......................997........923......*..253..........698........122.746.....-832..........766.432..229.....674....415.....\r\n...............#76...........332....*...............111...........785..............................=..720..*........*.......................\r\n........204............396..*.....357..438*694...............154.................................26...*....422...200.../201.................\r\n....859*......496.598.+....810........................816.......*713...........802#.........330......540...........................%344.....\r\n..............*.....*..........344.......................*.............671............994.................467...............................\r\n........$..388.........152*141..*......73.719...$526....830...759......%......943............541.624.781...*...$150.............966.........\r\n.....877.......................67.....*.....*.............................859..*..502+........$..*.....*.425........778.../........*........\r\n................142.....569..........563...57......786..........303.......*...255.......*638....979..704...........*.......181..............\r\n...........560.....%....+......................276...=..................939..........194.........................675..............741.......\r\n......681...*..................882..714................741......650.........&.................374...542/..........................*.........\r\n344*.....%.340......$.....%......=.....*.....799...990...*.........*733..811.....................-...............8........844...660.........\r\n....937.........301.227.775.24+....=.146..../.....*.......983...+.....................*822.898&.................*.....611*..............693.\r\n...........&.....................328............254..582.......528...359&..........536..........*889........%...........................#...\r\n..901.497.9.........473................193...........*....................168...........................382.450..@..........................\r\n..............................279..612..*..........795.......431......$............104....................*.......988....................920\r\n............614....478..430+....*..../...505...363...................195....642....-............493....852...612.........556................\r\n.............*................570....................961.....................=........178...23.$..................667...........=....415....\r\n...323*795....363.................414%.........$....@..................54.........680*.....*.....415.......34..........598.......74.........\r\n..................904.124....766.........-..546....................-........100........167.424..*.........%.........83*................*....\r\n..906@.+.....-......&..........*..951.342.......208...........887...711....*...........*........627...............................=597..478.\r\n.......323.187..+.............192...@......367.*.....107.........$......715.....923....103...........*991.....+....749..146.................\r\n.................170.....511...........-................*...........943.....95..............................215.........*.....126...........\r\n..166................809..*.........590...733.896.....575.333.......*......*...229...122.........................%.......860..-...315.......\r\n.....*856....4.....%.-...826.174............&...*............*..851..655...692..*......*....*................346..659.......................\r\n.............+...77............&.541$...........227.......329.....*............483..463...551....38......527.*...............168.....665@...\r\n....915..635.........960...209........710.....................538..449..........................*.........*..586......574...................\r\n..../.../.....61............*...........*...489..........510..@...........#.........254....52.411........894......932..*...206.121....=911..\r\n..................900..525.450.591...#..178.+..............%......125...433...362..*.......*.......................*..111.....*.............\r\n.........736*134...*....*..........720..........#...................*.........&.....197..450......................252...........=516........\r\n...................638.314.....................510.........*..475....629...............................................930..................\r\n...........................926......../....*.......776....798../................/..............982..............437.....@.....937...........\r\n....502-........-595..........*.....439.282.965...............................+..853..884.419..+......244*873....*........#....*.......309..\r\n...............................257..............937...413.199...@195..../....248.....+.....*..................100..585.....791..959.........\r\n...............*912.......410......@...........*.........*.............4....................321....................*........................\r\n......653..................*.......817..#511.131..=785.........468/......128........#144..............*170...559..146..........625/..976....\r\n......&..................997..............................711..............*.................792...450......$..............12..........#....\r\n..................412.....................33...............*................672...=........3...*.7.................739.567...........#......\r\n......................569#.#.......850....*......381........621.253+...............355....*..942../........371.....*....*....285*118.754....\r\n.....-......................899............327...*.....................+........*......575..........*892........618......511................\r\n...91............................958-..........532..................914......925.............=.457&..........#......948*..........27.....382\r\n...................771......857.......-..................79...............................156.........938....389........353...502*..........\r\n..............................*.......847...............*....238....................161..............*.............*................164.660.\r\n..995..........872.....690.....888...........69..=123..353......*..621..736*........+...87...887....518...........590...429....*254...&.*...\r\n....*.584.631.......$....................980.*...............569......*.....14..........*.....*...............399..........*.............199\r\n..446..-..%.........200.933...385*.........*..150..........=..........169........374#.322......806...........+.....*........553.............\r\n............@66.........*.........559...580.................120..147-..............................757..............933............644......\r\n.....................641...943................143..634.648................-...288...................*.............+.........%....$...*......\r\n..........273.............-...............430....&......@.........*.......876./........826..........67.......801.86......121.....210........\r\n...842....=...................599*17..182*.....@...................902.............980*........................@.............826............\r\n....*.......238................................769.....-.......................124......763...........98.491.....420....@901.*.........84...\r\n...564.......&...........296........................503...591..967......162...=.........*...238..386........#.........#......629.26.........\r\n...................423......*723........559$...................*..................849...342........./...............521............@........\r\n..833*.....3*974..+..............718..........884.#.............503..........284.....*.........223......................................*...\r\n......................532....=.....*..........*....255.............................287..................31...........*....757%.977.......753\r\n640.....846...............252.....351.....372.258......................................871.........@33..*..149....624..........*.....537....\r\n...=.........495.....846..............526*..............622....*899.....870......81......%...&.........786...............891...668..........\r\n................*......*.....................+.........*....211.....498....*......-.654....368.....................916.................698..\r\n986......629....115..749.........=....925.858..........233............*.151....78......@.......593..684........916...@......................\r\n.........&....@................@.500.%.........681..+.........431...488..........*932....291=.#.......*........*.........782....$799........\r\n.....131.....319.944.........577...............*.....777.....................448................614..901..287..722.....&...*................\r\n....*....157.......*........................966...........442#....472..925...#...359..519......*.........*............937.39..........%639..\r\n..388......*..266..703...........................................*........@.........*....*......109....424......672...............601.......\r\n...........89...=.................911...949.....#.............487....61.......*491.822.113.................250........*34............*9.....\r\n..15...............345....703..%....*...-....673....239...191........*........................26.130.......*........20........393...........\r\n....*991..%..........*.......*..453.70...............#.....-..597.491...328.....122..........*..........492....701......508....*..274.......\r\n...........838........893...............53..658.865........................#....*.....-....570........$...........&........*........./...486\r\n................438.............71.............*.....854..+..107*647...200......575...932...........573....606...........850................\r\n................../.........838...*674..............#....69.............*......................534.........*..................235*..........\r\n.....877*8............184...*.................................*.........191...........*707........*...198..363......305.*338......392..657..\r\n.................98...=....953...362......148...335.........781.............484....608............207.*..............*......................\r\n................................*........*........@...............584@......%................418.......675.......520..260.............639...\r\n41.$....952....133@.999......953..*.....64...792.................................$....111.......*...................*.................*.....\r\n...572....*.........+............18............+.494..694.......+.....93.......443....#......861..................304...696....+487...89....\r\n...........3............................................+.....461.868...*........................596...#.710..793.......%...................\r\n................362.................%684.........716...................420...............53......*...706.......*../.......@142......*.......\r\n........@...696...*......489....434...............*........................670.......187*......992...........730.48..............443.986....\r\n.......904.....*.260....%..........#.139.....850..592..187.....137..987.......=.195................366..%.............596.427/..............\r\n............284.............*141...../...739...............131......*...........@..........510......*..112...-........*.....................\r\n......192................313.......*........*.......43*......*.....309......557......669.....+.....386.......765.....567......758.287.......\r\n..139...........................535.848..#..519........277....778..........*.........*...................526...................*......968...\r\n.....*....-........664..45..............426..........................603.560..&558...909...................%....934......392.395............\r\n......755..928......-......197....126..................227.......689.+....................170.....@805.............*122.....................\r\n..........................*.........*........909.......*...........*............263..475......201......193..................689..799.../2...\r\n...407..977.........918%...109...332.........*.......910.........730...170.........*....*428....*.....$........185..637......&..............\r\n...../...$....713....................501......842.........258............*.........872.......822..879....*626....*....*........255.......229\r\n................*.....633*631.....=....*..................................722.....................*...736........339.171..........-..279....\r\n...531*393......714............828......384.830.....90..............................683.........647............&...........820@.......*.....\r\n...........3...........965.........153........*.....................552.-.....709....*......413..........503....831.............289....138..\r\n..........*...906......*......................34..692.........941..+....205.....@..73..........*................................+...........\r\n.........830./........473..388.648........563....*..............*.....................589.....345.....276..........=.471.931........854.....\r\n135*315..........-604.........*....$.......&......134...=....565.......65.............../.............+.........866....=.%.....908.....*....\r\n....................................446......751.........437.....@.......*.140.....495....607#..783........625.............734*.......758...\r\n...........141......915.....................*.....*...............137.664....&..29.+............/.....113#.*......118.290........715........\r\n..614.396...........*......................459.....368..........................*...........352.............254..*....*............@...168..\r\n.....*............746....859..........650........%.....735....../....../198......619..718......-..................147.909..826.......*......\r\n.........79.............*.............=..........808...*........306.....................@.618......659..3...................*.....852.714...\r\n...157....*.901...957...422...369.......................236.............289........893.......*..............184*399..........958............\r\n...*........*.......................370.../....................2.990.62..../..........*......992...91.................816...................\r\n...419..731..546..868*10..726........*..13..@........................./.........326.94..829.......%.............@...................354.....\r\n..........*....................868..377.....319.....122=.787................463.........*...*.311...384..........418....774........*........\r\n..........762.#...&906........*..........................*........464.....*....*.....242..324.+...........444..............*..821.128.......\r\n..............918..........375.........%825....&.........27...227*.........711.239.........................*..............838.-........496..\r\n....783............................$...........661.....&.............................839.................508.........%......................\r\n.....*.....106........138....50.....237..............776...&............................*..&825......337......*...550.......337..587#.......\r\n..878.....*....391...=........*.733.......................32....353+..................265.......944..*...516..635...........*.........761...\r\n........212................716................444=...........*.......73....469............=..#.$....823..@...............105................\r\n...................68..=.............626...............@...88.531..............981......139.37.....................................522......\r\n.........898.......*..255........969*.......593*886....222.........860.497*168....*.150..................................586..........*.....\r\n............*177..58......681...........928..................131.....*..........560..#............................536......*...........860..\r\n..613......................*....-.......#.....363........701....*.116...565.....................-348....874...953..$..671..748..............\r\n......................$..408.....139.........*.............*............=..............615............*....+..*..........*............41....\r\n.....710..343....@...391.............$.....181..778........795..........................*.............201......875.....22...............*...\r\n629...*..*......769........482.....511.........*......699..........366...%510........518....101...424.......................................\r\n....374...875.........804...*...................395......*.........*.............162.......*.........*..........959............298$.........\r\n..............74.834.........345.....=..540.248.........401....977..454.695.....*....................17........*......536...@...............\r\n......807.......*........780.........54....*....................*........*...294...720...14&.................245........%....773......960...\r\n.........$..132..........*.......652..........$....907.....@.344....848=.397..........*......747............................................\r\n....541*....&...*.....663...146...........364..611....*.440.....................455.336.209.......751....539................................\r\n........408.....377...........*..............*......541.........&.......988*150...*.......-........=....*.........#...../..39..306+.........\r\n...%325..................*49...37.............922........344#...717.............179.400...............617.874...943...232...................\r\n...........424........569............865.............978...................978......-......+....23=..........*..............................\r\n..........=....................782..*.........755........41......823.......@...............427............484.......-.....310.......401.....\r\n...........................&..*....704....168*......264.............@...............240*...........................190................*..384\r\n617*.........710.....28.492..425............................-....4......=...757*283.....674....467....680......775.............$.....826....\r\n....975.....+........*...........100..........795..........67..........91...........946...........................*......138...390..........\r\n..........*.........808.............*474.....+.....141.........156.....................*..........194...........273.473..*...@.....86..+....\r\n.......589.919..........452.....842.......*.......*....472........*..................765...........*........$.........$..79.644.........905.\r\n................452.....%.........*....223........121.*............816.-949..837..............-830...818.451.....703........................\r\n.527..934.625.....*..........461...........842-.......455.....................@...866..97...........*..............$..819...............*919\r\n................472.........*..........930............................208.........*...&.........767.563....%..../......*..422...............\r\n.......%.389..............993..325.650..............344...*................651.379..............+.......516......607.142..+....284%.........\r\n....575.............498...........*.....760...+.........47.385....#.91......*...........957.......@.........................................\r\n.............588....*......./389.........*..839................567..*.....607..............*......377..460=...............260......491.282..\r\n.....137.........340................961.................383*.......295........................506...........*.....................*....*....\r\n......../..670..............52.....*.......802..950.........207..........334..377.625.....871...*........622..160.130..#.....295.30...216...\r\n.............*............=.*.......34.941.=.......*............&.12......*....*...........*...20..356...........*......804.*...............\r\n..........335..........562...258........*..........761.......758...*.....................602................................955........512..\r\n.........................................882........................730..........................566..............................202.......";
string data2 = "467..114..\r\n...*......\r\n....35.633\r\n......#...\r\n617*......\r\n.....+.58.\r\n..592.....\r\n......755.\r\n...$.*....\r\n.664.598..";
string[] split =  data.Split("\r\n");
char[] numbers = ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'];
List<int> results = new List<int>();
List<Gear> gearResults = new List<Gear>();

bool IsNumberAPart(int splitIndex, int numberIndex, int number)
{
	string currentLine = split[splitIndex];
	int numberLength = number.ToString().Length;
	bool check = false;

	try
	{
		check = CheckLine(splitIndex -1, numberIndex, numberLength);
		if (check) { return true; }
	}
	catch (Exception) {}

	try
	{
		if (currentLine[numberIndex-1] != '.' && !numbers.Contains(currentLine[numberIndex-1]))
		{
			return true;
		}
	}
	catch (Exception) {}

	try
	{
		if (currentLine[numberIndex + numberLength] != '.' && !numbers.Contains(currentLine[numberIndex + numberLength]))
		{
			return true;
		}
	}
	catch (Exception) {}

	try
	{
		check = CheckLine(splitIndex + 1, numberIndex, numberLength);
		if (check) { return true; }
	}
	catch (Exception) {}

	return false;
}

int GetWholeNumber(string line, int lineIndex)
{
	string result = line[lineIndex].ToString();
	try
	{
		while (numbers.Contains(line[lineIndex + 1]))
		{
			result += line[lineIndex + 1];
			lineIndex++;
		}
	}
	catch (IndexOutOfRangeException){}
	
	return int.Parse(result);
}

bool CheckLine(int splitIndex, int numberIndex, int numberLength)
{
	string lineToCheck = split[splitIndex];

	for (int i = -1; i < numberLength + 1; i++)
	{
		try
		{
			if (lineToCheck[numberIndex + i] != '.' && !numbers.Contains(lineToCheck[numberIndex + i]))
			{
				return true;
			}
		}
		catch (Exception) {}
		
	}
	return false;
}

void PartOne()
{
	int splitIndex = 0;
	foreach (var line in split)
	{
		for (int i = 0; i < line.Length; i++)
		{
			if (numbers.Contains(line[i]))
			{
				int number = GetWholeNumber(line, i);

				if (IsNumberAPart(splitIndex, i, number))
				{
					results.Add(number);
					
                }
				i += number.ToString().Length;
			}
		}
		splitIndex++;
	}

    Console.WriteLine(results.Sum());
}






Gear? CheckForGear(int splitIndex, int lineIndex)
{
	int firstGear = 0;
	int secondGear = 0;

	if (CheckLineWarning(splitIndex - 1, lineIndex))
	{
		firstGear = CheckPointForNumber(splitIndex - 1, lineIndex - 1);
		secondGear = CheckPointForNumber(splitIndex - 1, lineIndex + 1);
	}
	else if (CheckLineWarning(splitIndex + 1, lineIndex))
	{
		firstGear = CheckPointForNumber(splitIndex + 1, lineIndex - 1);
		secondGear = CheckPointForNumber(splitIndex + 1, lineIndex + 1);
	}
	else if (CheckLineWarning(splitIndex, lineIndex))
	{
		firstGear = CheckPointForNumber(splitIndex, lineIndex - 1);
		secondGear = CheckPointForNumber(splitIndex, lineIndex + 1);
	}
	else
	{
		for (int i = -1; i < 2; i++)
		{
			if (firstGear == 0)
			{
				firstGear = CheckLineForNumber(splitIndex + i, lineIndex);
			}
			else if (secondGear == 0)
			{
				secondGear = CheckLineForNumber(splitIndex + i, lineIndex);
			}
		}
	}

	if (firstGear != 0 && secondGear != 0)
	{
		Gear result = new Gear()
		{
			FirstGear = firstGear,
			SecondGear = secondGear
		};
        return result;
	}
	return null;
}

int CheckPointForNumber(int splitIndex, int lineIndex)
{
	string lineToCheck = split[splitIndex];

	try
	{
		if (numbers.Contains(lineToCheck[lineIndex]))
		{
			return GetWholeGearNumber(lineToCheck, lineIndex);
		}
	}
	catch (Exception) { }
	return 0;
}

bool CheckLineWarning(int splitIndex, int lineIndex)
{
	if (numbers.Contains(split[splitIndex][lineIndex - 1]) && numbers.Contains(split[splitIndex][lineIndex + 1]) && !numbers.Contains(split[splitIndex][lineIndex]))
	{
		return true;
    }
	return false;
}

int CheckLineForNumber(int splitIndex, int lineIndex)
{
	int number = 0;
	for (int i = -1; i < 2; i++)
	{
		number = CheckPointForNumber(splitIndex, lineIndex + i);
		if (number != 0)
		{
			return number;
		}
	}
	return 0;
}

int GetWholeGearNumber(string line, int lineIndex)
{
	try
	{
		while (numbers.Contains(line[lineIndex - 1]))
		{
			lineIndex--;
		}
	}
	catch (Exception) {}

	return GetWholeNumber(line, lineIndex);
}

void PartTwo()
{
	int splitIndex = 0;
	int result = 0;
	foreach (var line in split)
	{
		for (int i = 0; i < line.Length; i++)
		{
			if (line[i] == '*')
			{
				Gear? gear = CheckForGear(splitIndex, i);

				if (gear != null)
				{
					gearResults.Add(gear);
				}
			}
		}
		splitIndex++;
	}
	foreach (var gear in gearResults)
	{
		result += (gear.FirstGear * gear.SecondGear);
	}
    Console.WriteLine(result);
}














//PartOne();
PartTwo();