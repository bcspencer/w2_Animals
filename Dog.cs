using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalExample
{
    public class Dog : Animal
    {
        //private bool
        public Dog(string Name, int Age) : base(Name, Age)
        {

        }

        public override void Greet()
        {
            var dogYears = Age * 7;

            Console.WriteLine("Woof, I'm a dog and my name is " + Name);
            Console.WriteLine("I like to chase a ball and I'm currently " + Age);
            Console.WriteLine("That's roughly " + dogYears + " in human years");
            Console.WriteLine();
        }
    }
}
