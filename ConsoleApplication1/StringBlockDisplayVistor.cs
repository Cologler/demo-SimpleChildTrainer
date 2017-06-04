namespace ConsoleApplication1
{
    public class StringBlockDisplayVistor : BlockDisplayVistor<string>
    {
        protected override OperatorDisplayVistor<string> OperatorDisplayVistor { get; }
            = new StringOperatorDisplayVistor();

        protected override string VisitConstant(ConstantBlock block)
            => block.Number.ToString();

        protected override string VisitBinary(BinaryBlock block)
            => "(" + string.Join(" ", this.Visit(block.Left), this.OperatorDisplayVistor.Visit(block.Operator), this.Visit(block.Right)) + ")";
    }
}