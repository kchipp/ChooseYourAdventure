using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourAdventure
{
    class ChoiceRun
    {
        public void makeRunChoice()
        {
            Console.WriteLine("You choose to run.  Shiny! the Alliance has never been understanding of your 'jobs'. \nBut they also don't like when you run and they are chasing you. What your next move?");
            Console.ReadLine();
            Console.WriteLine("You've got to get away from them or it's trouble for sure.  Make your choice: \nChoose 1 - you release several fake tracking beacons. They may not know which one is you? \nChoose 2 - you go for full burn.  Serenity is a fast ship, but can she out-run them?");
            string secondRunChoice = Console.ReadLine();

            switch (secondRunChoice)
            {
                case "1":
                    Console.WriteLine("You've made that choice. Press enter");
                    Console.ReadLine();
                    Console.Clear();
                    ChoiceRelease cRelease = new ChoiceRelease();
                    cRelease.MakeReleaseChoice();
                    break;
                case "2":
                    Console.WriteLine("You've made that choice. Press enter");
                    Console.ReadLine();
                    Console.Clear();
                    ChoiceOutrun cOutrun = new ChoiceOutrun();
                    cOutrun.MakeOutrunChoice();                       
                    break;
                default:
                    Console.WriteLine("Sorry, You must make a choice");
                    makeRunChoice();
                    break;
            }
        }
    }
}
