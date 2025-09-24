using System;

namespace Week2_Loops
{
    internal class ForLoopContinue
    {
        static void Main(string[] args)
        {
            // Loop from 0 to 9, skip number 3
            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    continue; // Skip this iteration
                }

                Console.WriteLine($"The value of i is {i}");
            }

            Console.ReadKey();
        }
    }
}
