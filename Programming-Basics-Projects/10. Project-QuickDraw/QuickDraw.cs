using System;
using System.Diagnostics;

namespace QuickDraw
{
    public class Program
    {
        public static void Main()
        {
            Random random = new Random();
            
            const string Menu = @"
             Quick Draw 
             Face your opponent and wait for the signal. Once the
             signal is given, shoot your opponent by pressing [space]
             before they shoot you. It's all about your reaction time.
             Choose Your Opponent:
             [1] Easy....1000 milliseconds
             [2] Medium...500 milliseconds
             [3] Hard.....250 milliseconds
             [4] Harder...125 milliseconds";
            
            const string Wait = @"
                                                                  
                        _O                          O_            
                       |/|_          wait          _|\|           
                       /\                            /\           
                      /  |                          |  \          
            ------------------------------------------------------";
            
            const string Fire = @"
                                           
                                   ********                       
                                   * FIRE *                       
                        _O         ********         O_            
                       |/|_                        _|\|           
                       /\          spacebar          /\           
                      /  |                          |  \          
            ------------------------------------------------------";
            
            const string LoseTooSlow = @"                                         
            
                                              > ╗__O          
                               Too Slow           / \         
                O/__/\         You Lose          /\           
                     \                          |  \          
            ------------------------------------------------------";
            
            const string LoseTooFast = @"                            
                                                              
                               Too Fast       > ╗__O          
                               You Missed         / \         
                O/__/\         You Lose          /\           
                     \                          |  \          
            ------------------------------------------------------";
            
            const string Win = @"
                                                              
                  O__╔ <                                      
                 / \                               \\         
                   /\          You Win          /\__\O        
                  /  |                          /             
            ------------------------------------------------------";
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine(Menu);
            
                TimeSpan requiredReactionTime;
                string playerInput = Console.ReadLine();
            
                switch (playerInput)
                {
                    case "1":
                        requiredReactionTime = TimeSpan.FromMilliseconds(1000);
                        break;
                    case "2":
                        requiredReactionTime = TimeSpan.FromMilliseconds(0500);
                        break;
                    case "3":
                        requiredReactionTime = TimeSpan.FromMilliseconds(0250);
                        break;
                    case "4":
                        requiredReactionTime = TimeSpan.FromMilliseconds(0125);
                        break;
                    default:
                        continue;
                }
            
                Console.Clear();
            
                TimeSpan signal = TimeSpan.FromMilliseconds(random.Next(5000, 10000));
            
                Console.WriteLine(Wait);
            
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Restart();
            
                bool isTooFast = false;
            
                while (stopwatch.Elapsed < signal && !isTooFast)
                {
                    if (Console.KeyAvailable && Console.ReadKey().Key == ConsoleKey.Spacebar)
                    {
                        isTooFast = true;
                    }
                }
            
                Console.Clear();
            
                if (isTooFast)
                {
                    Console.WriteLine(LoseTooFast);
                }
                else
                {
                    Console.WriteLine(Fire);
            
                    stopwatch.Restart();
            
                    bool isTooSlow = true;
            
                    TimeSpan reactionTime = default;
            
                    while (stopwatch.Elapsed < requiredReactionTime && isTooSlow)
                    {
                        if (Console.KeyAvailable && Console.ReadKey().Key == ConsoleKey.Spacebar)
                        {
                            isTooSlow = false;
                            reactionTime = stopwatch.Elapsed;
                        }
                    }
            
                    Console.Clear();
            
                    if (isTooSlow)
                    {
                        Console.WriteLine(LoseTooSlow);
                    }
                    else
                    {
                        Console.WriteLine(Win);
                        Console.WriteLine($"Reaction Time: {reactionTime.TotalMilliseconds} milliseconds");
                    }
                }
            
                Console.Write("Press [1] to Play Again or [2] to quit: ");
                string playOrQuit = Console.ReadLine();
            
                if (playOrQuit == "2")
                {
                    Console.Clear();
                    Console.Write("Quick Draw was closed.");
                    break;
                }
            }   
        }
    }
}
