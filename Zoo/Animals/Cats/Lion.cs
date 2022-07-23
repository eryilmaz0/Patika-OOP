namespace Zoo.Animals.Cats
{
    public class Lion : Abstract.Cats
    {
        public Lion(int weight, int age) : base(weight, age)
        {
            this.Genus = "Lion";
        }

        
        public override int GetDosage()
        {
            return 1;
        }
    }
}