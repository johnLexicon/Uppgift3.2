using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3._2
{

    // 13 F: Om vi vill lägga till fler attribut som alla fåglar behöver
    //     bör det läggas i klassen Bird.

    class Bird : Animal
    {
        public double WingSpan { get; set; }
        public Bird(string name, int age, double weight, double wingSpan)
            : base(name, age, weight)
        {
            this.WingSpan = wingSpan;
        }

        public override void DoSound()
        {
            Console.WriteLine("Kvitt kvitt");
        }
        public override string Stats()
        {
            return $"{base.Stats()} Wingspan: {WingSpan}";
        }
    }

    class Pelican : Bird
    {
        public double BeakSize { get; set; }
        public Pelican(string name, int age, double weight, double wingSpan, double beakSize)
            : base(name, age, weight, wingSpan)
        {
            this.BeakSize = beakSize;
        }
        public override string Stats()
        {
            return $"{base.Stats()} Beak size: {BeakSize}";
        }
    }

    class Flamingo : Bird
    {
        public string BodyColor { get; set; }
        public Flamingo(string name, int age, float weight, float wingSpan, string bodyColor)
            : base(name, age, weight, wingSpan)
        {
            this.BodyColor = bodyColor;
        }
        public override string Stats()
        {
            return $"{base.Stats()} Color: {BodyColor}";
        }

    }
    class Swan : Bird
    {
        public double NeckLength { get; set; }
        public Swan(string name, int age, double weight, float wingSpan, float neckLength)
            : base(name, age, weight, wingSpan)
        {
            this.NeckLength = neckLength;
        }
        public override string Stats()
        {
            return $"{base.Stats()} Neck length: {NeckLength}";
        }
    }

}