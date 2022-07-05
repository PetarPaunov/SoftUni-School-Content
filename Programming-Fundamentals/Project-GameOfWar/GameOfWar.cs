using System;
using GameOfWar;
using System.Collections.Generic;

Console.WriteLine(@"
================================================================================
||                     Welcome to the Game of War!                            ||
||                                                                            ||
|| HOW TO PLAY:                                                               ||
|| + Each of the two players are dealt one half of a shuffled deck of cards.  ||
|| + Each turn, each player draws one card from their deck.                   ||
|| + The player that drew the card with higher value gets both cards.         ||
|| + Both cards return to the winner's deck.                                  ||
|| + If there is a draw, the cards are returned to the player's deck.         ||
||    - Both players place the next three cards face down and then another    ||
||      card face-up. The owner of the higher face-up card gets all the cards ||
||      on the table.                                                         ||
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
    string[] firstTwoDrawnCards = deck.Take(2).ToArray();
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

    Queue<string> pool = new Queue<string>();

    pool.Enqueue(firstPlayerCard);
    pool.Enqueue(secondPlayerCard);

    // Compare the cards and determine the winner of the current round
    int firstPlayerCardPower = CardPower(firstPlayerCard);
    int secondPlayerCardPower = CardPower(secondPlayerCard);

    while (firstPlayerCardPower == secondPlayerCardPower)
    {
        Console.WriteLine("WAR!");

        //If one player has less than 4 cards, the other player automatically wins.
        if (firstPlayerDeck.Count < 4)
        {
            while (firstPlayerDeck.Count > 0)
            {
                secondPlayerDeck.Enqueue(firstPlayerDeck.Dequeue());
            }
            break;
        }

        if (secondPlayerDeck.Count < 4)
        {
            while (secondPlayerDeck.Count > 0)
            {
                firstPlayerDeck.Enqueue(secondPlayerDeck.Dequeue());
            }
            break;
        }

        //Add three cards from both players to the pool
        for (int i = 0; i < 3; i++)
        {
            pool.Enqueue(firstPlayerDeck.Dequeue());
        }

        for (int i = 0; i < 3; i++)
        {
            pool.Enqueue(secondPlayerDeck.Dequeue());
        }

        firstPlayerCard = firstPlayerDeck.Dequeue();
        Console.WriteLine($"First player has drawn: {firstPlayerCard}");
        firstPlayerCardPower = CardPower(firstPlayerCard);

        secondPlayerCard = secondPlayerDeck.Dequeue();
        Console.WriteLine($"Second player has drawn: {secondPlayerCard}");
        secondPlayerCardPower = CardPower(secondPlayerCard);

        pool.Enqueue(firstPlayerCard);
        pool.Enqueue(secondPlayerCard);
    }

    if (firstPlayerCardPower > secondPlayerCardPower)
    {
        Console.WriteLine("The first player has won the cards!");
        // The winner of the round gets both cards
        foreach (var card in pool)
        {
            firstPlayerDeck.Enqueue(card);
        }
    }
    else
    {
        Console.WriteLine("The second player has won the cards!");
        // The winner of the round gets both cards
        foreach (var card in pool)
        {
            secondPlayerDeck.Enqueue(card);
        }
    }

    Console.WriteLine("================================================================================");
    Console.WriteLine($"First player currently has {firstPlayerDeck.Count} cards.");
    Console.WriteLine($"Second player currently has {secondPlayerDeck.Count} cards.");
    Console.WriteLine("================================================================================");

    totalMoves++;

    //Check who is the winner
    if (!firstPlayerDeck.Any())
    {
        Console.WriteLine($"After a total of {totalMoves} moves, the second player has won!");
        break;
    }

    if (!secondPlayerDeck.Any())
    {
        Console.WriteLine($"After a total of {totalMoves} moves, the first player has won!");
        break;
    }
}

static List<string> GenerateDeck()
{
    List<string> deck = new List<string>();

    var faces = (CardFace[])Enum.GetValues(typeof(CardFace));
    string[] suites = { "Spades", "Hearts", "Clubs", "Diamonds" };

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