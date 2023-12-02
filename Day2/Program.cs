using Day2;
using System.Diagnostics;

string data = "Game 1: 4 red, 18 green, 15 blue; 17 green, 18 blue, 9 red; 8 red, 14 green, 6 blue; 14 green, 12 blue, 2 red\r\nGame 2: 6 red, 11 green; 4 blue, 4 green, 5 red; 11 green, 6 blue, 6 red\r\nGame 3: 3 red, 3 green; 3 green, 1 blue, 7 red; 3 green, 5 red, 1 blue; 9 red, 4 green; 1 blue, 2 green, 5 red\r\nGame 4: 2 blue, 5 green, 9 red; 7 red, 10 blue; 2 green, 14 blue, 5 red; 3 blue, 2 green; 4 green, 10 red, 7 blue; 2 green, 15 blue, 7 red\r\nGame 5: 3 red, 2 blue; 5 red, 3 blue; 10 blue, 10 red, 1 green; 4 blue\r\nGame 6: 1 green, 10 blue, 5 red; 8 blue, 9 green; 20 green, 7 red, 10 blue; 12 green, 6 blue, 6 red; 10 blue, 11 green; 8 blue, 17 green, 5 red\r\nGame 7: 7 green, 12 blue, 3 red; 19 red, 12 blue; 8 blue, 8 red, 7 green; 6 red, 7 green, 5 blue\r\nGame 8: 8 blue, 7 red; 13 green, 5 blue, 5 red; 11 blue, 4 green, 7 red; 5 blue, 6 red, 13 green; 7 blue, 12 green, 8 red\r\nGame 9: 3 red, 3 blue, 12 green; 2 red, 1 blue, 9 green; 3 red, 12 green, 3 blue; 2 red, 7 green, 2 blue; 8 green, 4 blue; 2 red, 2 green\r\nGame 10: 16 green, 10 red; 13 green, 7 red; 8 red, 1 blue, 8 green\r\nGame 11: 7 red, 1 blue, 1 green; 6 blue, 1 green, 3 red; 5 blue, 10 red\r\nGame 12: 1 green, 8 red, 5 blue; 6 red, 12 blue; 2 blue, 15 red; 14 blue, 15 red, 1 green; 8 red, 9 blue\r\nGame 13: 1 green, 6 red; 7 blue, 13 red, 1 green; 3 blue, 4 red\r\nGame 14: 11 red, 1 green, 1 blue; 3 blue, 18 red, 15 green; 10 blue, 5 green, 11 red\r\nGame 15: 6 green, 10 blue, 15 red; 6 green, 17 blue, 8 red; 19 red, 7 blue, 2 green; 1 green, 18 red, 4 blue\r\nGame 16: 1 green, 17 red, 7 blue; 12 red, 10 green, 9 blue; 15 red, 3 green, 15 blue\r\nGame 17: 12 blue, 13 green; 16 green, 19 blue, 7 red; 1 green, 2 blue\r\nGame 18: 8 blue, 9 green, 2 red; 9 blue, 7 green; 3 red, 9 green, 10 blue; 1 blue, 7 green, 2 red; 1 green, 8 blue, 4 red\r\nGame 19: 3 green, 2 red, 11 blue; 13 blue, 3 green, 1 red; 1 red, 10 blue\r\nGame 20: 2 red, 4 green, 1 blue; 14 blue, 7 green; 7 blue, 9 green; 4 red, 5 green, 7 blue\r\nGame 21: 4 blue, 20 red, 7 green; 4 green, 6 blue, 14 red; 6 green, 18 red, 5 blue; 2 blue, 4 green, 6 red; 4 green, 16 red, 4 blue\r\nGame 22: 13 red, 2 green; 6 red, 3 blue; 6 red, 2 green; 7 red, 1 green; 6 red, 2 green\r\nGame 23: 5 blue; 6 red, 16 green, 12 blue; 1 blue, 6 green, 2 red; 8 red, 6 blue, 3 green\r\nGame 24: 10 green, 4 blue, 5 red; 1 green, 3 red; 8 red, 3 blue, 6 green; 3 red, 2 blue; 3 red, 10 green, 3 blue\r\nGame 25: 1 red, 2 green; 4 green, 6 red, 1 blue; 3 red; 4 green, 2 red\r\nGame 26: 7 red, 1 blue; 2 red, 1 blue; 9 red, 1 green, 2 blue; 5 red, 2 blue; 4 red, 2 green; 8 red, 1 green, 2 blue\r\nGame 27: 1 green, 2 red, 8 blue; 1 green, 4 red, 9 blue; 16 blue, 12 red, 3 green; 13 blue, 4 green, 5 red\r\nGame 28: 8 blue, 8 green, 3 red; 8 green, 6 blue; 5 green, 6 blue, 4 red\r\nGame 29: 7 red, 11 green, 5 blue; 1 green, 1 blue, 6 red; 6 green, 5 blue, 8 red; 7 blue, 15 green, 2 red; 10 blue, 1 red\r\nGame 30: 7 red, 5 blue, 14 green; 2 blue, 11 red; 17 green, 2 blue, 7 red; 4 blue, 10 red, 5 green\r\nGame 31: 17 blue, 5 red, 2 green; 7 red, 14 blue, 3 green; 13 blue, 5 red, 2 green; 12 green, 8 blue, 8 red\r\nGame 32: 1 red, 7 blue; 1 red, 8 blue; 1 red, 2 green, 13 blue\r\nGame 33: 1 green, 3 blue, 3 red; 4 red, 2 green; 5 blue, 1 red, 1 green; 1 red, 8 blue, 2 green\r\nGame 34: 9 blue, 7 red; 9 green, 11 red, 1 blue; 18 red, 4 blue, 6 green\r\nGame 35: 7 blue, 4 green, 2 red; 1 green, 1 blue, 2 red; 3 green; 3 blue, 7 green, 1 red; 7 blue, 12 green\r\nGame 36: 17 red, 5 blue; 6 red, 5 green, 7 blue; 16 blue, 1 green, 7 red; 7 blue, 5 green, 15 red; 8 blue, 19 red, 1 green\r\nGame 37: 4 blue, 6 red, 1 green; 9 red, 8 green, 4 blue; 1 green, 8 blue, 10 red; 11 green, 6 red, 9 blue\r\nGame 38: 3 red, 4 blue; 5 red, 1 blue; 1 green, 2 red, 5 blue; 2 blue, 8 red; 7 red, 1 blue; 4 blue, 5 red\r\nGame 39: 7 green; 5 green; 3 blue; 12 green, 1 red, 1 blue; 8 green, 1 blue, 1 red\r\nGame 40: 12 red, 11 blue; 6 green, 2 blue, 13 red; 6 green, 7 red, 6 blue\r\nGame 41: 3 green, 1 blue; 5 blue, 7 red, 6 green; 6 red, 14 blue; 9 red, 14 green, 5 blue; 5 blue, 6 green, 3 red; 20 green, 4 blue, 5 red\r\nGame 42: 2 blue, 13 green; 10 red, 6 green; 8 green, 2 red; 7 red\r\nGame 43: 7 green, 3 red; 6 red, 6 green, 13 blue; 7 green, 2 red, 9 blue; 8 blue, 3 green, 1 red; 10 green, 7 red, 13 blue\r\nGame 44: 3 blue, 1 green, 2 red; 10 blue, 9 red; 5 red, 13 blue\r\nGame 45: 11 red, 2 green, 5 blue; 1 green, 6 red, 6 blue; 17 red, 2 green, 6 blue; 14 red, 2 green\r\nGame 46: 5 blue, 7 red, 8 green; 6 green, 1 red, 10 blue; 1 red, 5 blue, 4 green\r\nGame 47: 5 green, 5 red, 1 blue; 11 green, 8 red, 6 blue; 2 green, 16 red, 1 blue; 12 green, 1 red, 7 blue; 2 red, 15 green, 7 blue\r\nGame 48: 3 red, 6 green, 4 blue; 1 blue, 1 green, 2 red; 12 blue, 7 green, 5 red\r\nGame 49: 4 blue, 1 green; 4 red, 2 blue; 3 blue, 2 green; 5 red, 3 blue, 4 green\r\nGame 50: 1 blue, 1 green; 3 blue, 7 red, 1 green; 2 blue, 1 green\r\nGame 51: 17 blue, 1 green, 3 red; 2 green, 1 red, 3 blue; 14 blue, 10 red\r\nGame 52: 8 blue, 1 green; 1 blue, 3 red, 2 green; 2 green, 14 blue\r\nGame 53: 9 green, 3 blue, 9 red; 3 blue, 7 red, 8 green; 2 green, 2 red; 17 green, 3 red; 18 green, 8 red\r\nGame 54: 2 blue, 10 red; 2 green, 2 red; 6 green, 1 blue, 1 red; 3 blue, 6 red, 7 green\r\nGame 55: 3 blue, 1 red; 1 green, 2 red, 1 blue; 4 blue, 3 red; 5 blue, 3 green; 3 green, 1 red, 3 blue; 2 green\r\nGame 56: 10 green, 1 red, 6 blue; 16 green, 1 blue, 10 red; 8 red, 9 green, 2 blue; 3 red, 2 blue\r\nGame 57: 1 blue, 4 green, 1 red; 7 red, 4 green, 8 blue; 9 red, 3 blue, 3 green\r\nGame 58: 15 green, 16 blue, 8 red; 8 blue, 8 red, 2 green; 9 blue, 8 red, 3 green; 20 blue, 15 green, 7 red\r\nGame 59: 13 red, 3 blue; 12 red, 4 green; 9 blue, 5 green, 9 red; 2 red, 12 blue, 1 green\r\nGame 60: 14 green, 16 red; 5 green, 1 blue, 5 red; 14 green, 5 blue, 20 red; 2 blue, 8 green, 1 red\r\nGame 61: 2 green, 10 red, 15 blue; 17 blue, 6 red, 2 green; 2 red, 2 green, 12 blue; 2 red, 2 green\r\nGame 62: 8 blue, 1 green, 3 red; 6 red, 15 blue, 2 green; 5 green, 6 blue; 1 red, 7 green, 8 blue\r\nGame 63: 13 green, 8 red; 8 green, 1 blue, 5 red; 2 green, 8 red, 2 blue\r\nGame 64: 13 red, 12 blue, 4 green; 2 blue, 3 red, 1 green; 4 green, 14 red, 14 blue; 8 red, 4 green; 16 red; 5 blue, 16 red, 4 green\r\nGame 65: 13 red, 2 blue, 3 green; 10 red, 6 blue; 6 blue, 5 red\r\nGame 66: 1 blue, 9 green; 4 green, 5 blue; 8 green, 8 blue; 10 blue, 1 red, 10 green; 18 blue, 1 red, 9 green\r\nGame 67: 12 red, 7 blue; 13 red, 3 blue, 3 green; 7 blue, 6 red, 4 green\r\nGame 68: 3 green, 4 blue, 8 red; 1 green, 2 blue, 13 red; 3 green, 14 red, 4 blue; 6 red, 4 green; 7 blue, 2 red, 1 green; 1 green, 3 blue, 14 red\r\nGame 69: 2 blue, 6 red, 2 green; 7 green, 18 red; 11 green, 1 blue, 13 red; 3 red, 6 green, 1 blue; 19 red, 1 green\r\nGame 70: 13 green; 1 red, 14 green, 2 blue; 9 red, 1 blue, 9 green; 6 green, 5 red, 1 blue; 2 green, 10 red\r\nGame 71: 7 blue, 5 green, 11 red; 4 red, 8 blue, 5 green; 1 green, 1 blue; 6 green, 8 red, 5 blue; 8 red, 7 green, 6 blue\r\nGame 72: 2 blue, 2 green, 1 red; 5 green, 1 red, 3 blue; 4 green\r\nGame 73: 8 green, 3 blue, 3 red; 1 green, 3 red, 9 blue; 3 red, 10 blue, 8 green; 10 green, 3 red, 8 blue; 3 blue, 3 green; 2 green\r\nGame 74: 5 red, 1 green; 1 blue, 5 red; 8 red, 3 blue\r\nGame 75: 5 red, 7 green, 3 blue; 1 red, 5 blue, 4 green; 2 blue, 12 green; 3 blue, 5 red; 8 green, 4 blue, 3 red; 1 green, 2 blue, 1 red\r\nGame 76: 10 green, 5 blue, 1 red; 11 blue, 16 green, 1 red; 12 blue, 2 red, 18 green; 12 green, 10 blue; 5 blue, 5 green, 1 red; 9 green, 1 red, 1 blue\r\nGame 77: 9 blue, 1 red, 2 green; 1 blue, 1 red, 5 green; 5 blue\r\nGame 78: 1 red, 1 blue; 1 blue; 1 red; 1 green, 2 red, 1 blue; 1 blue, 4 red\r\nGame 79: 3 green, 11 red, 4 blue; 7 red, 1 green, 4 blue; 1 green, 3 red, 3 blue; 3 blue, 3 red, 4 green; 3 green, 3 blue, 9 red\r\nGame 80: 11 blue, 10 green, 11 red; 10 green, 9 red, 18 blue; 11 green, 17 blue, 7 red\r\nGame 81: 6 red, 1 blue; 3 blue, 6 red, 2 green; 6 red, 10 green, 1 blue; 5 blue, 3 green, 3 red\r\nGame 82: 6 red, 16 green, 2 blue; 9 green, 6 red, 3 blue; 1 blue, 9 red, 14 green; 8 green, 11 red, 3 blue; 3 red, 5 green; 12 green, 3 blue\r\nGame 83: 7 blue, 5 green, 11 red; 8 red, 9 blue, 13 green; 13 blue, 8 red, 8 green; 2 blue, 9 green, 5 red\r\nGame 84: 9 green, 14 red, 11 blue; 1 green, 12 blue, 6 red; 12 green, 10 red, 7 blue; 15 green, 6 blue; 15 blue, 4 red, 6 green; 16 green, 2 red, 13 blue\r\nGame 85: 7 red, 7 blue, 3 green; 5 green, 1 blue; 6 red, 11 green, 7 blue\r\nGame 86: 9 green, 6 blue, 6 red; 3 red, 2 blue, 7 green; 4 red, 4 green, 7 blue; 10 blue, 10 green, 2 red; 5 green\r\nGame 87: 6 green, 5 blue; 15 blue, 9 green, 1 red; 14 blue, 15 green\r\nGame 88: 3 blue, 2 green, 5 red; 8 blue, 1 green, 2 red; 5 red, 8 blue, 1 green; 1 red, 1 blue; 1 green, 6 red, 2 blue; 1 green, 2 red, 1 blue\r\nGame 89: 4 blue, 3 green; 1 blue, 2 red; 2 red, 1 green, 4 blue; 2 red, 2 blue, 1 green\r\nGame 90: 2 green, 1 red; 3 green, 8 red; 1 blue, 6 red, 4 green\r\nGame 91: 3 red; 1 blue, 6 red; 1 blue, 5 red, 1 green\r\nGame 92: 6 red, 9 green, 7 blue; 9 green, 4 red; 2 green, 5 blue\r\nGame 93: 7 green, 1 red; 3 blue, 3 red; 3 green, 9 red, 4 blue; 2 red, 6 green; 5 red, 3 blue\r\nGame 94: 4 green, 11 red; 13 green, 9 red; 16 green, 11 red; 6 green, 2 blue, 14 red; 17 green, 9 red\r\nGame 95: 7 red, 13 blue, 2 green; 8 green, 13 blue, 3 red; 5 green, 6 red, 13 blue; 8 green, 8 blue, 2 red; 6 blue, 4 green, 8 red; 2 blue, 2 red\r\nGame 96: 10 red, 3 blue, 3 green; 2 blue, 4 green, 5 red; 7 blue, 4 green, 6 red; 1 green, 4 red, 5 blue\r\nGame 97: 5 red, 8 blue; 4 green, 2 red, 14 blue; 10 blue, 7 green\r\nGame 98: 1 red, 2 green, 14 blue; 6 green, 1 blue; 19 blue, 4 red; 18 blue, 4 red, 3 green; 2 red, 1 blue\r\nGame 99: 3 red, 4 blue; 7 red, 5 blue, 3 green; 2 green, 1 blue, 1 red; 4 blue, 2 green, 1 red; 1 green, 1 red, 2 blue; 1 green, 6 blue, 7 red\r\nGame 100: 2 blue, 10 green; 10 green, 14 red; 3 green, 5 red, 2 blue; 1 red, 3 blue, 7 green; 1 blue, 7 red";
string[] split = data.Split("\r\n");
BagGrab legalBag = new BagGrab
{
	red = 12,
	green = 13,
	blue = 14
};
int result = 0;

