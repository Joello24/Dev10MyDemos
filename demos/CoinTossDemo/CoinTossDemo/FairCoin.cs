using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinTossDemo
{
    public class FairCoin : ICoin
    {
        Random rng = new Random();

        public string Name()
        {
            return "A Fair Coin";
        }

        public bool Flip()
        {
            return rng.Next(1, 3) == 1 ? false : true;
        }
    }
}
