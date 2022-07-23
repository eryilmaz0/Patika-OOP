using System;

namespace Zoo.Animals.Abstract
{
    public abstract class Rodents : Animal
    {
        public Rodents(int weight, int age):base(weight, age)
        {
            this.Family = "Rodents";
        }
        
        public override void Feed()
        {
            Console.WriteLine($"{this.Genus} ({this.Family}) Feeded.");
        }


        public override int GetFeedSchedule()
        {
            return 24;
        }
    }
}