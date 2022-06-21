using System;

string[] frames =
{
	@"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"          ║   " + '\n' +
	@"          ║   " + '\n' +
	@"     ███  ║   " + '\n' +
	@"    ══════╩═══",
    // 1
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"          ║   " + '\n' +
	@"     ███  ║   " + '\n' +
	@"    ══════╩═══",
    // 2
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"     ███  ║   " + '\n' +
	@"    ══════╩═══",
    // 3
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"      |\  ║   " + '\n' +
	@"          ║   " + '\n' +
	@"     ███  ║   " + '\n' +
	@"    ══════╩═══",
    // 4
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"     /|\  ║   " + '\n' +
	@"          ║   " + '\n' +
	@"     ███  ║   " + '\n' +
	@"    ══════╩═══",
    // 5
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"     /|\  ║   " + '\n' +
	@"       \  ║   " + '\n' +
	@"     ███  ║   " + '\n' +
	@"    ══════╩═══",
    // 6
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"     /|\  ║   " + '\n' +
	@"     / \  ║   " + '\n' +
	@"     ███  ║   " + '\n' +
	@"    ══════╩═══"
};

string[] deathAnimation =
{
	@"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"     /|\  ║   " + '\n' +
	@"     / \  ║   " + '\n' +
	@"     ███  ║   " + '\n' +
	@"    ══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"     /|\  ║   " + '\n' +
	@"     / \  ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      o>  ║   " + '\n' +
	@"     /|   ║   " + '\n' +
	@"      >\  ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"     /|\  ║   " + '\n' +
	@"     / \  ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"     <o   ║   " + '\n' +
	@"      |\  ║   " + '\n' +
	@"     /<   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"     /|\  ║   " + '\n' +
	@"     / \  ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      o>  ║   " + '\n' +
	@"     /|   ║   " + '\n' +
	@"      >\  ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      o>  ║   " + '\n' +
	@"     /|   ║   " + '\n' +
	@"      >\  ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"     /|\  ║   " + '\n' +
	@"     / \  ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"     <o   ║   " + '\n' +
	@"      |\  ║   " + '\n' +
	@"     /<   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"     <o   ║   " + '\n' +
	@"      |\  ║   " + '\n' +
	@"     /<   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"     <o   ║   " + '\n' +
	@"      |\  ║   " + '\n' +
	@"     /<   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"     /|\  ║   " + '\n' +
	@"     / \  ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      o   ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      o   ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      o   ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      o   ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      o   ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      o   ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"    ══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"      /   ║   " + '\n' +
	@"      \   ║   " + '\n' +
	@"    ══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"      '   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    |__   ║   " + '\n' +
	@"    ══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"      .   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    \__   ║   " + '\n' +
	@"    ══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"      '   ║   " + '\n' +
	@"   ____   ║   " + '\n' +
	@"    ══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"      '   ║   " + '\n' +
	@"      .   ║   " + '\n' +
	@"    __    ║   " + '\n' +
	@"   /══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"      .   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    _ '   ║   " + '\n' +
	@"  _/══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"      '   ║   " + '\n' +
	@"      _   ║   " + '\n' +
	@" __/══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"      '   ║   " + '\n' +
	@"      .   ║   " + '\n' +
	@"          ║   " + '\n' +
	@" __/══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"      .   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"      '   ║   " + '\n' +
	@" __/══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"      '   ║   " + '\n' +
	@"      _   ║   " + '\n' +
	@" __/══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"      '   ║   " + '\n' +
	@"      .   ║   " + '\n' +
	@"          ║   " + '\n' +
	@" __/══════╩═══",

	@"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"      .   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"      '   ║   " + '\n' +
	@" __/══════╩═══",

	@"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"      '   ║   " + '\n' +
	@"      _   ║   " + '\n' +
	@" __/══════╩═══",

	@"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"      .   ║   " + '\n' +
	@"          ║   " + '\n' +
	@" __/══════╩═══",

	@"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"          ║   " + '\n' +
	@"      '   ║   " + '\n' +
	@" __/══════╩═══",

	@"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"          ║   " + '\n' +
	@"      _   ║   " + '\n' +
	@" __/══════╩═══"
};

