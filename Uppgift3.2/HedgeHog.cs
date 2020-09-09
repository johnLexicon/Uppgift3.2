using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3._2
{
    class HedgeHog : Animal
    {
        public int NumberOfSpikes { get; set; }
        public HedgeHog(string name, int age, double weight, int numberOfSpikes)
            : base(name, age, weight)
        {
            this.NumberOfSpikes = numberOfSpikes;
        }

        public override void DoSound()
        {
            Console.WriteLine("Nöff Nöff");
        }
        public override string Stats()
        {
            return $"{base.Stats()} Number of spikes: {NumberOfSpikes}";
        }
    }
}