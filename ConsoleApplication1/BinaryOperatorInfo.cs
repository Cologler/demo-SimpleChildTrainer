using System;

namespace ConsoleApplication1
{
    public class BinaryOperatorInfo : OperatorInfo
    {
        private readonly Func<decimal, decimal, decimal> operatorFunc;

        public BinaryOperatorInfo(Operator op, int priority,
            Func<decimal, decimal, decimal> operatorFunc)
            : base(op, priority)
        {
            this.operatorFunc = operatorFunc;
        }

        public decimal Invoke(decimal number1, decimal number2)
            => this.operatorFunc(number1, number2);
    }
}