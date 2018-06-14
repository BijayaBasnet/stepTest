namespace steptest
{
    partial class Stafflogin
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
            this.components = new System.ComponentModel.Container();
            this.Submit = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.Staffid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            //this.stafflist1 = new steptest.stafflist();
            //this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            //this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.staffTableAdapter = new steptest.stafflistTableAdapters.StaffTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            //((System.ComponentModel.ISupportInitialize)(this.stafflist1)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(142, 80);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(141, 154);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(75, 23);
            this.Register.TabIndex = 1;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click_1);
            // 
            // Staffid
            // 
            this.Staffid.Location = new System.Drawing.Point(141, 54);
            this.Staffid.Name = "Staffid";
            this.Staffid.Size = new System.Drawing.Size(100, 20);
            this.Staffid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome to Bijaya\'s Step Test";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Your Staff ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Not a Registered Staff? Click below to Register.";
            // 
            // stafflist1
            // 
            //this.stafflist1.DataSetName = "stafflist";
            //this.stafflist1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            //// 
            //// staffBindingSource
            //// 
            //this.staffBindingSource.DataMember = "Staff";
            //this.staffBindingSource.DataSource = this.stafflist1;
            //// 
            //// staffTableAdapter
            //// 
            //this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 253);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Visible = false;
            // 
            // FirstUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(422, 217);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Staffid);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Submit);
            this.Name = "FirstUI";
            this.Text = "Staff Log In";
            //this.Load += new System.EventHandler(this.FirstUI_Load);
            //((System.ComponentModel.ISupportInitialize)(this.stafflist1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.TextBox Staffid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        // private staffdataset staffdataset;
        // private staffdatasetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.Label label3;
       // private DataSet1 dataSet1;
        //private stafflist stafflist1;
        //private System.Windows.Forms.BindingSource bindingSource1;
        //private System.Windows.Forms.BindingSource staffBindingSource;
        //private stafflistTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
    }
}

