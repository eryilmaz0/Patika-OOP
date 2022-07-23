namespace Zoo.Animals.Rodents
{
    public class Rat : Abstract.Rodents
    {
        public Rat(int weight, int age) : base(weight, age)
        {
            this.Genus = "Rat";
        }

        public override int GetDosage()
        {
            return 6;
        }
    }
}