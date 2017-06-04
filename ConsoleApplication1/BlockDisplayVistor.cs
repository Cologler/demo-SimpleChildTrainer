using System;

namespace ConsoleApplication1
{
    public abstract class BlockDisplayVistor<T>
    {
        protected abstract OperatorDisplayVistor<T> OperatorDisplayVistor { get; }

        public T Visit(Block block)
        {
            var constantBlock = block as ConstantBlock;
            if (constantBlock != null) return this.VisitConstant(constantBlock);

            var binaryBlock = block as BinaryBlock;
            if (binaryBlock != null) return this.VisitBinary(binaryBlock);

            throw new NotImplementedException();
        }

        protected abstract T VisitConstant(ConstantBlock block);

        protected abstract T VisitBinary(BinaryBlock block);
    }
}