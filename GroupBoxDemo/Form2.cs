using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBoxDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // pnl.Height = groupBox1.Height + 10;
           // MessageBox.Show(groupBox1.Height.ToString());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //RadioButton rd = sender as RadioButton;
            // int tag = (int)rd.Tag;
            if (radioButton1.Checked == true)
            {
                if(pnl != null)
                {
                    this.Controls.Remove(pnl);
                    this.Controls.Add(groupBox1);
                    this.groupBox1.Location = new System.Drawing.Point(87, 125);
                }

                groupBox1.Height = 120;
                this.pnl.AutoScroll = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                //MessageBox.Show(groupBox1.Height.ToString());
                pnl.Height = groupBox1.Height;
            }
           
        }

        Panel pnl = new Panel();
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                // 
                // pnl
                // 
                this.Controls.Add(pnl);
                this.pnl.Controls.Add(groupBox1);

                this.pnl.Location = new System.Drawing.Point(10, 100);

                this.pnl.BackColor = System.Drawing.Color.Red;
                this.pnl.Controls.Add(this.groupBox1);
                this.pnl.Location = new System.Drawing.Point(87, 125);
                this.pnl.Name = "pnl";
                this.pnl.Size = new System.Drawing.Size(739, 100);
                this.pnl.TabIndex = 0;
                this.pnl.HorizontalScroll.Enabled = false;
                this.pnl.HorizontalScroll.Visible = false;
                pnl.HorizontalScroll.Maximum = 0;
                this.pnl.AutoScroll = true;
                groupBox1.Height = 350;
                this.groupBox1.Location = new System.Drawing.Point(0, 0);

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
               // pnl.Height = groupBox1.Height;
            }
        }

        }
}
