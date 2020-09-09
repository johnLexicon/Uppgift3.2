using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3._2
{
    class Wolf : Animal
    {
        public double Length { get; set; }
        public Wolf(string name, int age, double weight, double Length)
            : base(name, age, weight)
        {
            this.Length = Length;
        }

        public override void DoSound()
        {
            Console.WriteLine("Yyyyhhhll");
        }
        public override string Stats()
        {
            return $"{base.Stats()} Length: {Length}";
        }
    }
}
