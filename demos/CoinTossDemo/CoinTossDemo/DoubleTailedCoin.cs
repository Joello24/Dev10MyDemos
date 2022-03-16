using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinTossDemo
{
    class DoubleTailedCoin : ICoin
    {

        public string Name()
        {
            return "A Double Tailed Coin";
        }
        public bool Flip()
        {
            return false;
        }
    }
}
