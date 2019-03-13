namespace SchoolRecords
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
            this.label1 = new System.Windows.Forms.Label();
            this.studentNameSet = new System.Windows.Forms.TextBox();
            this.ageSet = new System.Windows.Forms.TextBox();
            this.dosSet = new System.Windows.Forms.TextBox();
            this.subjectSet = new System.Windows.Forms.TextBox();
            this.StudentPush = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "School Record System";
            // 
            // studentNameSet
            // 
            this.studentNameSet.Location = new System.Drawing.Point(3, 43);
            this.studentNameSet.Name = "studentNameSet";
            this.studentNameSet.Size = new System.Drawing.Size(125, 20);
            this.studentNameSet.TabIndex = 1;
            this.studentNameSet.Text = "*Enter Student Name*";
            this.studentNameSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ageSet
            // 
            this.ageSet.Location = new System.Drawing.Point(3, 69);
            this.ageSet.Name = "ageSet";
            this.ageSet.Size = new System.Drawing.Size(125, 20);
            this.ageSet.TabIndex = 2;
            this.ageSet.Text = "*Enter Age*";
            this.ageSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dosSet
            // 
            this.dosSet.Location = new System.Drawing.Point(3, 95);
            this.dosSet.Name = "dosSet";
            this.dosSet.Size = new System.Drawing.Size(125, 20);
            this.dosSet.TabIndex = 3;
            this.dosSet.Text = "*Enter DOS*";
            this.dosSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // subjectSet
            // 
            this.subjectSet.Location = new System.Drawing.Point(3, 121);
            this.subjectSet.Multiline = true;
            this.subjectSet.Name = "subjectSet";
            this.subjectSet.Size = new System.Drawing.Size(125, 49);
            this.subjectSet.TabIndex = 4;
            this.subjectSet.Text = "*Enter Subjects*\r\n*Enter Subjects*\r\n*Enter Subjects*";
            this.subjectSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StudentPush
            // 
            this.StudentPush.Location = new System.Drawing.Point(30, 187);
            this.StudentPush.Name = "StudentPush";
            this.StudentPush.Size = new System.Drawing.Size(75, 23);
            this.StudentPush.TabIndex = 5;
            this.StudentPush.Text = "Push";
            this.StudentPush.UseVisualStyleBackColor = true;
            this.StudentPush.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "*Enter Age*";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "*Enter DOS Name*";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Push";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Complete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 252);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.StudentPush);
            this.Controls.Add(this.subjectSet);
            this.Controls.Add(this.dosSet);
            this.Controls.Add(this.ageSet);
            this.Controls.Add(this.studentNameSet);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentNameSet;
        private System.Windows.Forms.TextBox ageSet;
        private System.Windows.Forms.TextBox dosSet;
        private System.Windows.Forms.TextBox subjectSet;
        private System.Windows.Forms.Button StudentPush;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

