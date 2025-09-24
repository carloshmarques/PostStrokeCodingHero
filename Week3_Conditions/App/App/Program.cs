using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Program
    {
        static void IfEslse()
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
        static void NestedIf()
        {
            int score = 85;

            if (score >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else
            {
                Console.WriteLine("Grade: C or below");
            }

            Console.ReadKey();

        }

        static void SwitchCase()
        {
            string day = "";

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
        }
        static void runProgram()
        {
            IfEslse();
            NestedIf(); 
            SwitchCase();   

        }

        static void Main(string[] args)
        {
             runProgram();
        }
    }
}
