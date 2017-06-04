using System;
using System.Diagnostics;
using System.Linq;

namespace ConsoleApplication1
{
    public static class OperatorExtensions
    {
        private static readonly Operator[] AllOperators;
        private static readonly OperatorInfo[] OperatorActions;

        static OperatorExtensions()
        {
            AllOperators = (Operator[])Enum.GetValues(typeof(Operator));

            OperatorActions = new OperatorInfo[]
            {
                new BinaryOperatorInfo(Operator.Add, 0, (a, b) => a + b),
                new BinaryOperatorInfo(Operator.Subtract, 0, (a, b) => a - b),
                new BinaryOperatorInfo(Operator.Multiply, 1, (a, b) => a * b),
                new BinaryOperatorInfo(Operator.Divide, 1, (a, b) => a / b),
            };

            Test();
        }

        public static Operator[] Operators() => AllOperators.ToArray();

        [Conditional("DEBUG")]
        private static void Test()
        {
            var array = Operators();
            Debug.Assert(array.Length == OperatorActions.Length);
            for (var i = 0; i < array.Length; i++)
            {
                Debug.Assert(OperatorActions[i].Operator == array[i]);
            }
        }

        public static OperatorInfo GetOperatorInfo(this Operator op) => OperatorActions[(int) op];

        public static int GetOperateObjectsCount(this Operator op) => 2;
    }
}