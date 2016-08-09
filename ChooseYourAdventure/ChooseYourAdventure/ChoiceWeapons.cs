using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourAdventure
{
    class ChoiceWeapons
    {
        public void makeWeaponsChoice()
        {
            Console.WriteLine("Really, you're going in guns blazing?  Malcolm would probably approve, but it doesn't work out for you. \nThe Alliance over-power you and even Jayne.");
            Console.WriteLine("The Alliance takes you and the crew and the cargo into custody.  But not before you send a wave to Mal.  \nCan he get you out of this mess...");
            Console.ReadLine();
            End end = new End();
            end.endAdventure();
        }
    }
}
