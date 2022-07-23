using System;

namespace Zoo.Animals.Abstract
{
    public abstract class Animal
    {
        public string Genus { get; set; }
        public string Family { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }

        public abstract int GetDosage();
        public abstract int GetFeedSchedule();
        public abstract void Feed();


        public Animal(int weight, int age)
        {
            this.Weight = weight;
            this.Age = age;
        }


        public void PrintAnimalInformations()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Animal Informations");
            Console.WriteLine($"Animal Name : {this.Genus}");
            Console.WriteLine($"Animal Family : {this.Family}");
            Console.WriteLine($"Animal Weight : {this.Weight}");
            Console.WriteLine($"Animal Age : {this.Age}");
            Console.WriteLine($"Animal Feed Schedule : {this.GetFeedSchedule()}");
            Console.WriteLine($"Animal Dosage : {this.GetDosage()}");
            Console.WriteLine("------------------------------------------");
        }
    }
}