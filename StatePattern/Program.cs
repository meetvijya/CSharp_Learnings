using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Department sales or accounts");
            string str = Console.ReadLine();
            new StatePatternDemo(str);

            Console.ReadKey();
        }

        interface IConnection
        {
            void Open();
            void Close();
            void LogActivities();
            void Update();
        }

        class Sales : IConnection
        {
            public void Close()
            {
                Console.WriteLine("Database Closed for Sales ");
            }

            public void LogActivities()
            {
                Console.WriteLine("Sales activity logged ");
            }

            public void Open()
            {
                Console.WriteLine("Database opened for Sales ");
            }

            public void Update()
            {
                Console.WriteLine("Database updated for Sales ");
            }
        }

        class Accounting : IConnection
        {
            public void Close()
            {
                Console.WriteLine("Database Closed for Accounting ");
            }

            public void LogActivities()
            {
                Console.WriteLine("Accounting activity logged ");
            }

            public void Open()
            {
                Console.WriteLine("Database opened for Accounting ");
            }

            public void Update()
            {
                Console.WriteLine("Database updated for Accounting ");
            }
        }

        class Controller
        {
            IConnection conObj;
            Accounting accObj;
            Sales saleObj;
            public Controller()
            {
                saleObj = new Sales();
                accObj = new Accounting();                
            }

            public void SetSaleObject()
            { conObj = saleObj; }

            public void SetAccountsObject()
            { conObj = accObj; }

            public void open()
            {
                conObj.Open();
            }
            public void close()
            {
                conObj.Close();
            }
            public void log()
            {
                conObj.LogActivities();
            }
            public void update()
            {
                conObj.Update();
            }
        }

        class StatePatternDemo
        {
            Controller con;

            public StatePatternDemo(string str)
            {
                con = new Controller();

                if(str == "sales")
                {
                    con.SetSaleObject();
                }
                else if(str=="accounts")
                {
                    con.SetAccountsObject();
                }

                con.open();
                con.close();
                con.log();
                con.update();
            }
        }
    }
}
