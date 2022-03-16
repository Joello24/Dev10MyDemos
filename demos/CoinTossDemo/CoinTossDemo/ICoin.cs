using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinTossDemo
{
    public interface ICoin : INamed
    {
        bool Flip();
    }
}
