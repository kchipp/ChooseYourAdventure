using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChooseYourAdventure
{
    class ChoiceIgnore
    {
        public void MakeIgnoreChoice()
        {
            Console.WriteLine("You've ignored their hails.  This could mean trouble. They really think you're up to something now.  \nWhat's that sound? ");
            Thread.Sleep(700);
            Console.WriteLine("\nGorramit, they are breaking through the hatch...What are you going to do?");
            Console.ReadLine();
            Console.WriteLine("Well they're coming in whether you're ready or not.  The cargo is almost all hidden.  Make your choice:");
            Console.WriteLine("Choose 1 - you raise your weapons.  They aren't taking you or the cargo or the crew without a fight! \nChoose 2 - you try to stall them at the hatch...try the mechanically issue this time.");
            string ignoreChoice= Console.ReadLine();

            switch (ignoreChoice)
            {
                case "1":
                    Console.WriteLine("You've made a choice. Press enter");
                    Console.ReadLine();
                    Console.Clear();
                    ChoiceWeapons cWeapons = new ChoiceWeapons();
                    cWeapons.MakeWeaponsChoice();
                    break;
                case "2":
                    Console.WriteLine("You've made a choice. Press enter");
                    Console.ReadLine();
                    Console.Clear();
                    ChoiceReStall cReStall = new ChoiceReStall();
                    cReStall.MakeReStallChoice();
                    break;
                default:
                    Console.WriteLine("Sorry, You must make a choice");
                    MakeIgnoreChoice();
                    break;
            }
        }
    }
}
