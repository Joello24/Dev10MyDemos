using System;
using System.Collections.Generic;

namespace InterfacesAndInheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPet> pets = new List<IPet>();
            Dog fido = new Dog("Fido");
            IPet harvey = new Hamster("Harvey The Wonder Hamster");

            pets.Add(fido);
            pets.Add(harvey);

            fido.RollOver();
            //harvey.Escape() --Doesn't work- IPet doesn't know that behavior!!

            foreach(IPet pet in pets)
            {
                pet.Speak();
                pet.Move();
            }
        }
    }
}
