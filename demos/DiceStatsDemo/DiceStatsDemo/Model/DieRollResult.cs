using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceStatsDemo.Model
{
    class DieRollResult
    {
        public List<int> Results = new List<int>();
        public int Sum
        {
            get
            {
                int sum = 0;
                foreach (int die in Results)
                {
                    sum += die;
                }

                return sum;
            }
        }

        public void AddResult(int die)
        {
            Results.Add(die);
        }
    }
}
