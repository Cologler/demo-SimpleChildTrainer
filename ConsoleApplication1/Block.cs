namespace ConsoleApplication1
{
    public abstract class Block
    {
        public abstract decimal Value();

        public static Block Constant(decimal value) => new ConstantBlock(value);

        public static Block Binary(Block left, Operator op, Block right) => new BinaryBlock(left, op, right);
    }
}