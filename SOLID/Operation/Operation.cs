using System;

namespace TrendyolSOLID.Operation
{
    public class Operation
    {
        public int Left { get; set; }
        public int Right { get; set; }
        public int Result { get; set; }
        public Func<int,int,int> Operator { get; set; }

        public Operation(int left, int right)
        {
            Left = left;
            Right = right;
        }
        

        public void SetOperation(Func<int,int, int> operation)
        {
            Operator = operation;
        }


        public void SetResult()
        {
            Result = Operator.Invoke(Left, Right);
            Console.WriteLine($"Operation Result : {Result}");
        }
        
    }
}