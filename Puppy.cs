using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalExample
{
    public class Puppy : Dog
    {
        //private bool
        public Puppy(string Name, int Age) : base(Name, Age)
        {

        }

        public override void Greet()
        {
            base.Greet();
            Console.WriteLine();
        }
    }
}
