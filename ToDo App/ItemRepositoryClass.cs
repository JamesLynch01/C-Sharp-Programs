using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_App
{
    public class ItemRepositoryClass
    {
        ItemContextClass itemContext;

        public ItemRepositoryClass()
        {
            itemContext = new ItemContextClass();
            itemContext.Database.EnsureCreated();
        }

        public void AddItem(ToDoItems item)
        {
            itemContext.Add(item);
            itemContext.SaveChanges();
        }

        public void RemoveItem(ToDoItems item)
        {
            itemContext.Remove(item);
            itemContext.SaveChanges();
        }

        public List<ToDoItems> PrintList()
        {
            return itemContext.ToDoItems.ToList();
        }

        public List<ToDoItems> PrintDoneItems()
        {
            return itemContext.ToDoItems.ToList();
        } 

        public List<ToDoItems> PrintPendingItems()
        {
            return itemContext.ToDoItems.ToList();
        }

    }
}
