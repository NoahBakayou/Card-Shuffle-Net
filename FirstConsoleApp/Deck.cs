using System;

public class Deck
{
    private static string[] deck;

    public static void DeckMaker()
    {
        string[] suit = { "♠", "♦", "♣", "♥" };
        string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        deck = new string[52];

        // Creates the deck
        for (int i = 0; i < deck.Length; i++)
        {
            deck[i] = rank[i % 13] + suit[i / 13];
        }

        // Fisher-Yates shuffle algorithm
        Random random = new Random();
        for (int i = deck.Length - 1; i > 0; i--)
        {
            int index = random.Next(i + 1); // Random index from 0 to i
            string temp = deck[i];
            deck[i] = deck[index];
            deck[index] = temp;
        }

        // Print the shuffled deck
        foreach (string card in deck)
        {
            Console.WriteLine(card);
        }
    }
}

