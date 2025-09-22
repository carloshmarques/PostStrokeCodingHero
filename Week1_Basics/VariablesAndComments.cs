using System;

namespace Week1_Basics
{
    internal class VariablesAndComments
    {
        static void Main(string[] args)
        {
            // This is a number
            int age = 42;

            // This is a word
            string name = "Carlos";

            // Show the values
            Console.WriteLine($"Your name is {name} and your age is {age}.");

            // Wait for a key press
            Console.ReadKey();
        }
    }
}
