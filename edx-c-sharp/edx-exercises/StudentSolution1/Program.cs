using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    // Even squares get an 'O'
                    if ((row + col) % 2 != 0)
                    {
                        Console.Write("O");
                    }
                    // Odd squares get a 'X'
                    else
                    {
                        Console.Write("X");
                    }
                }
                Console.WriteLine("");
        }
            Console.WriteLine();
            Console.WriteLine("Press any key to end.");
            Console.ReadKey();
        }
    }
}
