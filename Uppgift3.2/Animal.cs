using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3._2
{
     // 14 F: Om alla djur behöver ett nytt attribut bör det läggas
    //        i klassen Animal

    abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public abstract void DoSound();

        public virtual string Stats()
        {
            return $"Name: {Name} Age: {Age} Weight: {Weight}";
        }

    }
}