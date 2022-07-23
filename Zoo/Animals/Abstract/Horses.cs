using System;

namespace Zoo.Animals.Abstract
{
    public abstract class Horses : Animal
    {
        public Horses(int weight, int age):base(weight, age)
        {
            this.Family = "Horses";
        }
        
        public override void Feed()
        {
            Console.WriteLine($"{this.Genus} ({this.Family}) Feeded.");
        }


        public override int GetFeedSchedule()
        {
            return 12;
        }
    }
}