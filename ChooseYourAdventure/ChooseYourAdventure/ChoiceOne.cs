using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourAdventure
{
    class ChoiceOne
    {
        public void makeChoice()
        {
            Console.WriteLine("Make your first choice: \nChoice 1 - you slow for the Alliance's hail. ");
            Console.WriteLine("Choice 2 - you make a break for it.");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("You've made your first choice.  Press enter");                  
                    Console.ReadLine();
                    Console.Clear();
                    ChoiceSlow cSlow = new ChoiceSlow();
                    cSlow.makeSlowChoice();
                    break;
                case "2":
                    Console.WriteLine("You've made your first choice.  Press enter");
                    Console.ReadLine();
                    Console.Clear();
                    ChoiceRun cRun = new ChoiceRun();
                    cRun.makeRunChoice();
                    break;
                default:
                    Console.WriteLine("Sorry, but you must make a choice");
                    makeChoice();
                    break;
            }
        }
       
    }
}
