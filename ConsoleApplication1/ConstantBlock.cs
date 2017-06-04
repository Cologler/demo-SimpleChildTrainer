namespace ConsoleApplication1
{
    public class ConstantBlock : Block
    {
        public ConstantBlock(decimal number)
        {
            this.Number = number;
        }

        public decimal Number { get; }

        public override decimal Value() => this.Number;
    }
}