using System;

namespace Week3_Conditions
{
    internal class SwitchCase
    {
        static void Main(string[] args)
        {
            string day = "Monday";

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("Start of the week.");
                    break;
                case "Friday":
                    Console.WriteLine("Almost weekend!");
                    break;
                default:
                    Console.WriteLine("Just another day.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
