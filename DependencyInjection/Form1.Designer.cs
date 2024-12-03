namespace DependencyInjection
{
    partial class MainForm
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
            this.cmbEvents = new System.Windows.Forms.ComboBox();
            this.btnGetEventDetails = new System.Windows.Forms.Button();
            this.btnDIUsingProperties = new System.Windows.Forms.Button();
            this.btnDIUsingMethod = new System.Windows.Forms.Button();
            this.btnDIUsingServiceLocator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbEvents
            // 
            this.cmbEvents.FormattingEnabled = true;
            this.cmbEvents.Items.AddRange(new object[] {
            "Football Event",
            "Party Event",
            "Tech Event"});
            this.cmbEvents.Location = new System.Drawing.Point(74, 68);
            this.cmbEvents.Name = "cmbEvents";
            this.cmbEvents.Size = new System.Drawing.Size(121, 21);
            this.cmbEvents.TabIndex = 0;
            // 
            // btnGetEventDetails
            // 
            this.btnGetEventDetails.Location = new System.Drawing.Point(55, 111);
            this.btnGetEventDetails.Name = "btnGetEventDetails";
            this.btnGetEventDetails.Size = new System.Drawing.Size(165, 23);
            this.btnGetEventDetails.TabIndex = 1;
            this.btnGetEventDetails.Text = "Get Event Details(Constructor)";
            this.btnGetEventDetails.UseVisualStyleBackColor = true;
            this.btnGetEventDetails.Click += new System.EventHandler(this.btnGetEventDetails_Click);
            // 
            // btnDIUsingProperties
            // 
            this.btnDIUsingProperties.Location = new System.Drawing.Point(55, 158);
            this.btnDIUsingProperties.Name = "btnDIUsingProperties";
            this.btnDIUsingProperties.Size = new System.Drawing.Size(165, 23);
            this.btnDIUsingProperties.TabIndex = 2;
            this.btnDIUsingProperties.Text = "Get Event Details(Properties)";
            this.btnDIUsingProperties.UseVisualStyleBackColor = true;
            this.btnDIUsingProperties.Click += new System.EventHandler(this.btnDIUsingProperties_Click);
            // 
            // btnDIUsingMethod
            // 
            this.btnDIUsingMethod.Location = new System.Drawing.Point(55, 197);
            this.btnDIUsingMethod.Name = "btnDIUsingMethod";
            this.btnDIUsingMethod.Size = new System.Drawing.Size(165, 23);
            this.btnDIUsingMethod.TabIndex = 3;
            this.btnDIUsingMethod.Text = "Get Event Details(Methods)";
            this.btnDIUsingMethod.UseVisualStyleBackColor = true;
            this.btnDIUsingMethod.Click += new System.EventHandler(this.btnDIUsingMethod_Click);
            // 
            // btnDIUsingServiceLocator
            // 
            this.btnDIUsingServiceLocator.Location = new System.Drawing.Point(43, 233);
            this.btnDIUsingServiceLocator.Name = "btnDIUsingServiceLocator";
            this.btnDIUsingServiceLocator.Size = new System.Drawing.Size(205, 23);
            this.btnDIUsingServiceLocator.TabIndex = 4;
            this.btnDIUsingServiceLocator.Text = "Get Event Details(ServiceLocator)";
            this.btnDIUsingServiceLocator.UseVisualStyleBackColor = true;
            this.btnDIUsingServiceLocator.Click += new System.EventHandler(this.btnDIUsingServiceLocator_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnDIUsingServiceLocator);
            this.Controls.Add(this.btnDIUsingMethod);
            this.Controls.Add(this.btnDIUsingProperties);
            this.Controls.Add(this.btnGetEventDetails);
            this.Controls.Add(this.cmbEvents);
            this.Name = "MainForm";
            this.Text = "DependencyInjection";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEvents;
        private System.Windows.Forms.Button btnGetEventDetails;
        private System.Windows.Forms.Button btnDIUsingProperties;
        private System.Windows.Forms.Button btnDIUsingMethod;
        private System.Windows.Forms.Button btnDIUsingServiceLocator;
    }
}

