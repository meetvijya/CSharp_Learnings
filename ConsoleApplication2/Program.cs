using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Program
    {
        static void arryMethod(int[] a)
        {
            int[] b = new int[5];
            a = b;

        }

        static void Main(string[] args)
        {
            int[] a = new int[10];
            arryMethod(a);
            Console.WriteLine(a.Length);

            A aObj = new A();
            aObj.a = 10;
            A bObj = new A();
            bObj = aObj;// aObj.CloneCopy();  
            bObj.a = 20;
            Console.WriteLine(aObj.a);



            List<Employee> emplist = new List<Employee>
            {
                new Employee {Id = 1,EmpName="vijay",Location="Bangalore", Salary=10000 , JoinDate = new DateTime(20230111090000)},
                new Employee {Id = 1,EmpName="ravi",Location="Bangalore"},
                new Employee {Id = 1,EmpName="nandu", Salary=10000}
                
            };



            Console.ReadKey();
        }
    }

    public class A
    {
       public  int a;

        public A CloneCopy()
        {
           return (A) this.MemberwiseClone();
        }
    }
}
