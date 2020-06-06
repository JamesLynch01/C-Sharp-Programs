using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_App
{
    public class Apps
    {
        ConsoleUtils consoleUtils;
        ItemRepositoryClass itemRepository;

        public Apps()
        {
            consoleUtils = new ConsoleUtils();
            itemRepository = new ItemRepositoryClass();
        }

        public void Start()
        {
            while (true)
            {
                //Print out the user options
                var answer = consoleUtils.GetUserOption();
            switch(answer)
                {
                    case "1":
                        var item = consoleUtils.MakeDeleteItem();
                        itemRepository.AddItem(item);
                        break;

                    case "2":
                        item = consoleUtils.MakeDeleteItem();
                        itemRepository.RemoveItem(item);
                        break;

                    case "3":
                            itemRepository.PrintPendingItems();
                        break;

                    case "4":
                            itemRepository.PrintList();
                        break;

                    case "5":
                        itemRepository.PrintList();
                        break;

                    default:
                        break;
                }
            
            }
        }
    }
}
