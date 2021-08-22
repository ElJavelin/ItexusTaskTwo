using System;

namespace ItexusTaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the binary number: ");
            new BinNumChecker().isGoodBinaryString(Console.ReadLine());
            Console.ReadKey();
        }
    }
}