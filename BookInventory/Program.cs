using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BookInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            BooksIndex context = new BooksIndex();

            context.Database.EnsureCreated();

            Console.WriteLine("Do you want to add to Datebase, y/n?");
            string Answer = Console.ReadLine().ToLower();
            do
            {

                Console.WriteLine("please enter a title");
                var user_title = Console.ReadLine();

                Console.WriteLine("please enter a author");
                var user_author = Console.ReadLine();
                var theBook = new Book(user_title, user_author);

                context.Add(theBook);
                context.SaveChanges();
            }
            while (Answer == "n");

            context.Print();
        }
    }
}
