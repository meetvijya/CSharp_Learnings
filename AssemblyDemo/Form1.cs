using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssemblyDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // customer cust = new customer();
            // MessageBox.Show(cust.GetFullName("vijay","sawant"));

            Assembly exe = Assembly.GetExecutingAssembly();
            Type type = exe.GetType("AssemblyDemo.customer");

            object obj = Activator.CreateInstance(type);
            string[] param = { "vijay", "sawant" };

            MessageBox.Show(type.GetMethod("GetFullName").Invoke(obj, param).ToString());           
        }
            
       
    }

    class customer
    {
        string FirstName = string.Empty;
        string LastName = string.Empty;

        public string GetFullName(string fname, string lname)
        {
            return fname + " " + lname;
        }

    }
}
