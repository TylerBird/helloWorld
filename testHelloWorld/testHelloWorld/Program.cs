using System;

namespace testHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is the first change of my code.");
            AddFunction();
        }

        static void AddFunction()
        {
            Console.Write("Enter first number you wanne sum: ");
            UInt32 sum1 = UInt32.Parse(Console.ReadLine());
            Console.Write("Enter second number you wanne sum: ");
            UInt32 sum2 = UInt32.Parse(Console.ReadLine());
            Console.WriteLine(sum1 + " + " + sum2 + " = " + (sum1+sum2));
        }
    }
}
