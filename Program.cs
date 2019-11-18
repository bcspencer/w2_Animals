using System;
using System.Collections.Generic;

namespace AnimalExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var cows = 10;
            Console.WriteLine("Welcome to the jungle!");
            Console.WriteLine("We currently have " + cows + " cows");
            Console.WriteLine();

            //polymorphism
            var allAnimals = new List<Animal>();

            //ICarnivore cat1 = new Cat("Bob",1); 

            //inheritance
            //allAnimals.Add(new Dog("Rover", 10));
            var dog1 = new Dog("Rover", 10);
            allAnimals.Add(dog1);

            allAnimals.Add(new Cat("Pebbles", 3));
            allAnimals.Add(new Dog("Buster", 4));
            allAnimals.Add(new Animal("Steve", 1));
            allAnimals.Add(new Horse("Roger", 6));

            foreach (var animal in allAnimals)
            {
                //polymorphism
                animal.Greet();

                if (animal is Horse)
                {
                    var horsey = (Horse)animal;
                    horsey.EatGreenStuff();
                }
                else if (animal is Cat)
                {
                    var cat = (Cat)animal;
                    cows = cat.EatMeat(cows);
                }
            }

            Console.WriteLine("There are " + cows + " cows left");
        }
    }
}
