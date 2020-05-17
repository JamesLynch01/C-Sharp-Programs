using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BookInventory
{
    class BooksIndex : DbContext
    {
        public DbSet<Book> Books { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);

            DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;

            string DatabaseFile = Path.Combine(ProjectBase.FullName, "books.db");

            optionsBuilder.UseSqlite("Date Source=" + DatabaseFile);
        }

        public void Print()
        {
            foreach(var book in Books)
            {
                Console.WriteLine($"Title: {book.title} Author: {book.author}");
            }
        } 
    }
}
