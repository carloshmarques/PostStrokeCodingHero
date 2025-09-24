using System;

namespace Week3_Conditions
{
    internal class IfElse
    {
        static void Main(string[] args)
        {
            int age = 51;

            if (age < 18)
            {
                Console.WriteLine("You are a minor.");
            }
            else
            {
                Console.WriteLine("You are an adult.");
            }

            Console.ReadKey();
        }
    }
}
