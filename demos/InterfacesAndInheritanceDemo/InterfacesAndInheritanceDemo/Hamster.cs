using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndInheritanceDemo
{
    class Hamster : IPet
    {
        public string Name { get; set; }

        public Hamster(string name)
        {
            Name = name;
        }
        public void Escape()
        {
            Console.WriteLine($"{Name} has escaped!!");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} runs on its wheel.");
        }

        public void Speak()
        {
            Console.WriteLine($"{Name} squeaks nervously.");
        }
    }
}
