namespace ConsoleApplication1
{
    public class StringOperatorDisplayVistor : OperatorDisplayVistor<string>
    {
        protected override string VisitAdd() => "��";

        protected override string VisitSubtract() => "��";

        protected override string VisitMultiply() => "��";

        protected override string VisitDivide() => "��";
    }
}