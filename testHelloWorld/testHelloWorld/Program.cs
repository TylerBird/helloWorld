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
            Console.WriteLine("--- M U L T I P L I C A T I O N ---");
            MultFunction();
            Console.WriteLine("--- D I V I S I O N ---");
            DivFunction();
        }

        static void AddFunction()
        {
            Console.Write("Enter first number you wanne sum: ");
            UInt32 sum1 = UInt32.Parse(Console.ReadLine());
            Console.Write("Enter second number you wanne sum: ");
            UInt32 sum2 = UInt32.Parse(Console.ReadLine());
            Console.WriteLine(sum1 + " + " + sum2 + " = " + (sum1 + sum2));
        }

        static void SubFunction()
        {
            Console.Write("Enter first number you wanne sub: ");
            Int32 sum1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number you wanne sub: ");
            Int32 sum2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(sum1 + " - " + sum2 + " = " + (sum1 - sum2));
        }

        static void MultFunction()
        {
            Console.Write("Enter first number you wanne mult: ");
            Int32 sum1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number you wanne mult: ");
            Int32 sum2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(sum1 + " * " + sum2 + " = " + (sum1 * sum2));
        }

        static void DivFunction()
        {
            Console.Write("Enter first number you wanne div: ");
            Int32 sum1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number you wanne div: ");
            Int32 sum2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(sum1 + " / " + sum2 + " = " + (sum1 / sum2));
        }
    } 
}
