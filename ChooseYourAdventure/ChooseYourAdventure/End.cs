using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourAdventure
{
    class End
    {
        public void endAdventure()
        {
            Console.WriteLine("Your adventure has ended...for now....");
            Console.ReadKey();
            PlayAgain pa = new PlayAgain();
            pa.playAgain();

        }
    }
}
