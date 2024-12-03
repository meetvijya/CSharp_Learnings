using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            JugPattern();
            Console.ReadKey();

        }

        static void JugPattern()
        {
           int rows = 8;
            int cols = 9;

            //int[,] arr = new int[rows,cols];

            for (int i = 1; i <= rows-5; i++)
            {
                Console.Write(" ");
                for (int j = 1; j <= 3; j++)
                {                   
                    Console.Write("*");
                }
                Console.WriteLine();
            }
           // int x = 8;
            for (int k = 1; k <= 3; k++)
            {
                int x = (k == 1 ? 8 : 7);
                for (int j = 1; j <= x; j++)
                {
                  if(k==2 && j==7)
                        Console.Write("  ");
                    if (k == 3 && j == 7)
                        Console.Write(" ");
                    Console.Write("*");

                }
                Console.WriteLine();
            }

            int t = 5;
            for (int k = 1; k <= 2; k++)
            {
                if(k==1)
                    Console.Write(" ");
                else
                    Console.Write("  ");
                for (int j = 1; j <= t; j++)
                {                    
                    Console.Write("*");
                }
                t = t - 3;
                Console.WriteLine();
            }

        }
        // Console.WriteLine();



    }
}
