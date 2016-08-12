using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourAdventure
{
    class PlayAgain
    {
        public void Replay()
        {

            Console.WriteLine("\nWhat's next?\nType 'Again' to play again.\nType 'esc' to Quit.");
            string userChoice;
            userChoice = Console.ReadLine();
            switch (userChoice.ToLower())
            {
                case "again":
                    Console.Clear();
                    Start start = new Start();
                    start.RunIntro();
                    ChoiceOne choice = new ChoiceOne();
                    choice.MakeChoice();
                    break;
                case "esc":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Thanks for playing.  Come back Soon!");
                    Console.Read();
                    break;
                default:
                    Console.WriteLine("Oops! Try again...");
                    Replay();
                    break;
            }
        }
    }
}
