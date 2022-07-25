using System;

namespace TrendyolSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            // CalculatorOperation operation1 = new Addition(3, 5);
            // CalculatorOperation operation2 = new Subtraction(10, 5);
            //
            // new Calculator().Calculate(operation1);
            // new Calculator().Calculate(operation2);


            Operation.Operation operation = new Operation.Operation(10, 5);
            operation.SetOperation((left, right) => left + right);
            operation.SetResult();
            
            operation.SetOperation((left, right) => left - right);
            operation.SetResult();
        }
    }
}