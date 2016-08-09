using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourAdventure
{
    class ChoiceOutrun
    {
        public void makeOutrunChoice()
        {
            Console.WriteLine("You choose to try and out run them.  Luckily you have Wash and Kaylee on your crew, because it works.  \nThe Alliance ship cannot catch you. \nYou can hear Jayne cheering from the cargo hold.  Maybe he'll start to like you.  Maybe....");
            Console.ReadLine();
            End end = new End();
            end.endAdventure();
        }
    }
}
