using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class Dog : IPet
    {
        public string Name { get; set; }
        
        public Dog(string name)
        {
            this.Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void Speak()
        {
            Console.WriteLine($"{Name}: Arf!");
        }

        public void RollOver()
        {
            Console.WriteLine($"*{ Name} rolls over and wags tail*");
        }
    }
}
