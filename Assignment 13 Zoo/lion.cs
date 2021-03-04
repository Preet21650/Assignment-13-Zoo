using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_13_Zoo
{
    class Lion : Animal
    {
        public Lion(string name, string type, int age,int legs)
        {
            this.name = name;
            this.species = species;
            this.age = age;
        }

        public void run()
        {
            Console.WriteLine("I can run");
        }

        public override void Speak()
        {
            Console.WriteLine("ARGHHHHH");
        }

 
    }
}
