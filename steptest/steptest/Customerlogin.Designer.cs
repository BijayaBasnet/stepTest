namespace steptest
{
    partial class Customerlogin
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
            this.Custid = new System.Windows.Forms.TextBox();
            this.CusSubmit = new System.Windows.Forms.Button();
            this.CusRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.staffnaming = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Custid
            // 
            this.Custid.Location = new System.Drawing.Point(155, 53);
            this.Custid.Name = "Custid";
            this.Custid.Size = new System.Drawing.Size(100, 20);
            this.Custid.TabIndex = 0;
            // 
            // CusSubmit
            // 
            this.CusSubmit.Location = new System.Drawing.Point(167, 93);
            this.CusSubmit.Name = "CusSubmit";
            this.CusSubmit.Size = new System.Drawing.Size(75, 23);
            this.CusSubmit.TabIndex = 1;
            this.CusSubmit.Text = "Submit";
            this.CusSubmit.UseVisualStyleBackColor = true;
            this.CusSubmit.Click += new System.EventHandler(this.CusSubmit_Click_1);
            // 
            // CusRegister
            // 
            this.CusRegister.Location = new System.Drawing.Point(143, 170);
            this.CusRegister.Name = "CusRegister";
            this.CusRegister.Size = new System.Drawing.Size(75, 23);
            this.CusRegister.TabIndex = 2;
            this.CusRegister.Text = "Register";
            this.CusRegister.UseVisualStyleBackColor = true;
            this.CusRegister.Click += new System.EventHandler(this.CusRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Your Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Not Registered? PLease below to Register";
            // 
            // staffnaming
            // 
            this.staffnaming.AutoSize = true;
            this.staffnaming.Location = new System.Drawing.Point(140, 13);
            this.staffnaming.Name = "staffnaming";
            this.staffnaming.Size = new System.Drawing.Size(60, 13);
            this.staffnaming.TabIndex = 7;
            this.staffnaming.Text = "Staff Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Tag = "Staff name:";
            this.label3.Text = "Staff Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 244);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Visible = false;
            // 
            // SecondUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(393, 225);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.staffnaming);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CusRegister);
            this.Controls.Add(this.CusSubmit);
            this.Controls.Add(this.Custid);
            this.Name = "SecondUI";
            this.Text = "Customer data";
            this.Load += new System.EventHandler(this.SecondUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.BindingSource customerdatasetBindingSource;
        ////private Customerdataset customerdataset;
        //private System.Windows.Forms.BindingSource customerBindingSource;
        ////private CustomerdatasetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.TextBox Custid;
        private System.Windows.Forms.Button CusSubmit;
        private System.Windows.Forms.Button CusRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label staffnaming;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}