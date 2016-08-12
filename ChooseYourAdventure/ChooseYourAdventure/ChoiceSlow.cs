using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourAdventure
{
    class ChoiceSlow
    {
        public void makeSlowChoice()
        {
            Console.WriteLine("You slowed for the Alliance ship. This could mean trouble. The Alliance is aware of some of your 'jobs'. \nThey are requesting permission to come aboard.  It could be nothing, but you never know. \nYou have to let them aboard, since they have locked on to the ship. What your next move?");
            Console.ReadLine();
            Console.WriteLine("They've hailed again...make your choice: \nChoose 1 - you ignore their hails and hide some your cargo. They can wait.");
            Console.WriteLine("Choose 2 - you answer the hail, but stall, claiming mechanically difficulties with the hatch while you stow your cargo.");
            string slowChoice = Console.ReadLine();
          
            switch (slowChoice)
            {
                case "1":
                    Console.WriteLine("You've made another choice. Press enter");
                    Console.ReadLine();
                    Console.Clear();
                    ChoiceIgnore cIgnore = new ChoiceIgnore();
                    cIgnore.MakeIgnoreChoice();
                    break;
                case "2":
                    Console.WriteLine("You've made another choice. Press enter");
                    Console.ReadLine();
                    Console.Clear();
                    ChoiceStall cStall = new ChoiceStall();
                    cStall.MakeStallChoice();                
                    break;
                default:
                    Console.WriteLine("Sorry, You must make a choice");
                    makeSlowChoice();
                    break;
            }
        }

    }
}
