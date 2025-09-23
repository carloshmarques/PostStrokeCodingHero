using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Program
    {
        /* Project that summarizes,
         * the files contained in the 'Week1_basics' directory:
         * (.cs files).
         */
        static void greetingCard()
        {
            // diplay my name
            string name = "Carlos";
            // to add comment ?
            string description = "C# Learning";
            // to add comment ?
            string reason = "convalescence";
            // Show a simple message on the screen
           Console.WriteLine($"Hello World, I'm {name}! I'm back to {description}, after a long {reason}!");
        }
        static void showVariables()
        {
            string name = "Carlos";
            int age = 51;

            Console.WriteLine($"My name is {name} and I am {age} years old.");
            Console.WriteLine("I'm using variables to train memory and focus.");
        }
        static void simpleMathDemo()
        {
            int a = 5;
            int b = 3;
            int sum = a + b;

            Console.WriteLine($"I can still do math: {a} + {b} = {sum}");
        }
        static void runProgram()
        {
            // Space reserved to run the program in an orderly manner and subject to future editing
            Console.WriteLine("\n--- Step 1: Greeting ---");
            greetingCard();

            Console.WriteLine("\n--- Step 1: Variables ---");
            showVariables();

            Console.WriteLine("\n--- Step 2: Simple Math ---");
            Console.WriteLine("\n🔢 Practicing math logic...");
            Console.WriteLine("\n...\n");

            simpleMathDemo();

        }
      
            static void Main(string[] args)
        {
            

            runProgram();  // Run The Program
            Console.ReadKey();   // Wait for a key press before closing

        }
    }
}
