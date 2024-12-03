using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            AbstractFactory absFactBank = FactoryCreator.getFactory("Bank");
           Console.WriteLine(absFactBank.getBank("HDFC").getBankDetails());

            AbstractFactory absFactLoan = FactoryCreator.getFactory("Loan");
            loan l = absFactLoan.getLoan("Home");
            l.getRate(9.75);
            l.calculateLoanPayment(3300000, 20);
            Console.ReadKey();
        }

        interface  IBank  {
            string getBankDetails();
        }

        abstract class loan
        {
            public double rate;
            abstract public void getRate(double rate);          
            public void calculateLoanPayment(double loanamount, int years)
            {
                /* 
                      to calculate the monthly loan payment i.e. EMI   

                      rate=annual interest rate/12*100; 
                      n=number of monthly installments;            
                      1year=12 months. 
                      so, n=years*12; 

                    */

                double EMI;
                int n;

                n = years * 12;
                rate = rate / 1200;
                EMI = ((rate * Math.Pow((1 + rate), n)) / ((Math.Pow((1 + rate), n)) - 1)) * loanamount;

               Console.WriteLine("your monthly EMI is " + EMI + " for the amount" + loanamount + " you have borrowed");            
           }
        }


       public class HDFC:IBank
        {
            string bankName = string.Empty;
            public HDFC()
            {
                this.bankName = "HDFC Bank";
            }

            public  string getBankDetails()
            {
                return this.bankName;
            }
        }

        public class SBI : IBank
        {
            string bankName = string.Empty;
            public SBI()
            {
                this.bankName = "SBI Bank";
            }

            public string getBankDetails()
            {
                return this.bankName;
            }
        }

         class HomeLoan : loan
        {
            public override void getRate(double rate)
            {
                this.rate = rate;
            }
        }
         class BusinessLoan : loan
        {
            public override void getRate(double rate)
            {
                this.rate = rate;
            }
        }
        abstract class AbstractFactory
        {

          public  abstract IBank getBank(string type);
          public abstract loan getLoan(string type);

        }
        class BankFactory : AbstractFactory
        {
            public override IBank getBank(string bank)
            {
                if (bank == "HDFC")
                {
                    return new HDFC();
                }

                else if (bank == "SBI"){
                    return new SBI();
                }
                return null;
            }

            public override loan getLoan(string loan)
            {
                return null;
            }
        }
        class LoanFactory : AbstractFactory
        {
            public override loan getLoan(string loan)
            {
                if (loan == "Home")
                {
                    return new HomeLoan();
                }

                else if (loan == "Business")
                {
                    return new BusinessLoan();
                }
                return null;
            }

            public override IBank getBank(string bank)
            {
                return null;
            }
        }



        class FactoryCreator
        {
            public static AbstractFactory getFactory(string Choice)
            {
                if (Choice == "Bank")
                    return new BankFactory();
                else if (Choice == "Loan")
                    return new LoanFactory();
                return null;
            }
        }

    }
}
