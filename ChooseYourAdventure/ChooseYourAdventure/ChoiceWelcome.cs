using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourAdventure
{
    class ChoiceWelcome
    {
        public void MakeWelcomeChoice()
        {
            Console.WriteLine("You welcomed the Alliance on board Serenity. Ai ya. Women wanle! You're in trouble now.");
            Console.WriteLine("They can see the cargo and you don't have the right paperwork for it.  They seize the cargo and are threatening to take the ship, too");
            Console.WriteLine("Can you clean up the mess you made before Jayne kills you...or worse...before Mal finds out...");
            Console.ReadLine();
            End end = new End();
            end.EndAdventure();
        }
    }
}
