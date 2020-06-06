using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ToDo_App
{
    public class ConsoleUtils
    {
        public string GetUserOption()
        {
            PrintMenu();
            return Console.ReadLine();
        }

        public void PrintMenu()
        {
            Console.WriteLine("1. to add an item 2. to delete an item");
            Console.WriteLine("3. list pending items 4. list done items 5. to print all items");
            Console.WriteLine("Enter the number of the option you want.");
        }

        public ToDoItems MakeDeleteItem()
        {
            Console.WriteLine("Enter the description");
            string description = Console.ReadLine();

            Console.WriteLine("Enter a date");
            int due = Int32.Parse(Console.ReadLine());

            return new ToDoItems(description, due);
        }

    }
}
