using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalExample
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public virtual void Greet()
        {
            Console.WriteLine("Hello I'm an animal called " + Name);
            Console.WriteLine("And I am " + Age + " years old");
            Console.WriteLine();
        }
    }
}
