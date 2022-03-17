using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndInheritanceDemo
{
    class Dog : IPet
    {
        public string Name { get; set; }

        public Dog(string name)
        {
            Name = name;
        }

        public void RollOver()
        {
            Console.WriteLine($"{Name} rolls over.");
        }
        public void Move()
        {
            Console.WriteLine($"{Name} lopes across the room, tail wagging.");
        }

        public void Speak()
        {
            Console.WriteLine($"{Name} arfs happily.");
        }
    }
}
