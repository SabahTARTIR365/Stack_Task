using System;
namespace StackTask
{
    class Program
    {
        static void Main(string[] args)
        {  //double sum = 0.0;
            Console.WriteLine("Hello World!");
            var stack = new STACK<double>();
            stack.Push(1.5);
            stack.Push(37.5);
            stack.Push(5.2);
            stack.Print();
            stack.Pop();
            stack.Print();
            stack.Peak();
            stack.Clear();
             // System.Console.WriteLine($"sum{sum}");
             stack.Peak();
             
        }
    }
}
