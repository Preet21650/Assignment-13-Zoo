using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_13_Zoo
{
    class Eagle : Animal
    {

        public Eagle(string name, string type,int age,int legs)
        {
            this.name = name;
            this.species = species;
            this.age = age;
        }

        public void fly()
        {
            Console.WriteLine("I can fly");
        }

        public override void Speak()
        {
            Console.WriteLine("AAAAAAAAA");
        }

     

    }
}
