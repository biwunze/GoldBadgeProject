using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadge_03_Console
{
    class BadgeProgramUI
    {

        public void Run()
        {
            Menu();
        }

        private void Menu()
        {
            bool pleaseRun = true;
            while (pleaseRun)
            {

                Console.WriteLine("Hi Security Admin, What would you like to do?\n" +
                    "1. Add Badge\n" +
                    "2. Edit a Badge\n" +
                    "3. List all Badges\n" +
                    "4. Exit");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        AddABadge();
                        break;
                    case "2":
                        EditABadge();
                        break;
                    case "3":
                        ListAllBadges();
                        break;
                    case "4":
                        Console.WriteLine("Bye!");
                        pleaseRun = false;
                        break;
                    default:
                        Console.WriteLine("Please choose a correct option!");
                        break;
                }
                Console.WriteLine("Please press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void AddABadge()
        {
            //Badge
        }

        private void EditABadge()
        {

        }

        private void ListAllBadges()
        {

        }
    }
}
