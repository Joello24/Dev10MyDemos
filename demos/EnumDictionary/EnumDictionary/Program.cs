using System;
using System.Collections.Generic;

namespace EnumDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<PLAYERTYPES, IPlayer> ai = new Dictionary<PLAYERTYPES, IPlayer>();
            ai.Add(PLAYERTYPES.ONLY_ROCK, new RockPlayer());
            ai.Add(PLAYERTYPES.ONLY_PAPER, new PaperPlayer());
            ai.Add(PLAYERTYPES.ONLY_SCISSORS, new ScissorsPlayer());
            ai.Add(PLAYERTYPES.RANDOM, new RandomPlayer());

            Console.Write("Select an ai (1 = rock, 2 = paper, 3 = scissors, 4 = random): ");
            int choice = int.Parse(Console.ReadLine());

            IPlayer player = ai[(PLAYERTYPES)choice];

            Console.WriteLine(player.getChoice());


        }
    }
}
