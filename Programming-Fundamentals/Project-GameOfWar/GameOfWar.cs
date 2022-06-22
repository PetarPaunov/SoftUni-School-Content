using System;
using System.Collections.Generic;

string[] face = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
string[] suite = { "Spades", "Hearts", "Clubs", "Diamonds" };

Console.WriteLine(@"
================================================================================
||                     Welcome to the game of War!                            ||
||                                                                            ||
|| HOW TO PLAY:                                                               ||
|| + Each of the two players is dealt one half of a shuffled deck of cards.   ||
|| + Each turn, each player draws one card from their decks.                  ||
|| + The player that drew the card with higher value gets both cards.         ||
|| + Winning cards return to the winner's deck and get reshuffled.            ||
|| + If there is a draw, the cards are thrown away.                           ||
||                                                                            ||
|| HOW TO WIN:                                                                ||
|| + The player that runs out of cards first, wins.                           ||
||                                                                            ||
|| CONTROLS:                                                                  ||
|| + Press [Enter] to draw a new card.                                        ||
||                                                                            ||
||                              Have fun!                                     ||
================================================================================");
// Generate and shuffle the deck
List<string> deck = GenerateDeck(suite, face);
deck = ShuffleDeck(deck);

Queue<string> firstPlayerDeck = new Queue<string>();
Queue<string> secondPlayerDeck = new Queue<string>();
// deal the cards to the players
DealCards(deck, firstPlayerDeck, secondPlayerDeck);

int totalMoves = 0;

while (true)
{
    Console.ReadLine();
    // Draw and show the cards from both players' decks 
    string firstPlayerCard = firstPlayerDeck.Dequeue();
    string secondPlayerCard = secondPlayerDeck.Dequeue();

    Console.WriteLine($"First player has drawn: {firstPlayerCard}");
    Console.WriteLine($"Second player has drawn: {secondPlayerCard}");
    // Compare the cards and determine the winner of the current round
    int firstPlayerCardPower = CardPower(firstPlayerCard);
    int secondPlayerCardPower = CardPower(secondPlayerCard);

    if (firstPlayerCardPower == secondPlayerCardPower)
    {
        Console.WriteLine("It's a draw!");
    }
    else if (firstPlayerCardPower > secondPlayerCardPower)
    {
        Console.WriteLine("The first player has won the cards!");
        PlaceInDeck(firstPlayerDeck, firstPlayerCard, secondPlayerCard);
        ReshufflePlayerDeck(firstPlayerDeck);
    }
    else
    {
        Console.WriteLine("The second player has won the cards!");
        PlaceInDeck(secondPlayerDeck, firstPlayerCard, secondPlayerCard);
        ReshufflePlayerDeck(secondPlayerDeck);
    }

    Console.WriteLine(firstPlayerDeck.Count);
    Console.WriteLine(secondPlayerDeck.Count);

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

static void DealCards(List<string> deck, Queue<string> firstPlayerDeck, Queue<string> secondPlayerDeck)
{
    while (deck.Count > 0)
    {
        var firstTwoDrawnCards = deck.Take(2).ToArray();
        deck.RemoveRange(0, 2);
        firstPlayerDeck.Enqueue(firstTwoDrawnCards[0]);
        secondPlayerDeck.Enqueue(firstTwoDrawnCards[1]);
    }
}

static void ReshufflePlayerDeck(Queue<string> deck)
{
    List<string> playerDeck = deck.ToList();

    Random random = new Random();

    for (int i = 0; i < playerDeck.Count; i++)
    {
        int firstCardIndex = random.Next(i);

        string tempCard = playerDeck[firstCardIndex];
        playerDeck[firstCardIndex] = playerDeck[i];
        playerDeck[i] = tempCard;
    }

    deck.Clear();

    for (int i = 0; i < playerDeck.Count; i++)
    {
        deck.Enqueue(playerDeck[i]);
    }

}

static void PlaceInDeck(Queue<string> playerDeck, string firstCard, string secondCard)
{
    playerDeck.Enqueue(firstCard);
    playerDeck.Enqueue(secondCard);
}

static int CardPower(string cardName)
{
    int cardPower = 0;

    if (cardName.StartsWith("Two"))
    {
        cardPower = 2;
    }
    else if (cardName.StartsWith("Three"))
    {
        cardPower = 3;
    }
    else if (cardName.StartsWith("Four"))
    {
        cardPower = 4;
    }
    else if (cardName.StartsWith("Five"))
    {
        cardPower = 5;
    }
    else if (cardName.StartsWith("Six"))
    {
        cardPower = 6;
    }
    else if (cardName.StartsWith("Seven"))
    {
        cardPower = 7;
    }
    else if (cardName.StartsWith("Eight"))
    {
        cardPower = 8;
    }
    else if (cardName.StartsWith("Nine"))
    {
        cardPower = 9;
    }
    else if (cardName.StartsWith("Ten"))
    {
        cardPower = 10;
    }
    else if (cardName.StartsWith("Jack"))
    {
        cardPower = 11;
    }
    else if (cardName.StartsWith("Queen"))
    {
        cardPower = 12;
    }
    else if (cardName.StartsWith("King"))
    {
        cardPower = 13;
    }
    else if (cardName.StartsWith("Ace"))
    {
        cardPower = 14;
    }

    return cardPower;
}

static List<string> ShuffleDeck(List<string> deck)
{
    Random random = new Random();

    for (int i = 0; i < deck.Count; i++)
    {
        int firstCardIndex = random.Next(i);

        string tempCard = deck[firstCardIndex];
        deck[firstCardIndex] = deck[i];
        deck[i] = tempCard;
    }

    return deck;
}

static List<string> GenerateDeck(string[] suite, string[] face)
{
    List<string> deck = new List<string>();

    for (int i = 0; i < suite.Length; i++)
    {
        for (int j = 0; j < face.Length; j++)
        {
            deck.Add($"{face[j]} of {suite[i]}");
        }
    }

    return deck;
}