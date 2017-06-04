using System;
using System.Linq;

namespace ConsoleApplication1
{
    public class BlockGenerater
    {
        private readonly Random random;

        public BlockGenerater()
        {
            this.random = new Random();
        }

        private static bool IsVaild(Block left, Operator op, Block right)
        {
            if (op == Operator.Divide && right.Value() == 0) return false;

            return true;
        }

        public Block Generate(int level, Operator[] operators, int numberRange)
        {
            if (operators == null) throw new ArgumentNullException(nameof(operators));
            Block root = new ConstantBlock(this.random.Next(numberRange));
            foreach (var _ in Enumerable.Range(0, level))
            {
                while (true)
                {
                    var op = operators[this.random.Next(operators.Length)];
                    var ooc = op.GetOperateObjectsCount();
                    if (ooc == 2)
                    {
                        var second = Block.Constant(this.random.Next(numberRange));
                        var rootLeft = this.random.Next(2) == 0;
                        var left = rootLeft ? root : second;
                        var right = !rootLeft ? root : second;
                        if (IsVaild(left, op, right))
                        {
                            root = Block.Binary(left, op, right);
                            break;
                        }
                    }
                    else
                    {
                        throw new NotImplementedException();
                    }
                }
            }
            return root;
        }
    }
}