using System;

namespace Week5_Arrays
{
    internal class ArrayIndex
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40 };

            Console.WriteLine($"First number: {numbers[0]}");
            Console.WriteLine($"Last number: {numbers[numbers.Length - 1]}");

            Console.ReadKey();
        }
    }
}
