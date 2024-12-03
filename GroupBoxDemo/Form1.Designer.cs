namespace GroupBoxDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnl = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnl);
            this.groupBox1.Location = new System.Drawing.Point(44, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            groupBox1.BackColor = System.Drawing.Color.Aqua;
            // 
            // pnl
            // 

            this.pnl.BackColor = System.Drawing.Color.Red;
            this.pnl.Controls.Add(this.lbl);
            this.pnl.Controls.Add(this.txt);
            this.pnl.Controls.Add(this.lbl1);
            this.pnl.Controls.Add(this.txt1);
            this.pnl.Controls.Add(this.lbl2);
            this.pnl.Controls.Add(this.txt2);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.pnl.Location = new System.Drawing.Point(3, 16);
            this.pnl.Name = "pnl";
           // this.pnl.Size = this.groupBox1.Size;
            this.pnl.TabIndex = 0;
            //pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnl.AutoSize = true;
           
            // 
            // lbl
            // 
            this.lbl.Location = new System.Drawing.Point(3, 50);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(100, 23);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Start";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(123, 50);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 20);
            this.txt.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.Location = new System.Drawing.Point(3, 70);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(100, 23);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Stop";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(123, 70);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 3;
            // 
            // lbl2
            // 
            this.lbl2.Location = new System.Drawing.Point(3, 90);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(100, 23);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "wbd";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(123, 90);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(768, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox  txt;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txt2;

        



    }
}

