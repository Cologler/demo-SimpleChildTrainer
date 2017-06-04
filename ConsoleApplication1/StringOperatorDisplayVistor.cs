namespace ConsoleApplication1
{
    public class StringOperatorDisplayVistor : OperatorDisplayVistor<string>
    {
        protected override string VisitAdd() => "гл";

        protected override string VisitSubtract() => "гн";

        protected override string VisitMultiply() => "б┴";

        protected override string VisitDivide() => "б┬";
    }
}