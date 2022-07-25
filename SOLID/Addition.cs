using System;

namespace TrendyolSOLID
{
    public class Addition : CalculatorOperation
    {
        public Addition(int left, int right) : base(left, right)
        {
            
        }
        
        public override void SetResult()
        {
            Result = Left + Right;
            Console.WriteLine($"Addition Result : {Result}");
        }
    }
}