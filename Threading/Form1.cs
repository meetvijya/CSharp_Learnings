using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threading
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Mutex
        private void button1_Click(object sender, EventArgs e)
        {
            Mutex m = new Mutex();
            int cnt = 0;
            Thread T1 = new Thread(() =>
           {
               m.WaitOne();
               for (int i = 0; i < 100000; i++)
               {
                   cnt++;
               }

               m.ReleaseMutex();
           });

            Thread T2 = new Thread(() =>
                {
                    m.WaitOne();
                    for (int j = 0; j < 100000; j++)
                    {
                        cnt++;
                    }
                    m.ReleaseMutex();

                });

            T1.Start();            
            T2.Start();
            T1.Join();
            T2.Join();
            MessageBox.Show($" Total count is {cnt}");
           // MessageBox.Show("Main thread ended");
        }

        /// <summary>
        /// Mutex within processes  i.e same mutex used in multiple places
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            //  Demo mutex
            Mutex m = new Mutex(false, "Demo_Mutex");
            int n = 1;
            while(n < 5)
            {
                 if(m.WaitOne(100))
                {
                    MessageBox.Show("Mutex is going to release");
                    n++;
                }
                 else
                {
                    MessageBox.Show("Mutex is not free");
                }
            }

        }

        //ThreadStart
        private void button2_Click(object sender, EventArgs e)
        {
            Thread T1 = new Thread(new ThreadStart(Number));
            T1.Start();
        }

        void Number()
        {
            int n = 101;
            if((n & 1) == 0)  // n&1 == 0 => Number is even  ; n&1 == 1 => Number is Odd  
             //  if ( n % 2 == 0)
            {
                MessageBox.Show("Number is Even");
            }
            else
            {
                MessageBox.Show("Number is Odd");
            }

        }
        void WhichNumber(object n)
        {
           // int n = 100;
            if (int.Parse(n.ToString()) % 2 == 0)
            {
                MessageBox.Show("Number is Even");
            }
            else
            {
                MessageBox.Show("Number is Odd");
            }

        }

        //Parameterized  Thread
        private void button3_Click(object sender, EventArgs e)
        {
            Thread T1 = new Thread(WhichNumber);
            T1.Start(3);
             
          //  T1.Abort();
        }

        //Interlocked
        private void button4_Click(object sender, EventArgs e)
        {
            Total = 0; 
            Thread T1 = new Thread(AddOneMillion);
            Thread T2 = new Thread(AddOneMillion);
            Thread T3 = new Thread(AddOneMillion);

            T1.Start();
            T2.Start();
            T3.Start();

            T1.Join();
            T2.Join();
            T3.Join();

            MessageBox.Show("Toatal is:" + Total);
        }

        int Total = 0;
        object lockobj = new object();
        public void AddOneMillion()
        {
            for(int i=0; i < 100000;i++)
            {
                 Interlocked.Increment(ref Total);
                //lock (lockobj)
                //{ Total++; }
            }
        }


        public void AddTwoMillion()
        {
            for (int i = 0; i < 200000; i++)
            {
                Monitor.Enter(lockobj);
                try
                {
                    Total++;
                }
                finally
                    { Monitor.Exit(lockobj); }
            }
        }

        //Monitor 
        private void button6_Click(object sender, EventArgs e)
        {
            Total = 0;
            Thread T1 = new Thread(AddTwoMillion);
            Thread T2 = new Thread(AddTwoMillion);
            Thread T3 = new Thread(AddTwoMillion);

            T1.Start();
            T2.Start();
            T3.Start();

            T1.Join();
            T2.Join();
            T3.Join();

            MessageBox.Show("Total is:" + Total);
        }

        //Deadlock
        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Main Started");
            Account A1 = new Account(101,5000);
            Account A2 = new Account(102,10000);

            AccountManager accmngr = new AccountManager(A1, A2, 1000);
            Thread T1 = new Thread(accmngr.Transfer);
            T1.Name = "T1";

            AccountManager accmngr1 = new AccountManager(A2, A1, 2000);
            Thread T2 = new Thread(accmngr1.Transfer);
            T2.Name = "T2";

            T1.Start();
            T2.Start();

            T1.Join();
            T2.Join();

            MessageBox.Show("Main completed");

        }

       // AutoResetEvent auto = new AutoResetEvent(false); // setting it to true will automatically call the set method no need to explcitly calling it
        EventWaitHandle auto = new EventWaitHandle(false, EventResetMode.AutoReset, "auto");
        //AutoResetEvent
        private void button8_Click(object sender, EventArgs e)
        {
           
            Thread tTheard = new Thread(SomeMethod);
            tTheard.Start();
            MessageBox.Show("Main");
            auto.Set();
            //MessageBox.Show("Main");
        }

        private void SomeMethod()
        {
            MessageBox.Show("Started");
            auto.WaitOne();
            MessageBox.Show("Finished");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //SemaphoreSlim  sem = new SemaphoreSlim
        }
    }





    public class Account
    {
        public int id { get; set; }

        public double balance { get; set; }

        public Account(int aid , double bal)
        {
            id = aid;
            balance = bal;
        }
         public void Withdraw(double amt)
        {
            balance =- amt;
        }

        public void Deposit(double amt)
        {
            balance =+ amt;
        }
    }

    public class AccountManager
    {
        Account fromAcc;
        Account toAcc;
        double transferAmt;

        public AccountManager(Account from , Account to , double amountd)
        {
            fromAcc = from;
            toAcc = to;
            transferAmt = amountd;
        }

       public void Transfer()
        {

            object l1 ;
            object l2 ;
            //for reproduce deadlock   comment below if
            if (fromAcc.id < toAcc.id)
            {
                l1 = fromAcc;
                l2 = toAcc;
            }
            else
            {
                l1 = toAcc;
                l2 = fromAcc;
            }

            MessageBox.Show(Thread.CurrentThread.Name
           + " trying to acquire lock on "
           + ((Account)l1).id.ToString());
            lock (l1)   //for reproduce deadlock   lock(fromAcc)
            {
                MessageBox.Show(Thread.CurrentThread.Name + " acquired lock on " + ((Account)l1).ToString());
                Thread.Sleep(5000);
                MessageBox.Show(Thread.CurrentThread.Name + " suspended for 1 second");
                lock (l2)  //for reproduce deadlock use  lock(toAcc)
                {
                    MessageBox.Show(Thread.CurrentThread.Name
                   + " acquired lock on "
                   + ((Account)l2).id.ToString());
                    fromAcc.Withdraw(1000);
                    toAcc.Deposit(2000);

                    MessageBox.Show(Thread.CurrentThread.Name + " Transfered "
                    + transferAmt.ToString() + " from "
                    + fromAcc.id.ToString() + " to "
                    + toAcc.id.ToString());
                }
            }
            }
        
    }

}
