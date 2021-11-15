//    retrohGamr
//    10/26/21
//    Chapter 6 Exercise 3


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6_Exercise_3
{
    class Program
    {
        static void Main()
        {
            AppFunc();
        }

        static void AppFunc()
        {
            Console.WriteLine("Square of Asterisk method program.  Enter parameter to see result.");
            try
            {
                SquareOfAsterisks(int.Parse(Console.ReadLine()));
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            AppFunc();
        }

        static void SquareOfAsterisks(int x)
        {
            for (int i = 0; i < x; i++)
            {
                string row = "";
                for (int j = 0; j < x; j++)
                {
                    row += "*";
                }
                Console.WriteLine(row);
            }
        }
    }
}
