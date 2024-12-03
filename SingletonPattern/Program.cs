using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
           DBClass DBObj = DBClass.CreateInstance();

            DBObj.Show();
            Console.ReadKey();
        }
    }
    class DBClass
    {
        private static DBClass DbClassObj = null;

        //Private class so that class cannot be instantiated
        private DBClass() { }
       

        public static DBClass CreateInstance()
        {
            if(DbClassObj == null)
            {
                return new DBClass();
            }

            return DbClassObj;
        }

        public void Show()
        {
            Console.WriteLine("Hi this is Vijay");
        }
    }
}
