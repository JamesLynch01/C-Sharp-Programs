using System;
using System.Collections.Generic;

namespace ToDoItem
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListItem = new List<ToDoItem>();
            bool run = true;
            do
            {
                Console.WriteLine("Would you like to make a checklist? Y/N?");
                string UserAnswer = Console.ReadLine().ToLower();
                if (UserAnswer == "y")
                {

                    ToDoItem Chore = new ToDoItem();
                    Console.WriteLine("Enter an item description.");
                    Chore.Description = Console.ReadLine();

                    Console.WriteLine("Enter the due date like this 01/30/2020");
                    Chore.DueDate = Console.ReadLine();

                    Console.WriteLine("then enter a priority level between, low, medium, or high.");
                    Chore.Priority = Console.ReadLine();
                    
                    ListItem.Add(Chore);

                    run = false;

                }
                else 
                {
                    run = true; 
                };

            } while (!run);

            foreach (var item in ListItem)
            {
                Console.WriteLine(item.Description +" "+item.DueDate+" "+item.Priority);
            };

         }
    }

    

    public class ToDoItem
    {
        public string Description { get; set; }

        public string DueDate { get; set; }

        public string Priority { get; set; }

    }

}
