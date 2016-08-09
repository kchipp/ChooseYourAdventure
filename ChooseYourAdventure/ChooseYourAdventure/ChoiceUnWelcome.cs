using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourAdventure
{
    class ChoiceUnWelcome
    {
        public void makeUnWelcomeChoice()
        {
            Console.WriteLine("The Alliance isn't happy with your attitude or Jayne for that matter.  They start a thourough search of Serenity's cargo bay");
            Console.WriteLine("And someone didn't' hide the cargo very well.  \nSeriously, their are hidden storage compartments all over that the Alliance would never find");
            Console.WriteLine("But you didn't use one of those.  Now they have the cargo.  They are even threatening to take the crew into custody.  \nThis is not good...");
            Console.ReadLine();
            End end = new End();
            end.endAdventure();
            //PlayAgain pa = new PlayAgain();
            //pa.playAgain();

        }
    }
}
