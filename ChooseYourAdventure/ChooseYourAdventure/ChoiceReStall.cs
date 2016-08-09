using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourAdventure
{
    class ChoiceReStall
    {
        public void makeReStallChoice()
        {
            Console.WriteLine("Well that didn't work.  They came in guns blazing and you weren't ready for them.  They've take the ship and her cargo into custody.  \nAnd they are going to leave you on some remote planet.");
            Console.WriteLine("At least you sent a wave to Mal before you let the Alliance march in.  If he doesn't kill you, he may just rescue you.  \nBetter start thinking about a plan to get Serenity back...");
            Console.ReadLine();
            End end = new End();
            end.endAdventure();
        }
    }
}
