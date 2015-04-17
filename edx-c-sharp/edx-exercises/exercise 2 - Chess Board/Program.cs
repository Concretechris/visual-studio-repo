using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_2___Chess_Board
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("XOXOXOXO");
                Console.WriteLine("OXOXOXOX");        
            }

            //Added to keep CLI open after our for loop runs. 
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();   
        }
    }
}
