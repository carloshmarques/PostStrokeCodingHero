using System;

namespace Week2_Loops
{
    internal class DoWhileBreak
    {
        static void Main(string[] args)
        {
            int x = 0;

            // Loop at least once, stop if x == 5
            do
            {
                if (x == 5)
                {
                    break; // Stop the loop
                }

                Console.WriteLine($"The value of x is {x}");
                x++;

            } while (x < 10);

            Console.ReadKey();
        }
    }
}
