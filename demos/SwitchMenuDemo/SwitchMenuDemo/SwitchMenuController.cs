using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchMenuDemo
{
    class SwitchMenuController
    {
        private const string GREETING_OPTION = "1";
        private const string FAREWELL_OPTION = "2";
        private const string MUSIC_OPTION = "3";
        private const string EXIT_OPTION = "9";

        public void Run()
        {
            bool running = true;

            while(running)
            {
                string choice = GetMenuOption().ToUpper();
                
                switch(choice)
                {
                    case GREETING_OPTION:
                        SayHi();
                        break;
                    case FAREWELL_OPTION:
                        SayBye();
                        break;
                    case MUSIC_OPTION:
                        SingASong();
                        break;
                    case EXIT_OPTION:
                        SayBye();
                        running = false;
                        break;
                    default:
                        HandleUnknownInput();
                        break;
                }

            }
        }

        private void HandleUnknownInput()
        {
            Console.WriteLine("Huh??");
        }

        private string GetMenuOption()
        {
            Console.WriteLine("Silly Program");
            Console.WriteLine("-------------");
            Console.WriteLine($"{GREETING_OPTION}:  Greeting");
            Console.WriteLine($"{FAREWELL_OPTION}:  Farewell");
            Console.WriteLine($"{MUSIC_OPTION}:  Music Mode");
            Console.WriteLine($"{EXIT_OPTION}:  Exit\n");
            Console.Write("Enter Choice: ");
            return Console.ReadLine();
        }

        private void SayHi()
        {
            Console.WriteLine("Hi there!");
        }

        private void SayBye()
        {
            Console.WriteLine("Bye now!");
        }

        private void SingASong()
        {
            Console.WriteLine("Mary had a little lamb...");
        }
    }
}
