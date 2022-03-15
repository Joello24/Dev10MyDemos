using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    public class DieResult
    {
        public int Count { get; set; }
        public Die MyLocalDie { get; set; } 
        public int Modifier { get; set; }
        public int Result { get; set; }

        public override string ToString()
        {
            String modifierOutput = "";
            if (Modifier != 0)
            {
                modifierOutput = $"+{Modifier}";
            }
            return ($"{Count}d{MyLocalDie.Sides} {modifierOutput}" + 
                     $" = {Result}");
        }

    }
}
