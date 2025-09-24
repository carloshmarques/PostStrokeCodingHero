using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    internal class Program
    {
        static void loopWithFor()
        {
            Console.WriteLine("🔁 Practicing repetition with a for loop:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Looping with for: i = {i}");
            }
        }
        static void loopWithWhile()
        {
            Console.WriteLine("🔁 Practicing repetition with a while loop:");
            int x = 0;
            while (x < 5)
            {
                Console.WriteLine($"Looping with while: x = {x}");
                x++;
            }
        }
        static void loopWithBreak()
        {
            Console.WriteLine("⛔ Loop with break condition:");
            int x = 0;
            while (x < 10)
            {
                if (x == 5)
                {
                    Console.WriteLine("Reached 5, stopping loop.");
                    break;
                }
                Console.WriteLine($"x = {x}");
                x++;
            }
        }
        static void loopWithContinue()
        {
            Console.WriteLine("⏭️ Loop with continue (skipping 3):");
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("Skipping 3...");
                    continue;
                }
                Console.WriteLine($"i = {i}");
            }
        }
        static void runProgram()
        {


            Console.WriteLine("\n--- Step 1: For Loop ---");
            loopWithFor();

            Console.WriteLine("\n--- Step 2: While Loop ---");
            loopWithWhile();

            Console.WriteLine("\n--- Step 3: Break in Loop ---");
            loopWithBreak();

            Console.WriteLine("\n--- Step 4: Continue in Loop ---");
            Console.WriteLine("\n--- ---\n");
            loopWithContinue();
        }
            static void Main(string[] args)
        {
            runProgram();
        }
    }
}
