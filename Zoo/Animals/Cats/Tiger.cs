namespace Zoo.Animals.Cats
{
    public class Tiger : Abstract.Cats
    {
        public Tiger(int weight, int age) : base(weight, age)
        {
            this.Genus = "Tiger";
        }

        
        public override int GetDosage()
        {
            return 2;
        }
    }
}