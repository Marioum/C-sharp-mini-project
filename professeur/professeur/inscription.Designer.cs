namespace professeur
{
    partial class inscription
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_insc_login = new System.Windows.Forms.TextBox();
            this.txt_insc_password = new System.Windows.Forms.TextBox();
            this.txt_insc_family = new System.Windows.Forms.TextBox();
            this.txt_insc_name = new System.Windows.Forms.TextBox();
            this.txt_insc_grade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Family name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "grade";
            // 
            // txt_insc_login
            // 
            this.txt_insc_login.Location = new System.Drawing.Point(190, 47);
            this.txt_insc_login.Name = "txt_insc_login";
            this.txt_insc_login.Size = new System.Drawing.Size(100, 20);
            this.txt_insc_login.TabIndex = 5;
            // 
            // txt_insc_password
            // 
            this.txt_insc_password.Location = new System.Drawing.Point(190, 92);
            this.txt_insc_password.Name = "txt_insc_password";
            this.txt_insc_password.Size = new System.Drawing.Size(100, 20);
            this.txt_insc_password.TabIndex = 6;
            // 
            // txt_insc_family
            // 
            this.txt_insc_family.Location = new System.Drawing.Point(190, 142);
            this.txt_insc_family.Name = "txt_insc_family";
            this.txt_insc_family.Size = new System.Drawing.Size(100, 20);
            this.txt_insc_family.TabIndex = 7;
            // 
            // txt_insc_name
            // 
            this.txt_insc_name.Location = new System.Drawing.Point(190, 194);
            this.txt_insc_name.Name = "txt_insc_name";
            this.txt_insc_name.Size = new System.Drawing.Size(100, 20);
            this.txt_insc_name.TabIndex = 8;
            // 
            // txt_insc_grade
            // 
            this.txt_insc_grade.Location = new System.Drawing.Point(190, 243);
            this.txt_insc_grade.Name = "txt_insc_grade";
            this.txt_insc_grade.Size = new System.Drawing.Size(100, 20);
            this.txt_insc_grade.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Sign up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 362);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_insc_grade);
            this.Controls.Add(this.txt_insc_name);
            this.Controls.Add(this.txt_insc_family);
            this.Controls.Add(this.txt_insc_password);
            this.Controls.Add(this.txt_insc_login);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "inscription";
            this.Text = "inscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_insc_login;
        private System.Windows.Forms.TextBox txt_insc_password;
        private System.Windows.Forms.TextBox txt_insc_family;
        private System.Windows.Forms.TextBox txt_insc_name;
        private System.Windows.Forms.TextBox txt_insc_grade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}