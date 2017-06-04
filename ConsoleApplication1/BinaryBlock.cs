using System;

namespace ConsoleApplication1
{
    public class BinaryBlock : Block
    {
        private decimal? value;

        public BinaryBlock(Block left, Operator op, Block right)
        {
            if (op.GetOperateObjectsCount() != 2) throw new ArgumentException();
            this.Left = left;
            this.Right = right;
            this.Operator = op;
        }

        public Block Left { get; }

        public Block Right { get; }

        public Operator Operator { get; }

        public override decimal Value()
        {
            if (this.value == null)
            {
                this.value = ((BinaryOperatorInfo) this.Operator.GetOperatorInfo())
                    .Invoke(this.Left.Value(), this.Right.Value());
            }
            return this.value.Value;
        }
    }
}