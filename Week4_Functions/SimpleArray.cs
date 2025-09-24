using System;

namespace Week5_Arrays
{
    internal class SimpleArray
    {
        static void Main(string[] args)
        {
            string[] fruits = { "Apple", "Banana", "Cherry" };

            Console.WriteLine("My fruit list:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.ReadKey();
        }
    }
}
