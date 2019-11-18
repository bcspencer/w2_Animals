using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalExample
{
    public class Cat : Animal, ICarnivore
    {
        public Cat(string Name, int Age) : base(Name, Age)
        {

        }

        public override void Greet()
        {
            Console.WriteLine("Meow, I'm a cat and I'm not telling you my name");
            Console.WriteLine("Once I got stuck in a tree and then I jumped out");
            Console.WriteLine();
        }

        public int EatMeat(int numberOfCows)
        {
            var remainingCows = numberOfCows - 1;

            Console.WriteLine("I'm going to eat a cow...");
            Console.WriteLine();

            if (remainingCows > 0)
            {
                return remainingCows;
            }

            Console.WriteLine("Oh no, we've run out of cows!");
            Console.WriteLine();
            return remainingCows;
        }

        public bool Vomit() 
        {
            return true;
        }
    }
}
