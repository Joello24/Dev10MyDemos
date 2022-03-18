using RoomCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCalculator.Services
{
    class WallpaperService
    {
        public int RollsOfWallpaperForRoom(RectangularRoom room, WallpaperRoll roll)
        {
            int rollCount = (int)(room.WallSquareFootage / roll.Size);
            if ((room.WallSquareFootage % roll.Size) > 0)
            {
                rollCount++;
            }
            return rollCount;
        }

        public decimal CostOfRoom(RectangularRoom room, WallpaperRoll roll)
        {
            int rollCount = RollsOfWallpaperForRoom(room, roll);
            return rollCount * roll.Cost;
        }
            
    }
}
