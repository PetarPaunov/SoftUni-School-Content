using System;
using System.Threading;


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
	@"          ║   " + '\n' +
	@"      .   ║   " + '\n' +
	@"          ║   " + '\n' +
	@" __/══════╩═══",
    //
    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"          ║   " + '\n' +
	@"      '   ║   " + '\n' +
	@" __/══════╩═══",
    //
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
│         Good job          │
│   you guessed the word!!  │
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
│   LLLLLLLLL   OOOO    SSSS   SSSS  |
│                                    |
│        You were so close           │
│ next time you will guess the word!!│
└────────────────────────────────────┘
";

string[] words = { "play", "jazz", "music", "unbelievable", "love", "luck" };

Console.CursorVisible = false;

while (true)
{
	string word = GetRandomWord(words);
	char[] wordSymbols = word.ToCharArray();

	int incorectGuess = 0;
	int guessCount = 0;

	string wordToGuess = new String('_', wordSymbols.Length);
	char[] wordToGuessChar = wordToGuess.ToCharArray();

	DrowOnTheConsole(frames, incorectGuess, wordToGuess, wordSymbols);

	char playerLetter = char.Parse(Console.ReadLine());

	while (true)
	{
		bool isContained = false;
		string tempWord = "";

		for (int i = 0; i < wordSymbols.Length; i++)
		{
			if (playerLetter == wordSymbols[i])
			{
				isContained = true;
			}
		}

		if (isContained)
		{
			for (int i = 0; i < wordToGuessChar.Length; i++)
			{
				if (playerLetter == wordSymbols[i])
				{
					guessCount++;
					wordToGuessChar[i] = playerLetter;
				}
			}

			for (int i = 0; i < wordToGuessChar.Length; i++)
			{
				tempWord += wordToGuessChar[i];
			}
		}
		else
		{
			incorectGuess++;
		}

		DrowOnTheConsole(frames, incorectGuess, tempWord, wordSymbols);

		if (guessCount == wordToGuess.Length)
		{
			Console.Clear();
			Console.WriteLine(Win);
			break;
		}

		if (incorectGuess == frames.Length - 1)
		{
			Console.SetCursorPosition(0, 0);
			DrowDeathAnimation(deathAnimation);
			Console.Clear();
			Console.WriteLine(Loss);
			break;
		}

		playerLetter = char.Parse(Console.ReadLine());
	}

	Console.Write("If you want to play again type 'yes' else type 'no': ");
	string playerChoice = Console.ReadLine();

	if (playerChoice == "no")
	{
		Console.Clear();
		Console.WriteLine("Thank you for playing Hangman was closed!");
		break;
	}

	Console.Clear();
}

static void DrowDeathAnimation(string[] deathAnimation)
{
	for (int i = 0; i < deathAnimation.Length; i++)
	{
		Console.WriteLine(deathAnimation[i]);
		Thread.Sleep(200);
		Console.SetCursorPosition(0, 0);
	}
}

static void DrowOnTheConsole(string[] frames, int incorectGuess, string remakedWord, char[] wordSymbols)
{
	Console.SetCursorPosition(0, 0);
	Console.WriteLine(frames[incorectGuess]);
	Console.WriteLine($"Guess: {remakedWord}");
	Console.WriteLine($"You have to guess {wordSymbols.Length} symbols.");
	Console.Write("Your symbol: ");
}

static string GetRandomWord(string[] words)
{
	Random random = new Random();
	string word = words[random.Next(words.Length)];
	return word;
}
