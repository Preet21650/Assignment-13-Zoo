using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_13_Zoo
{
    class Fish : Animal
    {
       

        public Fish(string name, string type, int age,int legs)
        {
            this.name = name;
            this.species = species;
            this.age = age;
        }
        public void swim()
        {
            Console.WriteLine("I can swim");
        }

        public override void Speak()
        {
            Console.WriteLine("GLUB GLUB");
        }

     

    }
}
