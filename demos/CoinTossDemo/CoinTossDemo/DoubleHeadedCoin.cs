using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinTossDemo
{
    public class DoubleHeadedCoin : ICoin
    {
        public string Name()
        {
            return "A Double Headed Coin";
        }
        public bool Flip()
        {
            return true;
        }
    }
}
