using System;
using GameOfWar;
using System.Collections.Generic;

Console.WriteLine(@"
================================================================================
||                     Welcome to the Game of War!                            ||
||                                                                            ||
|| HOW TO PLAY:                                                               ||
|| + Each of the two players is dealt one half of a shuffled deck of cards.   ||
|| + Each turn, each player draws one card from their deck.                   ||
|| + The player that drew the card with higher value gets both cards.         ||
|| + Winning cards return to the winner's deck.                               ||
|| + If there is a draw, The cards are returned to the players deck.          ||
||                                                                            ||
|| HOW TO WIN:                                                                ||
|| + The player who collects all the cards wins.                              ||
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

    if (firstPlayerCardPower == secondPlayerCardPower)
    {
        Console.WriteLine("It's a draw!");
        // Each player gets their own card
        firstPlayerDeck.Enqueue(firstPlayerCard);
        secondPlayerDeck.Enqueue(secondPlayerCard);
    }
    else if (firstPlayerCardPower > secondPlayerCardPower)
    {
        Console.WriteLine("The first player has won the cards!");
        // The winner of the round gets both cards
        firstPlayerDeck.Enqueue(firstPlayerCard);
        firstPlayerDeck.Enqueue(secondPlayerCard);
    }
    else
    {
        Console.WriteLine("The second player has won the cards!");
        // The winner of the round gets both cards
        secondPlayerDeck.Enqueue(firstPlayerCard);
        secondPlayerDeck.Enqueue(secondPlayerCard);
    }

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

static void ShuffleDeck(List<string> deck)
{
    Random random = new Random();

    for (int i = 0; i < deck.Count; i++)
    {
        int firstCardIndex = random.Next(deck.Count);

        string tempCard = deck[firstCardIndex];
        deck[firstCardIndex] = deck[i];
        deck[i] = tempCard;
    }
}

static int CardPower(string cardName)
{
    var face = cardName.Split(" ").ToArray()[0];

    int cardPower = (int)Enum.Parse(typeof(CardFace), face);

    return cardPower;
}