namespace ConsoleApplication1
{
    public class OperatorInfo
    {
        public OperatorInfo(Operator op, int priority)
        {
            this.Operator = op;
            this.Priority = priority;
        }

        public Operator Operator { get; }

        public int Priority { get; }
    }
}