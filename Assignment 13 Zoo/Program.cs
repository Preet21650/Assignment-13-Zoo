using System;

namespace Assignment_13_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[]
            {
                new Lion("Larry","Indian",45,4),
                new Fish("Fishhy","Shark",5,0),
                new Eagle("Tom","Bird",9,0)
            };

            Lion Larry = (Lion)animals[0];
            Larry.run();

            Fish Fishhy = (Fish)animals[1];
            Fishhy.swim();

            for ( int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i].GetName());
                animals[i].Speak();
                

            }
            

           
        }
    }
}