const string Win = @"
┌───────────────────────────┐
│                           │
│ WW       WW  **  NN   N   │
│ WW       WW  ii  NNN  N   │
│  WW  WW WW   ii  N NN N   │
│   WWWWWWW    ii  N  NNN   │
│    WW  W     ii  N   NN   │
│                           │
│         Good job!         │
│   You guessed the word!   │
└───────────────────────────┘
";

const string Loss = @"
┌────────────────────────────────────┐
│  LLL          OOOO    SSSS   SSSS  │
│  LLL         OO  OO  SS  SS SS  SS │
│  LLL        OO    OO SS     SS     │
│  LLL        OO    OO  SSSS   SSSS  │
│  LLL        OO    OO     SS     SS │
│  LLLLLLLLLL  OO  OO  SS  SS SS  SS │
│   LLLLLLLLL   OOOO    SSSS   SSSS  │
│                                    |
│        You were so close.          │
│ Next time you will guess the word! │
└────────────────────────────────────┘
";
//Reading the words from the Words.txt file
string currentDirectory = Directory.GetCurrentDirectory();
string projectDirectory = Directory.GetParent(currentDirectory).Parent.Parent.FullName;

string path = ($"{projectDirectory}\\Words.txt");

string[] words = File.ReadAllLines(path);

Console.CursorVisible = false;

while (true)
{
	string word = GetRandomWord(words);
	char[] wordSymbols = word.ToCharArray();

	int incorectGuessNum = 0;
	int guessCount = 0;

	string wordToGuess = new String('_', wordSymbols.Length);
	char[] wordToGuessChar = wordToGuess.ToCharArray();

	DrawOnTheConsole(frames, incorectGuessNum, wordToGuess, wordSymbols);

	char playerLetter = char.Parse(Console.ReadLine());

	while (true)
	{
		bool isContained = false;
		string tempWord = "";
		//Check if the player has guessed any of the letters of the current word
		for (int i = 0; i < wordSymbols.Length; i++)
		{
			if (playerLetter == wordSymbols[i])
			{
				isContained = true;
			}
		}

		if (isContained)
		{
			//Going through all the letters and compare them with the player's letter
			for (int i = 0; i < wordToGuessChar.Length; i++)
			{
				if (playerLetter == wordSymbols[i])
				{
					guessCount++;
					wordToGuessChar[i] = playerLetter;
				}
			}
			//Recording all guessed letters in tempWord
			for (int i = 0; i < wordToGuessChar.Length; i++)
			{
				tempWord += wordToGuessChar[i];
			}
		}
		else
		{
			incorectGuessNum++;
		}

		DrawOnTheConsole(frames, incorectGuessNum, tempWord, wordSymbols);
		//Check if the player has guessed the word
		if (guessCount == wordToGuess.Length)
		{
			Console.Clear();
			Console.WriteLine(Win);
			break;
		}
		//Check if the player has not guessed the word
		if (incorectGuessNum == frames.Length - 1)
		{
			Console.SetCursorPosition(0, 0);
			DrawDeathAnimation(deathAnimation);
			Console.Clear();
			Console.WriteLine(Loss);
			break;
		}

		playerLetter = char.Parse(Console.ReadLine());
	}

	Console.Write("If you want to play again, press [Enter]. Else, type 'quit': ");
	string playerChoice = Console.ReadLine();

	if (playerChoice == "quit")
	{
		Console.Clear();
		Console.WriteLine("Thank you for playing! Hangman was closed.");
		break;
	}

	Console.Clear();
}

static void DrawDeathAnimation(string[] deathAnimation)
{
	//Render the death animation
	for (int i = 0; i < deathAnimation.Length; i++)
	{
		Console.WriteLine(deathAnimation[i]);
		Thread.Sleep(200);
		Console.SetCursorPosition(0, 0);
	}
}

static void DrawOnTheConsole(string[] frames, int incorrectGuess, string guessedWord, char[] wordSymbols)
{
	//Drawing current state of the game 
	Console.SetCursorPosition(0, 0);
	Console.WriteLine(frames[incorrectGuess]);
	Console.WriteLine($"Guess: {guessedWord}");
	Console.WriteLine($"You have to guess {wordSymbols.Length} symbols.");
	Console.Write("Your symbol: ");
}

static string GetRandomWord(string[] words)
{
	//Selecting a word in a random index
	Random random = new Random();
	string word = words[random.Next(words.Length)];
	return word;
}
