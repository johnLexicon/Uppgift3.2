using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3._2
{
    class Dog : Animal
    {
        public double Length { get; set; }
        public Dog(string name, int age, double weight, double Length)
            : base(name, age, weight)
        {
            this.Length = Length;
        }

        public override void DoSound() => Console.WriteLine("Voff Voff");

        public override string Stats() => $"{base.Stats()} length: {Length}";

        public string FavPlace() => "Basket";
    }
}
