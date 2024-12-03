using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace asyncAndawait
{
    /// <summary>
    /// async and await are  markers which tells the compiler from where the control has to resume. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread started");
            Method();
            Console.WriteLine("Main Thread completed");
            Console.ReadKey();
        }

        public static async void Method()
        {
            Console.WriteLine("File processing.Please wait...");
            int cnt=  await Task.Run(new Func<int>(Sleep));
            Console.WriteLine(" Numbers of characters in File are: " + cnt);         
        }

        public static int Sleep()
        {
            int count = 0;
            // Create a StreamReader and point it to the file to read
            using (StreamReader reader = new StreamReader("C:\\Temp\\temp.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                // Make the program look busy for 5 seconds
                Thread.Sleep(5000);
            }

            return count;

        }
    }
}
