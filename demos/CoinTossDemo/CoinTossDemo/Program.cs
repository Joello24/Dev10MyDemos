using System;

namespace CoinTossDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            new CoinLogger(new FairCoin()).Run();

            FairCoin fc = new FairCoin();
            CoinLogger cl = new CoinLogger(fc);
            cl.Run();

            new CoinLogger(new DoubleHeadedCoin()).Run();
            new CoinLogger(new DoubleTailedCoin()).Run();


        }
    }
}
