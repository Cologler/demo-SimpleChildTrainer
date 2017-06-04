using System;

namespace ConsoleApplication1
{
    public abstract class OperatorDisplayVistor<T>
    {
        public T Visit(Operator op)
        {
            switch (op)
            {
                case Operator.Add: return this.VisitAdd();
                case Operator.Subtract: return this.VisitSubtract();
                case Operator.Multiply: return this.VisitMultiply();
                case Operator.Divide: return this.VisitDivide();

                default:
                    throw new ArgumentOutOfRangeException(nameof(op), op, null);
            }
        }

        protected abstract T VisitAdd();

        protected abstract T VisitSubtract();

        protected abstract T VisitMultiply();

        protected abstract T VisitDivide();
    }
}