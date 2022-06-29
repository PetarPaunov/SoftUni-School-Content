using System;

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

const char Underscore = '_';

const int MaxAllowedIncorrectCharacters = 6;

string[] wrongGuessesFrames =
{
	@"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"          ║   " + '\n' +
	@"          ║   " + '\n' +
	@"     ███  ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"          ║   " + '\n' +
	@"     ███  ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"     ███  ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"      |\  ║   " + '\n' +
	@"          ║   " + '\n' +
	@"     ███  ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"     /|\  ║   " + '\n' +
	@"          ║   " + '\n' +
	@"     ███  ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"     /|\  ║   " + '\n' +
	@"       \  ║   " + '\n' +
	@"     ███  ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"     /|\  ║   " + '\n' +
	@"     / \  ║   " + '\n' +
	@"     ███  ║   " + '\n' +
	@"    ══════╩═══"
};

string[] deathAnimationFrames =
{
	@"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"     /|\  ║   " + '\n' +
	@"     / \  ║   " + '\n' +
	@"     ███  ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"     /|\  ║   " + '\n' +
	@"     / \  ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      o>  ║   " + '\n' +
	@"     /|   ║   " + '\n' +
	@"      >\  ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"     /|\  ║   " + '\n' +
	@"     / \  ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"     <o   ║   " + '\n' +
	@"      |\  ║   " + '\n' +
	@"     /<   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"     /|\  ║   " + '\n' +
	@"     / \  ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      o>  ║   " + '\n' +
	@"     /|   ║   " + '\n' +
	@"      >\  ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      o>  ║   " + '\n' +
	@"     /|   ║   " + '\n' +
	@"      >\  ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"     /|\  ║   " + '\n' +
	@"     / \  ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"     <o   ║   " + '\n' +
	@"      |\  ║   " + '\n' +
	@"     /<   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"     <o   ║   " + '\n' +
	@"      |\  ║   " + '\n' +
	@"     /<   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"     <o   ║   " + '\n' +
	@"      |\  ║   " + '\n' +
	@"     /<   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"     /|\  ║   " + '\n' +
	@"     / \  ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      o   ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      o   ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      o   ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      o   ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      o   ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      o   ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      |   ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"      /   ║   " + '\n' +
	@"      \   ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"      '   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    |__   ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"      .   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    \__   ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"      '   ║   " + '\n' +
	@"   ____   ║   " + '\n' +
	@"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"      '   ║   " + '\n' +
	@"      .   ║   " + '\n' +
	@"    __    ║   " + '\n' +
	@"   /══════╩═══",

    @"      ╔═══╗   " + '\n' +
	@"      |   ║   " + '\n' +
	@"      O   ║   " + '\n' +
	@"      .   ║   " + '\n' +
	@"          ║   " + '\n' +
	@"    _ '   ║   " + '\n' +
	@"  _/══════╩═══",

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

//Reading the words from the words.txt file
string currentDirectory = Directory.GetCurrentDirectory();
string projectDirectory = Directory.GetParent(currentDirectory).Parent.Parent.FullName;

string path = $@"{projectDirectory}\words.txt";

string[] words = File.ReadAllLines(path);

Console.CursorVisible = false;

while (true)
{
	string word = GetRandomWord(words);

	string wordToGuess = new String(Underscore, word.Length);
	int incorrectGuessCount = 0;
	DrawOnTheConsole(wrongGuessesFrames, incorrectGuessCount, wordToGuess);

	char[] wordToGuessChar = wordToGuess.ToCharArray();

	string playerInput = Console.ReadLine();

	while (true)
	{
		if (playerInput.Length != 1)
        {
            Console.WriteLine("You should type only a single character!");
			playerInput = Console.ReadLine();
			continue;
        }
		
		var playerLetter = char.Parse(playerInput);
		
		if (word.Contains(playerLetter))
		{
			//Going through all the letters and compare them with the player's letter
			for (int i = 0; i < wordToGuessChar.Length; i++)
			{
				if (playerLetter == word[i])
				{
					wordToGuessChar[i] = playerLetter;
				}
			}
		}
		else
		{
			incorrectGuessCount++;
		}

		DrawOnTheConsole(wrongGuessesFrames, incorrectGuessCount, new string(wordToGuessChar));

		//Check if the player has guessed the word
		if (!wordToGuessChar.Contains(Underscore))
		{
			Console.Clear();
			Console.WriteLine(Win);
			Console.WriteLine($"The word you guessed is [{word}].");
			break;
		}

		//Check if the player has not guessed the word
		if (incorrectGuessCount == MaxAllowedIncorrectCharacters)
		{
			Console.SetCursorPosition(0, 0);
			DrawDeathAnimation(deathAnimationFrames);
			Console.Clear();
			Console.WriteLine(Loss);
            Console.WriteLine($"The exact word is [{word}].");
			break;
		}

		playerInput = Console.ReadLine();
	}

	Console.Write("If you want to play again, press [Enter]. Else, type 'quit': ");
	playerInput = Console.ReadLine();

	if (playerInput == "quit")
	{
		Console.Clear();
		Console.WriteLine("Thank you for playing! Hangman was closed.");
		break;
	}

	Console.Clear();
}

static void DrawOnTheConsole(string[] wrongGuessesFrames, int incorrectGuess, string guessedWord)
{
	//Drawing current state of the game
	Console.Clear();
	Console.WriteLine(wrongGuessesFrames[incorrectGuess]);
	Console.WriteLine($"Guess: {guessedWord}");
	Console.WriteLine($"You have to guess {guessedWord.Length} symbols.");
	Console.Write("Your symbol: ");
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

static string GetRandomWord(string[] words)
{
	//Selecting a word in a random index
	Random random = new Random();
	string word = words[random.Next(words.Length)];
	return word;
}
