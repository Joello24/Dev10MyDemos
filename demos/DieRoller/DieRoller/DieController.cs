using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    class DieController
    {
        public ConsoleIO UI { get; set; }
        public DieService Dice { get; set; }

        public DieController(ConsoleIO ui, DieService dice)
        {
            UI = ui;
            Dice = dice;
        }

        public void run()
        {
            bool running = true;

            while(running)
            {
                running = Menu();
            }
        }

        public bool Menu()
        {
            bool result = true;

            UI.Display("Dice Roller");
            UI.Display("===========");
            UI.Display("1:  Roll D&D Style");
            UI.Display("2:  Roll A Bag Of Dice");
            UI.Display("3:  Exit");

            int choice = UI.GetInt("");

            switch(choice) {
                case 1:
                    RollDDStyle();
                    break;
                case 2:
                    RollABagOfDice();
                    break;
                case 3:
                    UI.Warn("Goodbye!");
                    result = false;
                    break;
                default:
                    UI.Error("Invalid choice");
                    break;
            }


            return result;
        }

        public void RollDDStyle()
        {
            UI.Warn("\nRolling D&D Style:\n");
            int sides = UI.GetInt("How many sides on the die? ");
            int count = UI.GetInt("How many times are you rolling? ");
            int modifier = UI.GetInt("What is the modifier? ");

            Die d = Dice.MakeDie(sides);
            DieResult result = Dice.RollDice(d, count, modifier);
            UI.Display(result.ToString());
        }

        public void RollABagOfDice()
        {
            UI.Warn("\nRolling A Bag Of Dice:\n");
            List<Die> bag = new List<Die>();

            bool keepGoing = true;

            while (keepGoing)
            {
                int sides = UI.GetInt("How many sides on this die? (0 to quit making dice) ");
                if (sides > 0)
                {
                    bag.Add(Dice.MakeDie(sides));
                } else
                {
                    keepGoing = false;
                }
            }

            List<DieResult> results = Dice.RollDice(bag);
            int total = 0;

            foreach (DieResult result in results)
            {
                UI.Display(result.ToString());
                total += result.Result;
            }

            UI.Display("Total of the dice: " + total);
        }
    }
}
