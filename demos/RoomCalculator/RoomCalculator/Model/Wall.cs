using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCalculator.Model
{
    public class Wall
    {
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal Area { get
            {
                return Width * Height;
            } 
        }

        public Wall(decimal width, decimal height)
        {
            Width = width;
            Height = height;
        }
    }
}
