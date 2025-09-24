using System;

namespace Week5_Arrays
{
    internal class ArraySum
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5 };
            int sum = 0;

            foreach (int value in values)
            {
                sum += value;
            }
            // Output the result
            Console.WriteLine($"The total sum is: {sum}");
            //
            Console.ReadKey();
        }
    }
}
