using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCalculator.Model
{
    class WallpaperRoll
    {
        public decimal Size { get; set; }
        public decimal Cost { get; set; }
        public WallpaperRoll(decimal size, decimal cost)
        {
            Size = size;
            Cost = cost;
        }
    }
}
