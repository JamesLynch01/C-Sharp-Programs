using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_App
{
    public class ToDoItems
    {
        public string Description { get; set; }

        public bool pending { get; set; }
        public bool done {get; set;}
        public int DueDate {get; set; }

        public ToDoItems(string description, int due)
        {
            this.Description = description;
            pending = true;
            done = true;
            this.DueDate = due;

        }
    }
}
