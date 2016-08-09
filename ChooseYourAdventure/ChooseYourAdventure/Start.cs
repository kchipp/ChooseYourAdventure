using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourAdventure
{
    class Start
    {
      public void runIntro()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("WELCOME to the SERENITY ADVENTURE");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("    a tribute to 'Firefly'");
            Console.ResetColor();
            Console.ResetColor();
            Console.WriteLine("\nYour riding in Serenity, a Firefly class spaceship.  Usually Malcolm Reynolds is the Captain. \nBut he's put you in charge for some reason. Your crew includes Zoey, Wash and Jayne. Watch out for Jayne and Kaylee. \nSome people call you criminals or smugglers. You are just trying to live a life free of Alliance control. \nRight now, your life include this job of delivering some cargo. \nSuddenly an Alliance ship hails you.  What are you going to do??" );
            Console.ReadLine();
           
        }
    }
}
