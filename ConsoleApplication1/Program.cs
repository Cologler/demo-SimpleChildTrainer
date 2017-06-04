using System;
using System.Numerics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var generater = new BlockGenerater();
            
            while (true)
            {
                var displayVistor = new StringBlockDisplayVistor();
                var block = generater.Generate(3, OperatorExtensions.Operators(), 20);
                Console.WriteLine("question: " + displayVistor.Visit(block));
                Console.Write("press any key to view the answer...");
                Console.ReadLine();
                Console.WriteLine("answer: " + block.Value());
                Console.WriteLine();
            }
        }
    }
}
