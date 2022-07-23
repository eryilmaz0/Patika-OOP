using System;
using System.Linq;
using Zoo.Animals.Abstract;
using Zoo.Animals.Cats;
using Zoo.Animals.Horses;
using Zoo.Animals.Rodents;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new Animal[]
            {
                new Lion(100, 20),
                new Tiger(90, 23),
                new Horse(50, 15),
                new Zebra(70, 18),
                new Beaver(10, 10),
                new Rat(5, 8)
            }.ToList();
            
         
            animals.ForEach(animal =>
            {
                animal.PrintAnimalInformations();
                animal.Feed();
            });
            
        }
    }
}