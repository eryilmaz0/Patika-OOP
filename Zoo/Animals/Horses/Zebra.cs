namespace Zoo.Animals.Horses
{
    public class Zebra : Abstract.Horses
    {
        public Zebra(int weight, int age) : base(weight, age)
        {
            this.Genus = "Zebra";
        }

        public override int GetDosage()
        {
            return 4;
        }
    }
}