using System;

namespace testHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is the first change of my code.");
            Console.WriteLine("--- S U M M I N G ---");
            AddFunction();
            Console.WriteLine("--- S U B T R A C T I N G ---");
            SubFunction();
        }

        static void AddFunction()
        {
            Console.Write("Enter first number you wanne sum: ");
            UInt32 sum1 = UInt32.Parse(Console.ReadLine());
            Console.Write("Enter second number you wanne sum: ");
            UInt32 sum2 = UInt32.Parse(Console.ReadLine());
            Console.WriteLine(sum1 + " + " + sum2 + " = " + (sum1+sum2));
        }

        static void SubFunction()
        {
            Console.Write("Enter first number you wanne sub: ");
            Int32 sum1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number you wanne sub: ");
            Int32 sum2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(sum1 + " - " + sum2 + " = " + (sum1 - sum2));
        }
    }
}
