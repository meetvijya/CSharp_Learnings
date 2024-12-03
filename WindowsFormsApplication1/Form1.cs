using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }

        // Class2 cv = new Class2();

        private void button1_Click(object sender, EventArgs e)
        {
            // IA c2 = new Class2();
            //  c2.display();           

            Utility.TransformMethod(10, Square);
            Utility.TransformMethod(10, Cube);
            //MessageBox.Show(j.ToString());
            //MessageBox.Show(t.ToString());
        }
        public static int Square(int i)
        {
            return (i * i);
        }

        //public System.Collections.Generic.IEnumerator<ElementType> GetEnumerator()
        //{

        //    throw new NotImplementedException();
        //    yield return default(ElementType);
        //}
        public static int Cube(int i)
        {
            return (i * i * i);
        }

        /// <summary>
        /// FIBONACCI NUMBER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 1;
            int temp = 0;

            StringBuilder str = new StringBuilder();
            str.Append(a);
            str.Append(" ");
            str.Append(b);
            for (int i = 0; i < 10; i++)
            {
                // MessageBox.Show(a.ToString(), b.ToString());
                temp = a + b;
                // MessageBox.Show(temp.ToString());
                str.Append(" ");
                str.Append(temp);
                a = b;
                b = temp;

            }

            MessageBox.Show(str.ToString());
        }


        //FACTORIAL OF A NUMBER
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Factorial of {textBox1.Text} = {Factorial(int.Parse(textBox1.Text))}");
        }

        private int Factorial(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }

            return fact;
        }

        /// <summary>
        /// PALINDROME NUMBER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);

            int n = num;
            int rev_num = 0, remainder = 0;

            while (n != 0)
            {
                remainder = n % 10;
                rev_num = rev_num * 10 + remainder;
                n = n / 10;
            }

            if (rev_num == num)
                MessageBox.Show("Number is Palindrome");
            else
                MessageBox.Show("Number is not Palindrome");
        }

        /// <summary>
        /// STRONG NUMBER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            int oNum = int.Parse(textBox1.Text);
            int n = oNum;
            int temp = 0, sum = 0;
            while (n != 0)
            {
                temp = n % 10;
                sum = sum + Factorial(temp);
                n = n / 10;
            }
            if (sum == oNum)
                MessageBox.Show($"{oNum} is  strong number");
            else
                MessageBox.Show($"{oNum} is  not a strong number");
        }


        //ASCII Value
        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 255; i++)
                MessageBox.Show($"ASCII value of character {(char)i}, {i.ToString()}");
        }

        /// <summary>
        /// Palindrome string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            StringBuilder str = new StringBuilder();

            char[] arry = txt.ToCharArray();

            for (int i = arry.Count() - 1; i >= 0; i--)
            {
                str = str.Append(arry[i]);
            }

            if (txt == str.ToString())
            {
                MessageBox.Show("Palindrome string");
            }
            else
                MessageBox.Show("Not Palindrome string");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // TODO Auto-generated method stub

            int[] a = new int[] { 10, 0, 5, 0, 0, 2, 0, 3, 0, 7, 6 };
            int i;
            int temp;

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[j] > 0)
                        {
                            temp = a[j];
                            a[j] = a[i];
                            a[i] = temp;
                            break;
                        }
                    }
                }
                MessageBox.Show(a[i].ToString());



            }


        }


        public class Utility
        {
            public delegate int Transform(int i);

            public static void TransformMethod(int x, Transform t)
            {
                // return t.Invoke(x);
                // return t(x);
                int i = t(x);
                MessageBox.Show("Value is:" + i.ToString());

            }

        }
        public class Class1
        {
            int x1 = 0;
            public Class1()
            {

            }

            public void Display()
            {
                //Class1 nn = new Class2();
                MessageBox.Show("hi Class 1");

            }


        }

        class Class2 : Class1, IA, IB
        {
            int x;

            public Class2()
            {

                // Class1 nn = new Class2();
                // nn.Display();
            }

            void IA.display()
            {

                MessageBox.Show("hi IA interface");
                // base.Display();

            }

            void IB.display()
            {

                MessageBox.Show("hi Class 2");
                // base.Display();

            }

            public void Display(int x)
            {

                MessageBox.Show("Overload");
            }

            //public string Display(int x)
            //{

            // return(   MessageBox.Show("Overload"));
            //}


        }

        interface IA
        {
            void display();
        }

        interface IB
        {
            void display();
        }
    }
}
