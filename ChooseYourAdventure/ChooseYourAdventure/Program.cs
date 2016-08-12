using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Start start = new Start();
            start.RunIntro();
            ChoiceOne choice = new ChoiceOne();
            choice.MakeChoice();
        }
    }
}
