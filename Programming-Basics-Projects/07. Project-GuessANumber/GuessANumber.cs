﻿using System;

namespace GuessANumber
{
    public class Program
    {
        public static void Main()
        {
            //test
            Random randomNumber = new Random();
            int computerNumer = randomNumber.Next(1, 101);

            while (true)
            {
                Console.Write("Guess a number (1-100): ");

                string playerInput = Console.ReadLine();
                bool isValid = int.TryParse(playerInput, out int playerNumber);

                if (isValid)
                {
                    if (playerNumber == computerNumer)
                    {
                        Console.WriteLine("You guessed it!");
                        break;
                    }
                    else if (playerNumber > computerNumer)
                    {
                        Console.WriteLine("Too High");
                    }
                    else
                    {
                        Console.WriteLine("Too Low");
                    }   
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }
    }
}
