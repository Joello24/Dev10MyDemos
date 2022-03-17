using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDictionary
{
    class RockPlayer : IPlayer
    {
        public RPS getChoice()
        {
            return RPS.ROCK;
        }
    }
}
