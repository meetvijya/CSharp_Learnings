using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * The factory method is a creational design pattern, i.e., related to object creation.
In the Factory pattern, we create objects without exposing the creation logic to the client and the client uses the
same common interface to create a new type of object.
 */
namespace FactoryPattern
{

    // Prgm to Generate Bill based on Plan { Domestic /Institutional/ Commercial
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Plan Type: ");
            string planType = Console.ReadLine();

            Console.WriteLine("Enter Units: ");
            int units = int.Parse(Console.ReadLine());

            PlanFactory factoryObj = new PlanFactory();
            Plan planObj = factoryObj.getPlan(planType);

            planObj.getRate();
            planObj.CalculateBill(units);

            Console.ReadKey();

        }

        abstract class  Plan
        {
           protected double rate;
          abstract  public void  getRate();

            public void CalculateBill(int units)
            {
                Console.WriteLine("Generated Bill is: " + (units * rate).ToString());
            }
        }

        class Domestic:Plan
        {
            public override void getRate()
            {
                rate = 3.50;
            }
        }

        class Institutional : Plan
        {
           public  override void getRate()
            {
                rate = 5.50;
            }
        }

        class Commercial : Plan
        {
            public override void getRate()
            {
                rate = 7.50;
            }
        }

        // Facrtory Class used to create object of specific plan
        class PlanFactory
        {

            public Plan getPlan(string planType)
            {
                if (planType == null)
                    return null;

                if (planType == "DP")
                    return new Domestic();
                else if (planType == "IP")
                    return new Institutional();
                else if (planType == "CP")
                    return new Commercial();
                return null;
            }
        }

    }
}
