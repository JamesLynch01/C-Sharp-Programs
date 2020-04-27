using System;
using System.Collections;
using System.Collections.Generic;

namespace TowerOfHanoi
{
    class Program
    {

        private static Dictionary<string, Stack<int>> Pillar = new Dictionary<string, Stack<int>>(); 
        static void Main(string[] args)
        {
            
            
            {
                Stack<int> disks = new Stack<int>();
                disks.Push(4);
                disks.Push(3);
                disks.Push(2);
                disks.Push(1);
                Pillar.Add("A", disks);
                Pillar.Add("B", new Stack<int>());
                Pillar.Add("C", new Stack<int>());

                do
                {
                    Console.Clear();
                    PrintPillar();
                    Console.WriteLine("Enter the tower to move From.");
                    string from = Console.ReadLine().ToUpper();
                    Console.WriteLine("Enter the tower to move TO.");
                    string to = Console.ReadLine().ToUpper();

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

                } while (!CheckWin());

                Console.Clear();
                PrintPillar();
                Console.WriteLine("You win!");
                Console.ReadKey();
            }

            static bool IsMoveValid(string from, string to)
            {
                if (Pillar[from].Count == 0)
                {
                    return false;
                }
                else if (to == from)
                {
                    return false;
                }
                else if (Pillar[to].Count != 0)
                {
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

            static bool CheckWin()
            {
                const string WinCondition = "1234";
                string columnCondition = "";

                foreach (var disks in Pillar["C"])
                {
                    columnCondition += disks.ToString();
                }
                Console.WriteLine(columnCondition);
                if (columnCondition == WinCondition)
                {
                    return true;
                }
                return false;
            }

            static void PrintPillar()
            {
                foreach (var item in Pillar)
                {
                    Console.Write($"\n{ item.Key}: ");
                    var numbers = item.Value.ToArray();

                    for (int i = numbers.Length; i > 0; i--)
                    {
                        Console.Write(numbers[i - 1] + " ");
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
