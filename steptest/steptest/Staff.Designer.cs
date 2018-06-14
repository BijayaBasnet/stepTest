namespace steptest
{
    partial class Staff
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
            this.StaffFirstName = new System.Windows.Forms.TextBox();
            this.StaffLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CusRegisterBut = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StaffFirstName
            // 
            this.StaffFirstName.Location = new System.Drawing.Point(108, 12);
            this.StaffFirstName.Name = "StaffFirstName";
            this.StaffFirstName.Size = new System.Drawing.Size(144, 20);
            this.StaffFirstName.TabIndex = 0;
            // 
            // StaffLastName
            // 
            this.StaffLastName.Location = new System.Drawing.Point(108, 57);
            this.StaffLastName.Name = "StaffLastName";
            this.StaffLastName.Size = new System.Drawing.Size(144, 20);
            this.StaffLastName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // CusRegisterBut
            // 
            this.CusRegisterBut.Location = new System.Drawing.Point(56, 108);
            this.CusRegisterBut.Name = "CusRegisterBut";
            this.CusRegisterBut.Size = new System.Drawing.Size(75, 23);
            this.CusRegisterBut.TabIndex = 4;
            this.CusRegisterBut.Text = "Register";
            this.CusRegisterBut.UseVisualStyleBackColor = true;
            this.CusRegisterBut.Click += new System.EventHandler(this.CusRegisterBut_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(165, 108);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 5;
            this.Login.Text = "Log In";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // StaffRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(318, 145);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.CusRegisterBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StaffLastName);
            this.Controls.Add(this.StaffFirstName);
            this.Name = "StaffRegister";
            this.Text = "Staff Register";
            this.Load += new System.EventHandler(this.StaffRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StaffFirstName;
        private System.Windows.Forms.TextBox StaffLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CusRegisterBut;
        private System.Windows.Forms.Button Login;
    }
}