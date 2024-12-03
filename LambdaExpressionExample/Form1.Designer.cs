namespace LambdaExpressionExample
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
            this.Anontmousmethod = new System.Windows.Forms.Button();
            this.usinglambda = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Anontmousmethod
            // 
            this.Anontmousmethod.Location = new System.Drawing.Point(2, 12);
            this.Anontmousmethod.Name = "Anontmousmethod";
            this.Anontmousmethod.Size = new System.Drawing.Size(138, 23);
            this.Anontmousmethod.TabIndex = 2;
            this.Anontmousmethod.Text = "Anonymous Method";
            this.Anontmousmethod.UseVisualStyleBackColor = true;
            this.Anontmousmethod.Click += new System.EventHandler(this.Anontmousmethod_Click);
            // 
            // usinglambda
            // 
            this.usinglambda.Location = new System.Drawing.Point(2, 62);
            this.usinglambda.Name = "usinglambda";
            this.usinglambda.Size = new System.Drawing.Size(138, 23);
            this.usinglambda.TabIndex = 3;
            this.usinglambda.Text = "Using Lambda";
            this.usinglambda.UseVisualStyleBackColor = true;
            this.usinglambda.Click += new System.EventHandler(this.usinglambda_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Using Lambda Multiple Param";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Using Func";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(2, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Using LINQ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usinglambda);
            this.Controls.Add(this.Anontmousmethod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Anontmousmethod;
        private System.Windows.Forms.Button usinglambda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

