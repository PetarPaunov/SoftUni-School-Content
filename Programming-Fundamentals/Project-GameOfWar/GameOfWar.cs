using System;
using GameOfWar;
using System.Collections.Generic;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("♠ ♣ ♥ ♦ ♤ ♧ ♡ ♢");


Console.WriteLine(@"
================================================================================
||                     Welcome to the Game of War!                            ||
||                                                                            ||
|| HOW TO PLAY:                                                               ||
|| + Each of the two players are dealt one half of a shuffled deck of cards.  ||
|| + Each turn, each player draws one card from their deck.                   ||
|| + The player that drew the card with higher value gets both cards.         ||
|| + Both cards return to the winner's deck.                                  ||
|| + If there is a draw, both players place the next three cards face down    ||
||        and then another card face-up. The owner of the higher face-up      ||
||        card gets all the cards on the table.                               ||
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
List<Card> deck = GenerateDeck();
ShuffleDeck(deck);

Queue<Card> firstPlayerDeck = new Queue<Card>();
Queue<Card> secondPlayerDeck = new Queue<Card>();

// Deal the cards to the players
while (deck.Count > 0)
{
    Card[] firstTwoDrawnCards = deck.Take(2).ToArray();
    deck.RemoveRange(0, 2);
    firstPlayerDeck.Enqueue(firstTwoDrawnCards[0]);
    secondPlayerDeck.Enqueue(firstTwoDrawnCards[1]);
}

int totalMoves = 0;

while (true)
{
    Console.ReadLine();

    // Draw and show the cards from both players' decks 

    Card firstPlayerCard = firstPlayerDeck.Dequeue();
    Console.WriteLine($"First player has drawn: {firstPlayerCard}");

    Card secondPlayerCard = secondPlayerDeck.Dequeue();
    Console.WriteLine($"Second player has drawn: {secondPlayerCard}");

    Queue<Card> pool = new Queue<Card>();

    pool.Enqueue(firstPlayerCard);
    pool.Enqueue(secondPlayerCard);

    // Compare the cards and determine the winner of the current round

    while (firstPlayerCard.Power == secondPlayerCard.Power)
    {
        Console.WriteLine("WAR!");

        // If one player has less than 4 cards, the other player automatically wins.
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

        secondPlayerCard = secondPlayerDeck.Dequeue();
        Console.WriteLine($"Second player has drawn: {secondPlayerCard}");

        pool.Enqueue(firstPlayerCard);
        pool.Enqueue(secondPlayerCard);
    }

    if (firstPlayerCard.Power > secondPlayerCard.Power)
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

static List<Card> GenerateDeck()
{
    List<Card> deck = new List<Card>();

    CardFace[] faces = (CardFace[])Enum.GetValues(typeof(CardFace));
    char[] suits = { '♠', '♣', '♥', '♦' };

    for (int i = 0; i < suits.Length; i++)
    {
        for (int j = 0; j < faces.Length; j++)
        {
            string face = faces[j].ToString();
            int cardPower = (int)Enum.Parse(typeof(CardFace), face);

            deck.Add(new Card
            { 
                Face = face[face.Length - 1], 
                Suite = suits[i],
                Power = cardPower,
            });
        }
    }

    return deck;
}

static void ShuffleDeck(List<Card> deck)
{
    Random random = new Random();

    for (int i = 0; i < deck.Count; i++)
    {
        int firstCardIndex = random.Next(deck.Count);

        Card tempCard = deck[firstCardIndex];

        deck[firstCardIndex] = deck[i];
        deck[i] = tempCard;
    }
}