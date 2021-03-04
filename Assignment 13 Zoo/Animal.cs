using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_13_Zoo
{
    class Animal
    {
        protected string name;
        protected string species;
        protected int age;
        protected int legs;

        
        public string GetName()
        {
            return name;
        }

        public string GetSpecies()
        {
            return species;
        }
        public int GetAge()
        {
            return age;
        }

        public int GetLegs()
        {
            return legs;
        }

        public virtual void Speak()
        {
            Console.WriteLine("Whoof!");
        }
    }
}
