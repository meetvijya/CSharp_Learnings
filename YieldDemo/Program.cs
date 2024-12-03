using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldDemo
{
    /// <summary>
    ///  Yield keyword used for  
    ///  Custom Iteration without using temp collection.
    ///  State full iteration.. Preserve value between iteration.
    /// </summary>
    class Program
    {
       static  List<int> lst = new List<int>();
        static void Main(string[] args)
        {
            LoadList();

            //foreach (int n in lst.Where(i => i > 3))
                //custom iteration without temp collection
            foreach (int n in filter())
            {
                Console.WriteLine(n);
            }
           
            Console.WriteLine("*****");
        
            foreach (int n in RunningTotal())
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }

       public static void LoadList()
        {            
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);
            lst.Add(4);
            lst.Add(5);
        }

        // Custom Iteration.
        public static IEnumerable<int> filter()
        {
           // List<int> temp = new List<int>();

            foreach(int i  in lst)
            {
                if (i > 3)
                    //temp.Add(i);
                    yield return i;
            }
            //return temp;
        }

        // stateful iteration : perserve value to Variable Total between iterations.
        public static IEnumerable<int> RunningTotal()
        {
            int total = 0;
            foreach (int i in lst)
            {
                total = total + i;
                yield return (total);
            }
        }
    }
}
