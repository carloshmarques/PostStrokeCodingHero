using System;

namespace Week2_Loops
{
    internal class WhileLoop
    {
        static void Main(string[] args)
        {
            int x = 0;

            // Loop while x is less than 10
            while (x < 10)
            {
                Console.WriteLine($"The value of x is {x}");
                x++;
            }

            Console.ReadKey();
        }
    }
}
