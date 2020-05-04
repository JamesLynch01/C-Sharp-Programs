using System;
using System.Collections;
using System.Collections.Generic;

namespace TowerOfHanoi
{
    class Program
    {
        //the placement of the disks are kept in this Dictionary.
        private static Dictionary<string, Stack<int>> Pillar = new Dictionary<string, Stack<int>>(); 
        static void Main(string[] args)
        {
            
            
            {
                // this part of the code helps set up the board.
                // here I have made a new stack for all my disks to behold at the start of the game.
                Stack<int> disks = new Stack<int>();
                // these next four lines are the number of disk the user has to play with.
                disks.Push(4);
                disks.Push(3);
                disks.Push(2);
                disks.Push(1);
                // and here is the three towers that make up the game board.
                Pillar.Add("A", disks);
                Pillar.Add("B", new Stack<int>());
                Pillar.Add("C", new Stack<int>());
                
                //Now we get to the actually game.
                do
                {
                    //the first couple lines present the game board to the user
                    Console.Clear();
                    PrintPillar();
                    //the next four lines, I am asking the user for input, or where to put one of the disks.
                    Console.WriteLine("Enter the tower to move From.");
                    string from = Console.ReadLine().ToUpper();
                    Console.WriteLine("Enter the tower to move TO.");
                    string to = Console.ReadLine().ToUpper();

                    // after the user provides the game with input, the method below will check if it's a valid move, skip to line 68 for this method
                    //I have a if/else conditional, if the move was valid, then disk is first pop out of it's current pillar
                    //then push into a new Pillar, otherwise, it will return a not valid message. 
                    if (IsMoveValid(from, to))
                    {
                        
                        Pillar[to].Push(Pillar[from].Pop());
                    }
                    else
                    {
                        Console.WriteLine("Move was not valid.");
                        Console.WriteLine("Press any key to try again.");
                        Console.ReadKey();
                    }

                    //after the validity of a move is check, then the program will check the win condition method, skip to line 101 for this method.
                    //if the user doesn't yet win, it will loop back up and do this whole process over.
                } while (!CheckWin());

                //if the user clear all the hoops, then the you win messege will appear and the game will end. 
                Console.Clear();
                PrintPillar();
                Console.WriteLine("You win!");
                Console.ReadKey();
            }

            //This method will check if what the user inputed was a valid.
            static bool IsMoveValid(string from, string to)
            {
                //this is the first conditional check if the starting pillar has no disks, if it is invalid it returns false.  
                if (Pillar[from].Count == 0)
                {
                    return false;
                }
                //if the user selects the same pillar for both to and from, then it is a invalid move
                else if (to == from)
                {
                    return false;
                }
                
                // if there is nothing in the recieving pillar, it will either move the disk into it if true
                // if it is not empty, then the program will run another conditional.
                else if (Pillar[to].Count != 0)
                {
                    //this next part took me some time to figure out, but this is most important part of the conditional.
                    //this conditional makes sure that bigger disk won't go on top of a smaller disk.
                    //.Peek will check the size of the disk without moving them from their current position
                    if (Pillar[from].Peek() > Pillar[to].Peek())
                    {
                        return false;
                    }
                    return true;
                }
                else
                {
                    return true;
                }
            }

            //This Boolean will tell the user if they won or not.
            static bool CheckWin()
            {
                //Here is my Const string and my normal string, my Const has the winning combination
                const string WinCondition = "1234";
                string columnCondition = "";

                // whereas my string column is whatever currently in Pillar[C], which this foreach checks
                foreach (var disks in Pillar["C"])
                {
                    columnCondition += disks.ToString();
                }
                //after it get the current C pillar load out, it checks if matches the WinCondition
                //if it does, then it returns true, and the game is over
                if (columnCondition == WinCondition)
                {
                    return true;
                }
                return false;
            }

            //this method will print the current board as the user is playing
            static void PrintPillar()
            {
                foreach (var item in Pillar)
                {
                    //this first line produces what the user will first see.
                    //item.Key is which ever pillar is displayed and takes in the new input
                    Console.Write($"\n{ item.Key}: ");
                    //then what ever move the user inputs is add or change is stored with the var number
                    var numbers = item.Value.ToArray();

                    //this for loop, is a subtraction loop, I mean it will subtract 1 from the length
                    for (int i = numbers.Length; i > 0; i--)
                    {
                        //which it then displays the the current array of disks
                        Console.Write(numbers[i - 1] + " ");
                    }
                    //this will display all this information together pillar and disk location waiting for user input.
                    Console.WriteLine();
                }
            }

        }
    }
}
