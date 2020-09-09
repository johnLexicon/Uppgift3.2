using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3._2
{
    class Wolfman : Wolf, Person
    {
        public Wolfman(string name, int age, double weight, double fangLength)
            : base(name, age, weight, fangLength)
        {

        }
        public void Talk()
        {
            Console.WriteLine("Jag är Wolfman");
        }
    }
}
