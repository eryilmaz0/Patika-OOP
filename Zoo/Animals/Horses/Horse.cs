namespace Zoo.Animals.Horses
{
    public class Horse : Abstract.Horses
    {
        public Horse(int weight, int age) : base(weight, age)
        {
            this.Genus = "Horse";
        }

        public override int GetDosage()
        {
            return 3;
        }
    }
}