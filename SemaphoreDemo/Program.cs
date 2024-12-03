using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SemaphoreDemo
{
    class Program
    {
        static Semaphore sema = new Semaphore(3,5);
       // static SemaphoreSlim semaslim = new SemaphoreSlim(3);
        static  Stopwatch sw = new Stopwatch();
        static void Main(string[] args)
        {            
            sw.Start();
            for (int i = 1; i <= 5; i++) new Thread(Enter).Start(i);
            Console.WriteLine(sw.Elapsed.ToString());
            Console.ReadKey();
        }

        private static void Enter(object id)
        { 
            Console.WriteLine(id + " wants to enter ");
            //semaslim.Wait();
            sema.WaitOne();
            Console.WriteLine(id +" is in");
            Thread.Sleep(10000 * (int)id);
            Console.WriteLine(id + " is leaving");
            sema.Release();
           // semaslim.Release();
            sw.Stop();

           
        }
    }
}
