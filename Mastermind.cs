using System;
using System.Collections.Generic;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = new string[] { "red", "yellow", "blue" };
            List<string> userGuess = new List<string>();
            List<string> computerAnswer = new List<string>();
            Random color = new Random();

            computerAnswer.Add(colors[color.Next(0, 3)]);
            computerAnswer.Add(colors[color.Next(0, 3)]);

            bool isPlaying = true;
            while(isPlaying)
            {
                Console.WriteLine("Welcome to Mastermind, can you out think a computer?");
                Console.WriteLine("Please pick colors from red, blue or yellow. You can pick repeats.");
                userGuess.Add(Console.ReadLine().ToLower());
                Console.WriteLine("Please pick another color between red, blue, or yellow.");
                userGuess.Add(Console.ReadLine().ToLower());

                Console.WriteLine($"{computerAnswer[0]} - {computerAnswer[1]}");

                if (userGuess[0].Equals(computerAnswer[0]) && userGuess[1].Equals(computerAnswer[1]))
                {
                    Console.WriteLine("You guessed right. Guess you are smarter than a computer.");
                    break;
                }
                else if (userGuess[0].Equals(computerAnswer[0]) || userGuess[1].Equals(computerAnswer[1]))
                {
                    Console.WriteLine("\n0 - 1. You guessed one of the colors in the correct position.");
                }
                else if (userGuess.Contains(computerAnswer[0]) || userGuess.Contains(computerAnswer[1]))
                {
                    if (userGuess[0].Equals(computerAnswer[1]) && userGuess[1].Equals(computerAnswer[0]))
                    {
                        Console.WriteLine("\n2 - 0. You guessed both of the colors but in the wrong order.");
                    } 
                    else
                    {
                        Console.WriteLine("\n1 - 0. You guessed one of the colors correctly but not in correct position.");
                    }
                }
                else
                {
                    Console.WriteLine("\n0 - 0. You guess wrong on both accounts, try again.");
                }
            }
        }

    }
}
