using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDictionary
{
    class RandomPlayer : IPlayer
    {
        Random rng = new Random();
        public RPS getChoice()
        {
            int choice = rng.Next(1, 4);
            return (RPS) choice;
        }
    }
}
