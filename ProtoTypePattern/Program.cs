using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * The prototype pattern is a creational design pattern. Prototype patterns are required, 
 * when object creation is time consuming, and costly operation, so we create objects with the existing object itself.
 *  One of the best available ways to create an object from existing objects is the clone() method. Clone is the simplest approach to implement a prototype pattern.
 * 
 */
namespace ProtoTypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(030, "Vijay");
            Console.WriteLine("Id is: "+ emp.eid.ToString());
            Console.WriteLine("Name is: "+ emp.empname);

            //Clone emp object
            Employee e2 = (Employee)emp.getClone();
            
            Console.WriteLine("After Cloning");
            Console.WriteLine("Emp 2 Id is: "+ e2.eid.ToString());
            Console.WriteLine("Emp 2 Name is: "+ e2.empname);

            e2.empname = "sawant";

            Console.WriteLine("Emp 2 Name is: " + e2.empname);
            Console.WriteLine("Name is: " + emp.empname);
            Console.ReadKey();
        }
        interface IPrototype
        {
            IPrototype getClone();
        }

        class Employee:IPrototype
        {
            public int eid { get; set; }

            public string empname { get; set; }
            public Employee(int id, string name)
            {
                eid = id;
                empname = name;
            }

            public IPrototype getClone()
            {
               return new Employee(eid, empname);
            }
        }
    }
}
