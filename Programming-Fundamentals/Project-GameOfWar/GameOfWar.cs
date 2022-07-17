using System;
using GameOfWar;
using System.Text;
using System.Collections.Generic;

Console.OutputEncoding = Encoding.UTF8;

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
DealCardsToPlayer();

int totalMoves = 0;

while (!IsGameWinner())
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
    WarProcessing(firstPlayerCard, secondPlayerCard, pool);
    DeterminingRoundWinner(firstPlayerCard, secondPlayerCard, pool);

    Console.WriteLine("================================================================================");
    Console.WriteLine($"First player currently has {firstPlayerDeck.Count} cards.");
    Console.WriteLine($"Second player currently has {secondPlayerDeck.Count} cards.");
    Console.WriteLine("================================================================================");

    totalMoves++;
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

            if (cardPower == 10)
            {
                face = face.Substring(face.Length - 2, 2);
            }
            else
            {
                face = face.Substring(face.Length - 1, 1);
            }

            deck.Add(new Card
            { 
                Face = face,
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

void WarProcessing(Card firstPlayerCard, Card secondPlayerCard, Queue<Card> pool)
{
    while (firstPlayerCard.Power == secondPlayerCard.Power)
    {
        Console.WriteLine("WAR!");

        // If one player has less than 4 cards, the other player automatically wins.
        if (firstPlayerDeck.Count < 4)
        {
            AddCardsToWinnersDeck(firstPlayerDeck, secondPlayerDeck);
            break;
        }

        if (secondPlayerDeck.Count < 4)
        {
            AddCardsToWinnersDeck(secondPlayerDeck, firstPlayerDeck);
            break;
        }

        // Add three cards from both players to the pool
        AddCardsToPool(pool, firstPlayerDeck);
        AddCardsToPool(pool, secondPlayerDeck);

        firstPlayerCard = firstPlayerDeck.Dequeue();
        Console.WriteLine($"First player has drawn: {firstPlayerCard}");

        secondPlayerCard = secondPlayerDeck.Dequeue();
        Console.WriteLine($"Second player has drawn: {secondPlayerCard}");

        pool.Enqueue(firstPlayerCard);
        pool.Enqueue(secondPlayerCard);
    }
}

static void AddCardsToWinnersDeck(Queue<Card> firstDeck, Queue<Card> secondDeck)
{
    while (firstDeck.Count > 0)
    {
        secondDeck.Enqueue(firstDeck.Dequeue());
    }
}

static void AddCardsToPool(Queue<Card> pool, Queue<Card> playerDeck)
{
    for (int i = 0; i < 3; i++)
    {
        pool.Enqueue(playerDeck.Dequeue());
    }
}

void DeterminingRoundWinner(Card firstPlayerCard, Card secondPlayerCard, Queue<Card> pool)
{
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
}

bool IsGameWinner()
{
    // Check who is the winner

    if (!firstPlayerDeck.Any())
    {
        Console.WriteLine($"After a total of {totalMoves} moves, the second player has won!");
        return true;
    }

    if (!secondPlayerDeck.Any())
    {
        Console.WriteLine($"After a total of {totalMoves} moves, the first player has won!");
        return true;
    }

    return false;
}

void DealCardsToPlayer()
{
    while (deck.Count > 0)
    {
        Card[] firstTwoDrawnCards = deck.Take(2).ToArray();
        deck.RemoveRange(0, 2);
        firstPlayerDeck.Enqueue(firstTwoDrawnCards[0]);
        secondPlayerDeck.Enqueue(firstTwoDrawnCards[1]);
    }
}