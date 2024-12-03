using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // MatrixAddition();
           // MatrixTranspose();

            //Below code is used for mutex demo with Threading Project
            Mutex m = new Mutex(false, "Demo_Mutex");
            //EventWaitHandle are = new EventWaitHandle(false, EventResetMode.AutoReset, "auto"); //AutoResetEvent
             m.WaitOne();
          //  are.WaitOne();
            Console.WriteLine("Press any key to release Mutex");
            Console.ReadLine();
            m.ReleaseMutex();
           // are.Set();
        }

        private static void MatrixAddition()
        {
            int[,] a = new int[3, 3];
            int[,] b = new int[3, 3];
            int[,] c = new int[3, 3];
            int m = 0, n = 0;

            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first matirx A:");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter Matrix B:");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Addition of Matrix
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }

            Console.WriteLine("Addition Matrix is:");


            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(c[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.Read();
        }

        private static void MatrixTranspose()
        {        
           
           
            int m = 0, n = 0;

            Console.WriteLine("Enter number of rows:");
              m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of columns:");
              n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first matirx A:");
            int[,] a = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int[,] c = new int[m, n];
            //Transpose of Matrix
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    c[i, j] = a[j, i];
                }
            }

            Console.WriteLine("Transpose Matrix is:");
           

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(c[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
