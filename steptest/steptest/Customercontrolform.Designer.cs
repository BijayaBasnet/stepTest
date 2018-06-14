namespace steptest
{
    partial class Customercontrolform
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Cussex = new System.Windows.Forms.ComboBox();
            this.CusAge = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cusid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cusname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Cuslast = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UpdateCus = new System.Windows.Forms.Button();
            this.DeleteCus = new System.Windows.Forms.Button();
            this.PerformTest = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.Cussex);
            this.groupBox4.Controls.Add(this.CusAge);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.Cusid);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.Cusname);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.Cuslast);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(3, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(229, 182);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Customer Info";
            // 
            // Cussex
            // 
            this.Cussex.FormattingEnabled = true;
            this.Cussex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.Cussex.Location = new System.Drawing.Point(109, 150);
            this.Cussex.Name = "Cussex";
            this.Cussex.Size = new System.Drawing.Size(48, 21);
            this.Cussex.TabIndex = 28;
            // 
            // CusAge
            // 
            this.CusAge.FormattingEnabled = true;
            this.CusAge.Items.AddRange(new object[] {
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75"});
            this.CusAge.Location = new System.Drawing.Point(109, 122);
            this.CusAge.Name = "CusAge";
            this.CusAge.Size = new System.Drawing.Size(48, 21);
            this.CusAge.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Customer ID";
            // 
            // Cusid
            // 
            this.Cusid.Location = new System.Drawing.Point(109, 27);
            this.Cusid.Name = "Cusid";
            this.Cusid.ReadOnly = true;
            this.Cusid.Size = new System.Drawing.Size(100, 20);
            this.Cusid.TabIndex = 0;
            this.Cusid.TextChanged += new System.EventHandler(this.Cusid_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "First Name";
            // 
            // Cusname
            // 
            this.Cusname.Location = new System.Drawing.Point(109, 63);
            this.Cusname.Name = "Cusname";
            this.Cusname.Size = new System.Drawing.Size(100, 20);
            this.Cusname.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Last Name";
            // 
            // Cuslast
            // 
            this.Cuslast.Location = new System.Drawing.Point(109, 93);
            this.Cuslast.Name = "Cuslast";
            this.Cuslast.Size = new System.Drawing.Size(100, 20);
            this.Cuslast.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Age";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sex";
            // 
            // UpdateCus
            // 
            this.UpdateCus.Location = new System.Drawing.Point(3, 233);
            this.UpdateCus.Name = "UpdateCus";
            this.UpdateCus.Size = new System.Drawing.Size(100, 23);
            this.UpdateCus.TabIndex = 26;
            this.UpdateCus.Text = "Update Details";
            this.UpdateCus.UseVisualStyleBackColor = true;
            this.UpdateCus.Click += new System.EventHandler(this.UpdateCus_Click);
            // 
            // DeleteCus
            // 
            this.DeleteCus.Location = new System.Drawing.Point(109, 233);
            this.DeleteCus.Name = "DeleteCus";
            this.DeleteCus.Size = new System.Drawing.Size(116, 23);
            this.DeleteCus.TabIndex = 27;
            this.DeleteCus.Text = "Delete Customer";
            this.DeleteCus.UseVisualStyleBackColor = true;
            this.DeleteCus.Click += new System.EventHandler(this.DeleteCus_Click);
            // 
            // PerformTest
            // 
            this.PerformTest.Location = new System.Drawing.Point(231, 233);
            this.PerformTest.Name = "PerformTest";
            this.PerformTest.Size = new System.Drawing.Size(75, 23);
            this.PerformTest.TabIndex = 28;
            this.PerformTest.Text = "Perform Test";
            this.PerformTest.UseVisualStyleBackColor = true;
            this.PerformTest.Click += new System.EventHandler(this.PerformTest_Click);
            // 
            // Customercontrolform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(326, 299);
            this.Controls.Add(this.PerformTest);
            this.Controls.Add(this.DeleteCus);
            this.Controls.Add(this.UpdateCus);
            this.Controls.Add(this.groupBox4);
            this.Name = "Customercontrolform";
            this.Text = "Customercontrolform";
            this.Load += new System.EventHandler(this.Customercontrolform_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Cusid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Cusname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Cuslast;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button UpdateCus;
        private System.Windows.Forms.Button DeleteCus;
        private System.Windows.Forms.Button PerformTest;
        private System.Windows.Forms.ComboBox Cussex;
        private System.Windows.Forms.ComboBox CusAge;
    }
}