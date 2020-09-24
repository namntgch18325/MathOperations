using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class Process
    {
        public static void Run()
        {
            MathOperations math = new MathOperations();
            Console.WriteLine("Int " + math.Add(1, 1));
            Console.WriteLine("Double " + math.Add(1.5f, 1.5f, 1.5f));
            Console.WriteLine("Decimal " + math.Add(1m, 2m, 3m));
        }
    }
}
