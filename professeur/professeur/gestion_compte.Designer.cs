namespace professeur
{
    partial class gestion_compte
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_g_password = new System.Windows.Forms.TextBox();
            this.txt_g_family = new System.Windows.Forms.TextBox();
            this.txt_g_name = new System.Windows.Forms.TextBox();
            this.txt_g_grade = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Family name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "grade";
            // 
            // txt_g_password
            // 
            this.txt_g_password.Location = new System.Drawing.Point(217, 48);
            this.txt_g_password.Name = "txt_g_password";
            this.txt_g_password.Size = new System.Drawing.Size(100, 20);
            this.txt_g_password.TabIndex = 6;
            // 
            // txt_g_family
            // 
            this.txt_g_family.Location = new System.Drawing.Point(217, 99);
            this.txt_g_family.Name = "txt_g_family";
            this.txt_g_family.Size = new System.Drawing.Size(100, 20);
            this.txt_g_family.TabIndex = 7;
            // 
            // txt_g_name
            // 
            this.txt_g_name.Location = new System.Drawing.Point(217, 152);
            this.txt_g_name.Name = "txt_g_name";
            this.txt_g_name.Size = new System.Drawing.Size(100, 20);
            this.txt_g_name.TabIndex = 8;
            // 
            // txt_g_grade
            // 
            this.txt_g_grade.Location = new System.Drawing.Point(217, 214);
            this.txt_g_grade.Name = "txt_g_grade";
            this.txt_g_grade.Size = new System.Drawing.Size(100, 20);
            this.txt_g_grade.TabIndex = 9;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(121, 279);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 10;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gestion_compte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 365);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.txt_g_grade);
            this.Controls.Add(this.txt_g_name);
            this.Controls.Add(this.txt_g_family);
            this.Controls.Add(this.txt_g_password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "gestion_compte";
            this.Text = "gestion_compte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_g_password;
        private System.Windows.Forms.TextBox txt_g_family;
        private System.Windows.Forms.TextBox txt_g_name;
        private System.Windows.Forms.TextBox txt_g_grade;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}