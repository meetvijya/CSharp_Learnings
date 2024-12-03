using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingMinimuCostPrgm
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter size of Array");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Cost");
            int cost = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Array");

            int[] arr = new int[N];            
            List<int> output = new List<int>();
            for (int i = 0; i < N; i++)
            {
               arr[i]= int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Array is");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(arr[i]);
            }

            for(int i=0; i<N;i++)
            {
                for(int j=i+1;j<N;j++)
                {
                    output.Add(cost * (arr[i] + arr[j]));
                }
            }

            
            Console.WriteLine("Output Array is");
            for (int i = 0; i < output.Count; i++)
            {
                Console.WriteLine(output[i]);
            }
            output.Sort();
            Console.WriteLine($"Minimum cost is {output[0].ToString()}" );
            Console.ReadKey();
        }
    }
}
