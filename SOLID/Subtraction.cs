using System;

namespace TrendyolSOLID
{
    public class Subtraction : CalculatorOperation
    {

        public Subtraction(int left, int right) : base(left, right)
        {
            
        }


        public override void SetResult()
        {
            this.Result = Left - Right;
            Console.WriteLine($"Subtraction Result : {Result}");
        }
    }
}