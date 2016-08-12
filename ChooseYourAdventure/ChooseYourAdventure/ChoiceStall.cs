using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourAdventure
{
    class ChoiceStall
    {
        public void MakeStallChoice()
        {
            Console.WriteLine("You choose to try and stall.  That's a good choice.  This boat is a little fei-oo (according to the Alliance).  \nThey may just buy it. But they won't wait forever.  ");
            Console.WriteLine("Get that contraband...ahem CARGO...stored. They are waiting, but won't wait much longer.  Are you ready?");
            Console.ReadLine();
            Console.WriteLine("Ready or not. They want in and they want in now.  Make your choice: ");
            Console.WriteLine("Choose 1 - you open the door and meet them, welcoming them aboard. \nChoose 2 - you let them in, but you aren't happy about it and Jayne about as much says so.");
            string stallChoice = Console.ReadLine();

            switch (stallChoice)
            {
                case "1":
                    Console.WriteLine("You made your choice.  Press Enter.");
                    Console.ReadLine();
                    Console.Clear();
                    ChoiceWelcome cWelcome = new ChoiceWelcome();
                    cWelcome.MakeWelcomeChoice();
                    break;
                case "2":
                    Console.WriteLine("You made your choice.  Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    ChoiceUnWelcome cUnWelcome = new ChoiceUnWelcome();
                    cUnWelcome.MakeUnWelcomeChoice();
                    break;
            }
        }
    }
}
