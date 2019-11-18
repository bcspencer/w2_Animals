using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalExample
{
    public class Horse : Animal, IVegetarian
    {
        public Horse(string Name, int Age) : base(Name, Age)
        {

        }

        public void EatGreenStuff()
        {
            Console.WriteLine("Yummy a tree"); 
            Console.WriteLine();
        }

        public override void Greet()
        {
            Console.WriteLine("Neigh, I'm a horse called " + Name + " and I'm " + Age);
            Console.WriteLine();
        }
    }
}
