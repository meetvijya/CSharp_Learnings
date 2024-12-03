using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LambdaExpressionExample
{
    public partial class Form1 : Form
    {
        delegate int StudentDel(List<Student> s);
        delegate int StudentDel1(List<Student> s, int agelimit);
        List<Student> lststud = null;
        int cnt = 0;
        public Form1()
        {
            InitializeComponent();
           

        }

        private void UsingAnonymousMethod()
        {
            cnt = 0;
            //***Anonymus method ****

            StudentDel studDelObj = delegate (List<Student> lst)
            {

                foreach (Student s in lst)
                {
                    if (s.Age > 34)
                        cnt++;
                }
                return cnt;
            };
            MessageBox.Show(studDelObj(lststud).ToString());

        }

        private void NormalDelegateExample()
        {
            StudentDel studDelObj1 = new StudentDel(Check);
            // with normal method
            MessageBox.Show("Delegate Example: " + studDelObj1(lststud).ToString());

        }
        private int Check(List<Student> lst)
        {
            cnt = 0;
            foreach (Student s in lst)
            {
                if (s.Age > 34)
                    cnt++;
            }
            return cnt;
        }

        private void usingLambdaExpression()
        {
            // **** Using Lambda Experssion *****
            StudentDel studDelObj = delegate (List<Student> lst)
            {
                var cntr = lst.Where(s => s.Age > 34);
                return cntr.Count();
            };
            MessageBox.Show(studDelObj(lststud).ToString());
        }


        private void UsingLambdaExpMultipleParameter()
        {
            // ***** Multiple parameter and Multiline in method *****
            StudentDel1 studDelObj = (lst, agelimit) => lst.Where(s => s.Age > agelimit).Count();
            MessageBox.Show(studDelObj(lststud,24).ToString());
        }


        private void UsingFuncDelegate()
        {
            Func<List<Student>,int, int> studDelObj = (cntr,agelimit) => cntr.Where(a => a.Age > agelimit).Count();
            MessageBox.Show(studDelObj(lststud,24).ToString());
        }

        private List<Student> GetStudent()
        {
            //Student stud = new Student(1, "Vijay", 35);
            //Student stud2 = new Student(2, "Ravi", 55);
            lststud = new List<Student>();
            //lststud.Add(stud);
            //lststud.Add(stud2);

            lststud.Add(new Student(1, "Vijay", 35));
            lststud.Add(new Student(2, "Ravi", 55));
            return lststud;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetStudent();

            NormalDelegateExample();
        }

        // Lambda + Multiple Parametrs
        private void button1_Click(object sender, EventArgs e)
        {
            UsingLambdaExpMultipleParameter();
        }

        //Using Func
        private void button2_Click(object sender, EventArgs e)
        {
            UsingFuncDelegate();
        }

        private void Anontmousmethod_Click(object sender, EventArgs e)
        {
            UsingAnonymousMethod();
        }

        private void usinglambda_Click(object sender, EventArgs e)
        {
            usingLambdaExpression();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] words =  { "async", "string", "vijay123", };
           // string st = "aa ss ddd ff";
           // string[] stArray = st.Split(' ');
            //var arry = from word in words
            //             where word.Length > 5
            //             select word;
           // MessageBox.Show(arry.Count().ToString());
            var arry = words.Where(w => w.Length > 5).Count();
            MessageBox.Show(arry.ToString());
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student()
        {

        }
        public Student(int id , string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

    }

}
