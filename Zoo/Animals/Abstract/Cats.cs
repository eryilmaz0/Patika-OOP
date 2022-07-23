using System;

namespace Zoo.Animals.Abstract
{
    public abstract class Cats : Animal
    {
        public Cats(int weight, int age):base(weight, age)
        {
            this.Family = "Cats";
        }
        
        public override void Feed()
        {
            Console.WriteLine($"{this.Genus} ({this.Family}) Feeded.");
        }


        public override int GetFeedSchedule()
        {
            return 6;
        }
    }
}