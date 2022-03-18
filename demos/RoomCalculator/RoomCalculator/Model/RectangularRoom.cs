using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCalculator.Model
{
    class RectangularRoom
    {
        public Wall LongWall { get; set; }
        public Wall ShortWall { get; set; }

        public decimal WallSquareFootage { 
            get
            {
                return (LongWall.Area * 2) + (ShortWall.Area * 2);
            } 
        }
    }
}
