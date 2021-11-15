//  retrohGamr
//  10/26/21
//  Chapter 6 Exercise 1

using System;

namespace Chapter_6_Exercise_1
{
    class Program
    {
        readonly static string InitialMessage = "Please input an integer to determine if it is even or odd.";

        static void Main()
        {
            AppFunc();
        }

        static void AppFunc()
        {
            long check;
            string input;

            Console.WriteLine(Program.InitialMessage);

            input = Console.ReadLine();

            try
            {
                check = long.Parse(input);
                if (IsEven(check))
                {
                    Console.WriteLine();
                    Console.WriteLine("Your input is EVEN");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Your input is ODD");
                }
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine();
                Console.WriteLine($"      {ex.Message}");
            }

            Console.WriteLine("______________________________________");
            Console.WriteLine();

            AppFunc();
        }

        static bool IsEven(long inputNum)
        {
            return inputNum % 2 == 0;
        }
    }
}
