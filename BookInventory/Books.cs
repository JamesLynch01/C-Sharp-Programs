using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BookInventory
{
    public class Book
    {
        public string title { get; set; }

        public string author { get; set; }

        public int id { get; set; }

        //I know normally, that the list of item in my contructor would be lower case
        //However, my items in the datebase are lower case, so I am just making sure they match
        //so later I don't have problems.
        public Book(string Title, string Author)
        {
            this.title = Title;
            this.author = Author;
        }
    }
}
