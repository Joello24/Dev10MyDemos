using System;
using System.Collections.Generic;

namespace EnumDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a dictionary of PLAYERTYPE to IPlayer
            Dictionary<PLAYERTYPES, IPlayer> ai = new Dictionary<PLAYERTYPES, IPlayer>();
            ai.Add(PLAYERTYPES.ONLY_ROCK, new RockPlayer());  //ONLY_ROCK => RockPlayer() etc
            ai.Add(PLAYERTYPES.ONLY_PAPER, new PaperPlayer());
            ai.Add(PLAYERTYPES.ONLY_SCISSORS, new ScissorsPlayer());
            ai.Add(PLAYERTYPES.RANDOM, new RandomPlayer());

            // Prints out all the enum values in RPS (1 = ROCK, 2 = PAPER, 3 = SCISSORS)
            foreach (int i in Enum.GetValues(typeof(RPS)))
            {
                Console.WriteLine($" {i} = {(RPS) i}");
            }



            Console.Write("Select an ai (1 = rock, 2 = paper, 3 = scissors, 4 = random): ");
            int choice = int.Parse(Console.ReadLine());  //Grab an int from the user

            //Convert the int into a PLAYERTYPE value
            PLAYERTYPES aiType = (PLAYERTYPES)choice;
            Console.WriteLine($"Chose: {aiType}");

            IPlayer player;
            switch(aiType)
            {
                case PLAYERTYPES.ONLY_ROCK:
                    player = new RockPlayer();
                    break;
                case PLAYERTYPES.ONLY_PAPER:
                    player = new PaperPlayer();
                    break;
            }

/*            //Grab the appropriate brain from ai dictionary
            IPlayer player = ai[aiType];
*/
            //Demonstrate what that brain did
            //Console.WriteLine(player.getChoice());


        }
    }
}
