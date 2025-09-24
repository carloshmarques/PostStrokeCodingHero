using System;

namespace Week2_Loops
{
    internal class ForLoop
    {
        static void Main(string[] args)
        {
            // Loop from 0 to 9
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"The value of i is {i}");
            }

            Console.ReadKey(); // Wait for a key press
        }
    }
}

