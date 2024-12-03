using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociAggrCompo
{
    class Program
    {
        static void Main(string[] args)
        {
            Surgeon sobj = new Surgeon("Vijay", "vs030932");
            SecurityAccess sa = new SecurityAccess("vs030932");

            sa.Login(sobj);
            Console.WriteLine(sobj.Salary.ToString());
            sobj.HowIstheDoctor("Good");
            Console.WriteLine(sobj.Salary.ToString());

            Console.ReadKey();
        }
    }

    //association - Surgeon uses SecurityAccess
    class SecurityAccess
    {
        private string _userid;

        public SecurityAccess(string userid)
        {
            this._userid = userid;
        }
        public void Login(Surgeon obj)
        {
            if(obj.GetUserId == _userid)
            {
                Console.WriteLine("Surgeon logged in successfull");
            }
            else
            {
                Console.WriteLine("Not valid Surgeon");

            }

        } 

    }

    class Anesthelogist
    {

        private string _name;

        public Anesthelogist(string name)
        {
            this._name = name;
        }

        public string GetAnesthelogistName
        {
            get { return _name; }
        }

    }

    class Surgeon
    {
        private string _name;
        private string _userid;
        private double salary = 100000;
        //Aggregation
        List<Anesthelogist> Anesthelogists = new List<Anesthelogist>();
        cases caseObj = null;
        public Surgeon(string name, string userid)
        {
            this._name = name;
            this._userid = userid;
            caseObj = new cases(this);
        }

        public string GetSurgeonName
         {
             get{ return _name; }
         }

        public string GetUserId
        {
            get { return _userid; }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                salary = value;
            }
        }

        public void HowIstheDoctor(string str)
        {
            if (str == "Good")
            {
                caseObj.IsCaseSuccessful = true;
            }
            else
            {
                caseObj.IsCaseSuccessful = false;
            }
        }



    }


    class cases
    {

        private string casename;
        private string casenum;
        Surgeon surobj;
        bool isCaseSuccessful = false;
        public cases(Surgeon obj)
        {
            surobj = obj;
        }
        public bool IsCaseSuccessful
        {
            get { return isCaseSuccessful; }
            set
            {
                isCaseSuccessful = value;
                if (isCaseSuccessful == true)
                {
                    surobj.Salary = surobj.Salary +20000;
                }
                else
                {
                    surobj.Salary = surobj.Salary - 20000;
                }
            }
        }



    }



}
