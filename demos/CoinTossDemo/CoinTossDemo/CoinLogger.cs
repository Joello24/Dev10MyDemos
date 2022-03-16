using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinTossDemo
{
    class CoinLogger
    {
        public ICoin Coin { get; set; }

        public CoinLogger(ICoin coin)
        {
            Coin = coin;
        }

        public void Run()
        {
            Console.WriteLine($"Flipping a {Coin.Name()}");

            int heads = 0;
            int tails = 0;

            for (int i = 0; i < 100; i++)
            {
                if (Coin.Flip())
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }

            Console.WriteLine($"Heads: {heads}");
            Console.WriteLine($"Tails: {tails}");
        }

    }
}
