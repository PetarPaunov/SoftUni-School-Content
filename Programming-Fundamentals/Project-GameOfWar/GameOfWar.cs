using GameOfWar;
using System;
using System.Collections.Generic;

Console.WriteLine(@"
================================================================================
||                     Welcome to the game of War!                            ||
||                                                                            ||
|| HOW TO PLAY:                                                               ||
|| + Each of the two players is dealt one half of a shuffled deck of cards.   ||
|| + Each turn, each player draws one card from their deck.                   ||
|| + The player that drew the card with higher value gets both cards.         ||
|| + Winning cards return to the winner's deck and get reshuffled.            ||
|| + If there is a draw, the cards are thrown away.                           ||
||                                                                            ||
|| HOW TO WIN:                                                                ||
|| + The player that runs out of cards first, wins.                           ||
||                                                                            ||
|| CONTROLS:                                                                  ||
|| + Press [Enter] to draw a new card until we have a winner.                 ||
||                                                                            ||
||                              Have fun!                                     ||
================================================================================");

// Generate and shuffle the deck
List<string> deck = GenerateDeck();
ShuffleDeck(deck);

Queue<string> firstPlayerDeck = new Queue<string>();
Queue<string> secondPlayerDeck = new Queue<string>();

// Deal the cards to the players
while (deck.Count > 0)
{
    var firstTwoDrawnCards = deck.Take(2).ToArray();
    deck.RemoveRange(0, 2);
    firstPlayerDeck.Enqueue(firstTwoDrawnCards[0]);
    secondPlayerDeck.Enqueue(firstTwoDrawnCards[1]);
}

int totalMoves = 0;

while (true)
{
    Console.ReadLine();

    // Draw and show the cards from both players' decks 
    string firstPlayerCard = firstPlayerDeck.Dequeue();
    Console.WriteLine($"First player has drawn: {firstPlayerCard}");

    string secondPlayerCard = secondPlayerDeck.Dequeue();
    Console.WriteLine($"Second player has drawn: {secondPlayerCard}");

    // Compare the cards and determine the winner of the current round
    int firstPlayerCardPower = CardPower(firstPlayerCard);
    int secondPlayerCardPower = CardPower(secondPlayerCard);

    Queue<string> roundWinnerDeck = new Queue<string>();
    if (firstPlayerCardPower == secondPlayerCardPower)
    {
        Console.WriteLine("It's a draw!");
    }
    else if (firstPlayerCardPower > secondPlayerCardPower)
    {
        Console.WriteLine("The first player has won the cards!");
        roundWinnerDeck = firstPlayerDeck;
    }
    else
    {
        Console.WriteLine("The second player has won the cards!");
        roundWinnerDeck = secondPlayerDeck;
    }

    // The winner of the round gets both cards
    roundWinnerDeck.Enqueue(firstPlayerCard);
    roundWinnerDeck.Enqueue(secondPlayerCard);

    // Reshuffling the winner's deck
    ReshufflePlayerDeck(roundWinnerDeck);

    Console.WriteLine("================================================================================");
    Console.WriteLine($"First player currently has {firstPlayerDeck.Count} cards.");
    Console.WriteLine($"Second player currently has {secondPlayerDeck.Count} cards.");
    Console.WriteLine("================================================================================");

    totalMoves++;

    //Check who is the winner
    if (firstPlayerDeck.Count == 0)
    {
        Console.WriteLine($"After a total of {totalMoves} moves, the second player has won!");
        break;
    }

    if (secondPlayerDeck.Count == 0)
    {
        Console.WriteLine($"After a total of {totalMoves} moves, the first player has won!");
        break;
    }
}

static void ReshufflePlayerDeck(Queue<string> deck)
{
    List<string> playerDeck = deck.ToList();
    ShuffleDeck(playerDeck);

    deck.Clear();

    for (int i = 0; i < playerDeck.Count; i++)
    {
        deck.Enqueue(playerDeck[i]);
    }
}

static int CardPower(string cardName)
{
    var face = cardName.Split(" ").ToArray()[0];

    int cardPower = (int)Enum.Parse(typeof(CardFace), face);

    return cardPower;
}

static void ShuffleDeck(List<string> deck)
{
    Random random = new Random();

    for (int i = 0; i < deck.Count; i++)
    {
        int firstCardIndex = random.Next(i);

        string tempCard = deck[firstCardIndex];
        deck[firstCardIndex] = deck[i];
        deck[i] = tempCard;
    }
}

static List<string> GenerateDeck()
{
    List<string> deck = new List<string>();

    var faces = (CardFace[])Enum.GetValues(typeof(CardFace));

    var suites = new string[] { "Spades", "Hearts", "Clubs", "Diamonds" };

    for (int i = 0; i < suites.Length; i++)
    {
        for (int j = 0; j < faces.Length; j++)
        {
            deck.Add($"{faces[j]} of {suites[i]}");
        }
    }

    return deck;
}