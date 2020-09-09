using System;
using System.Collections.Generic;

namespace Uppgift3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> Animals = new List<Animal>
            {                
                new Bird("Bird", 2, 0.4, 22),
                new Dog("Dog", 14, 9, 37),
                new HedgeHog("Hedgehog", 2, 1, 1100),                
                new Flamingo("Flamingo", 1, 5, 100, "Vit"),
                new Horse("Horse", 35, 278, "Brun"),
                new Worm("Worm", 1, 0.1, 10),
                new Pelican("Pelican", 3, 5, 150, 20),
                new Swan("Swan", 1, 2, 100, 20),                
                new Wolf("Wolf", 4, 60, 5.5),
                new Wolfman("Wolfman", 25, 90, 2.05)
            };

            foreach (Animal animal in Animals)
            {
                Console.WriteLine($"The animals name is: {animal.Name}");
                Console.Write($"{animal.Name} sounds like: ");
                animal.DoSound();
                if (animal is Person)
                {
                    Console.Write($"{animal.Name} says: ");
                    Person person = (Person)animal;
                    person.Talk();
                }
            }

            // 9 F: Pröva att lägga till Horse i dog list
            // List är starkt typad till objekt av klass Dog.
            // dogs.Add(new Horse("Häst", 23, 300, "Svart")); Går ej

            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog("Hund1", 7, 4, 30.5));
            dogs.Add(new Dog("Hund2", 14, 35, 135));
            // 10 F:Går bara att lägga till objekt av klass Horse om listan är av typ <Animal>:
            List<Animal> dogs2 = new List<Animal>();
            dogs2.Add(new Horse("Häst", 14, 350, "Svart"));
            dogs2.Add(new Dog("Hund3", 14, 35, 135));
       
            // 11 F: Stats() är virtual i klass Animal och returnerar properties
            // som finns i Animal klassen. Stats() är implementerat i alla 
            // djursubklasser med override.
            Console.WriteLine("All animals stats:");
            foreach (Animal animal in Animals)
            {
                Console.WriteLine(animal.Stats());
            }

            Console.WriteLine("Only dogs stats");
            foreach (Animal animal in Animals)
            {
                // 17 F: Kommer inte åt FavPlace() i Animal
                // var FavPlace = animal.FavPlace(); // fungerar ej
                // FavPlace() metoden i Dog kommer man inte åt från ett Animal objekt
                // eftersom den bara finns i Dog subklassen. Om man castar Animal objektet
                // till Dog så kommer man åt FavPlace().

                if (animal is Dog dog)                    
                {                    
                    Console.WriteLine(animal.Stats());
                    Console.WriteLine($"Favourite place is {dog.FavPlace()}");
                    
                }
            }
        }
    }
}