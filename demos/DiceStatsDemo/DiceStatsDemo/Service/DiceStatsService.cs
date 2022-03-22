using DiceStatsDemo.Model;
using System;
using System.Collections.Generic;

namespace DiceStatsDemo.Service
{
    class DiceStatsService
    {
        public int Sides { get; set; }
        private Random _rng = new Random();

        public DiceStatsService(int sides)
        {
            Sides = sides;
        }

        public DieRollResult Roll(int numDice)
        {
            DieRollResult result = new DieRollResult();
            for (int i = 0; i < numDice; i++)
            {
                result.AddResult(_rng.Next(1, Sides + 1));
            }

            return result;
        }

        public List<DieRollResult> Roll(int numDice, int numResults)
        {
            List<DieRollResult> results = new List<DieRollResult>();
            for (int i = 0; i < numResults; i++)
            {
                results.Add(Roll(numDice));
            }

            return results;
        }

        public Dictionary<int, int> GetRollStats(List<DieRollResult> dieRolls)
        {
            Dictionary<int, int> stats = new Dictionary<int, int>();

            foreach (DieRollResult roll in dieRolls)
            {
                if (!stats.ContainsKey(roll.Sum))
                {
                    stats[roll.Sum] = 0;
                } 
                
                stats[roll.Sum]++;

            }

            return stats;
        }        

        public int FindMostCommonRoll(Dictionary<int, int> stats)
        {
            int max = 0;
            int maxKey = 0;

            foreach (int key in stats.Keys)
            {
                if(stats[key] > max)
                {
                    maxKey = key;
                    max = stats[key];
                }
            }

            return maxKey;
        }
    }
}
