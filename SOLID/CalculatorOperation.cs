namespace TrendyolSOLID
{
    public abstract class CalculatorOperation
    {
        protected int Left { get; set; }
        protected int Right { get; set; }
        protected int Result { get; set; }

        public CalculatorOperation(int left, int right)
        {
            Left = left;
            Right = right;
        }

        public abstract void SetResult();
    }
}