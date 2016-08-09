using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourAdventure
{
    class ChoiceRelease
    {
        public void makeReleaseChoice()
        {
            Console.WriteLine("You choose to release the fake beacons.  Well, like Malcolm says...\n'I've never credited the Alliance with an overabundance of intelligence'. This should work.");
            Console.WriteLine("It looks like it's working, too.  They are going after one of the fake beacons.  It looks like you're in the clear, \nfor now...");
            Console.ReadLine();
            End end = new End();
            end.endAdventure();
        }

    }
}
