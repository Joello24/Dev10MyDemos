using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    public class DieService
    {
        Random Rng;

        public DieService(Random rng)
        {
            Rng = rng;
        }

        public Die MakeDie(int sides)
        {
            Die result = new Die();
            result.Sides = sides;
            return result;
        }

        public DieResult RollDice(Die die, int count, int modifier)
        {
            return roll(die, count, modifier);
        }

        private DieResult roll(Die die, int count, int modifier)
        {
            DieResult result = new DieResult();
            result.MyLocalDie = die;
            result.Count = count;
            result.Modifier = modifier;

            int total = 0;
            for (int i = 0; i < count; i++)
            {
                total += Rng.Next(1, die.Sides + 1);
            }

            result.Result = total + modifier;

            return result;
        }

        public List<DieResult> RollDice(List<Die> dice)
        {
            List<DieResult> results = new List<DieResult>();

            foreach (Die die in dice)
            {
                results.Add(roll(die, 1, 0));
            }

            return results;
        }

    }
}
