using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Cat : IPet
    {
        public string Name { get; set; }

        public Cat (string name)
        {
            this.Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void Speak()
        {
            Console.WriteLine($"{Name}:  meow");
        }

        public void Purr()
        {
            Console.WriteLine($"{Name}:  *purrs loudly*");
        }
    }
}
