using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3._2
{
    class Worm : Animal
    {
        public double Length { get; set; }
        public Worm(string name, int age, double weight, double length)
            : base(name, age, weight)
        {
            this.Length = length;
        }

        public override void DoSound()
        {
            Console.WriteLine("_/\\_______");
        }
        public override string Stats()
        {
            return $"{base.Stats()} Length: {Length}";
        }
    }
}
