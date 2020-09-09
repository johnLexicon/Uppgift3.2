using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3._2
{
    class Horse : Animal
    {
        public string ManeColor { get; set; }
        public Horse(string name, int age, double weight, string maneColor)
            : base(name, age, weight)
        {
            this.ManeColor = maneColor;
        }
        public override void DoSound() => Console.WriteLine("Gnägg");

        public override string Stats()
        {
            return $"{base.Stats()} Mane color: {ManeColor}";
        }
    }
}
