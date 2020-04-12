using System;

namespace RockPaperScissorGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int computerHand = random.Next(0, 3);

            Console.WriteLine("Type rock, paper or scissors");
            string answer = Console.ReadLine();
            //string answer = "rock";
            int convertAnswer = 0;
            if (answer.ToLower() == "rock") { convertAnswer = 0; }
            else if (answer.ToLower() == "paper") { convertAnswer = 1; }
            else if (answer.ToLower() == "scissors") { convertAnswer = 2; }

            string[] hands = {"rock", "paper", "scissors"};
            Console.WriteLine("Computer choose: " + hands[computerHand]);
            Console.WriteLine("Player choose: " + hands[convertAnswer]);

            if (hands[computerHand] == "rock" && answer.ToLower() == "rock") { Console.WriteLine("draw"); }
            else if (hands[computerHand] == "rock" && answer.ToLower() == "scissors") { Console.WriteLine("computer wins"); }
            else if (hands[computerHand] == "rock" && answer.ToLower() == "paper") { Console.WriteLine("player wins"); }
            else if (hands[computerHand] == "paper" && answer.ToLower() == "rock") { Console.WriteLine("computer wins"); }
            else if (hands[computerHand] == "paper" && answer.ToLower() == "scissors") { Console.WriteLine("player wins"); }
            else if (hands[computerHand] == "paper" && answer.ToLower() == "paper") { Console.WriteLine("draw"); }
            else if (hands[computerHand] == "scissors" && answer.ToLower() == "rock") { Console.WriteLine("player wins"); }
            else if (hands[computerHand] == "scissors" && answer.ToLower() == "scissors") { Console.WriteLine("draw"); }
            else if (hands[computerHand] == "scissors" && answer.ToLower() == "paper") { Console.WriteLine("computer wins"); }
             
        }

        //static String CompareHands(String hand1, String hand2);
    }
}
