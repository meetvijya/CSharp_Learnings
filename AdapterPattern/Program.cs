using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        //Client
        static void Main(string[] args)
        {
            ICreditCard card = new BankCustomer();
            card.GetBankDetails();
            Console.WriteLine(card.GetCreditcardDetails());
            Console.ReadKey();
        }
        //Target  which Client wants
        interface  ICreditCard
        {
            void GetBankDetails();
            string GetCreditcardDetails();
        }
        //Adaptee
        class BankDetails
        {
            public int AccountNumber { get; set; }
            public string Name { get; set; }
            public string BankName { get; set; }
        }
        class BankCustomer:BankDetails,ICreditCard
        {

            public void GetBankDetails()
            {
                Console.WriteLine("Enter the account holder name :");
                Name = Console.ReadLine();
                Console.WriteLine("\n");

                Console.WriteLine("Enter the account number:");
                AccountNumber= int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine("Enter the bank name :");
                 BankName = Console.ReadLine(); 
            }

            public string GetCreditcardDetails()
            {
                return ("The Account number " + AccountNumber + " of " + Name + " in " + BankName + " bank is valid and authenticated for issuing the credit card. ");  
            }
        }

    }
}
