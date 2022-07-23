namespace Zoo.Animals.Rodents
{
    public class Beaver : Abstract.Rodents
    {
        public Beaver(int weight, int age) : base(weight, age)
        {
            this.Genus = "Beaver";
        }

        public override int GetDosage()
        {
            return 5;
        }
    }
}