PartOne();
PartTwo();



void PartTwo()
{
	foreach (string game in split)
	{
		result += CalcPower(game);
	}

	Console.WriteLine("Part two result: " + result);
}
int CalcPower(string game)
{
	List<BagGrab> bags = new List<BagGrab>();
	string trimmedGame = game.Split(':')[1];
	string[] bagGrabs = trimmedGame.Split(';');
	int minimumRed = 0;
	int minimumGreen = 0;
	int minimumBlue = 0;

	foreach (var bag in bagGrabs)
	{
		bags.Add(CreateBagGrab(bag));
	}

    foreach (var bag in bags)
    {
        if (bag.red > minimumRed) { minimumRed = bag.red; }
		if (bag.green > minimumGreen) { minimumGreen = bag.green; }
		if (bag.blue > minimumBlue) { minimumBlue = bag.blue; }
	}

	return minimumRed * minimumGreen * minimumBlue;
}

void PartOne()
{
	foreach (string game in split)
	{
		if (IsLegal(game))
		{
			string gameBeginning = game.Split(':')[0];
			int gameNumber = int.Parse(gameBeginning.Remove(0, 5));
			result += gameNumber;
		}
	}

	Console.WriteLine("Part one result: " + result);
}
bool IsLegal(string game)
{
	List<BagGrab> bags = new List<BagGrab>();
	string trimmedGame = game.Split(':')[1];
	string[] bagGrabs = trimmedGame.Split(';');

	foreach (var bag in bagGrabs)
	{
		bags.Add(CreateBagGrab(bag));
	}

	foreach (var bag in bags)
	{
		if (bag.red > legalBag.red) { return false; }
		if (bag.green > legalBag.green) { return false; }
		if (bag.blue > legalBag.blue) { return false; }
	}
	return true;

}

BagGrab CreateBagGrab(string grab)
{
	string[] pairs = grab.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
	BagGrab bag = new BagGrab();

	for (int i = 0; i < pairs.Length; i += 2)
	{
		string color = pairs[i + 1];
		int quantity = int.Parse(pairs[i]);

		switch (color)
		{
			case "red":
				bag.red = quantity;
				break;
			case "green":
				bag.green = quantity;
				break;
			case "blue":
				bag.blue = quantity;
				break;
		}
	}
	return bag;
}