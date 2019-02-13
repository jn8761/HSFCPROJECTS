namespace FirstGame
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
            this.spinButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudgeButtonOne = new System.Windows.Forms.Button();
            this.nudgeButtonTwo = new System.Windows.Forms.Button();
            this.nudgeButtonThree = new System.Windows.Forms.Button();
            this.pictureBoxThree = new System.Windows.Forms.PictureBox();
            this.pictureBoxTwo = new System.Windows.Forms.PictureBox();
            this.pictureBoxOne = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOne)).BeginInit();
            this.SuspendLayout();
            // 
            // spinButton
            // 
            this.spinButton.Font = new System.Drawing.Font("Pristina", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinButton.Location = new System.Drawing.Point(55, 337);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(696, 101);
            this.spinButton.TabIndex = 3;
            this.spinButton.Text = "SPIN!";
            this.spinButton.UseVisualStyleBackColor = true;
            this.spinButton.Click += new System.EventHandler(this.spinButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(282, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "ONE ARM BANDIT";
            // 
            // nudgeButtonOne
            // 
            this.nudgeButtonOne.Location = new System.Drawing.Point(35, 227);
            this.nudgeButtonOne.Name = "nudgeButtonOne";
            this.nudgeButtonOne.Size = new System.Drawing.Size(156, 29);
            this.nudgeButtonOne.TabIndex = 5;
            this.nudgeButtonOne.Text = "NUDGE";
            this.nudgeButtonOne.UseVisualStyleBackColor = true;
            this.nudgeButtonOne.Click += new System.EventHandler(this.nudgeButtonOne_Click);
            // 
            // nudgeButtonTwo
            // 
            this.nudgeButtonTwo.Location = new System.Drawing.Point(324, 228);
            this.nudgeButtonTwo.Name = "nudgeButtonTwo";
            this.nudgeButtonTwo.Size = new System.Drawing.Size(156, 29);
            this.nudgeButtonTwo.TabIndex = 6;
            this.nudgeButtonTwo.Text = "NUDGE";
            this.nudgeButtonTwo.UseVisualStyleBackColor = true;
            this.nudgeButtonTwo.Click += new System.EventHandler(this.nudgeButtonTwo_Click);
            // 
            // nudgeButtonThree
            // 
            this.nudgeButtonThree.Location = new System.Drawing.Point(607, 227);
            this.nudgeButtonThree.Name = "nudgeButtonThree";
            this.nudgeButtonThree.Size = new System.Drawing.Size(156, 29);
            this.nudgeButtonThree.TabIndex = 7;
            this.nudgeButtonThree.Text = "NUDGE";
            this.nudgeButtonThree.UseVisualStyleBackColor = true;
            this.nudgeButtonThree.Click += new System.EventHandler(this.nudgeButtonThree_Click);
            // 
            // pictureBoxThree
            // 
            this.pictureBoxThree.BackColor = System.Drawing.Color.Silver;
            this.pictureBoxThree.Location = new System.Drawing.Point(623, 94);
            this.pictureBoxThree.Name = "pictureBoxThree";
            this.pictureBoxThree.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxThree.TabIndex = 2;
            this.pictureBoxThree.TabStop = false;
            // 
            // pictureBoxTwo
            // 
            this.pictureBoxTwo.BackColor = System.Drawing.Color.Silver;
            this.pictureBoxTwo.Location = new System.Drawing.Point(339, 94);
            this.pictureBoxTwo.Name = "pictureBoxTwo";
            this.pictureBoxTwo.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxTwo.TabIndex = 1;
            this.pictureBoxTwo.TabStop = false;
            // 
            // pictureBoxOne
            // 
            this.pictureBoxOne.BackColor = System.Drawing.Color.Silver;
            this.pictureBoxOne.Location = new System.Drawing.Point(49, 94);
            this.pictureBoxOne.Name = "pictureBoxOne";
            this.pictureBoxOne.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxOne.TabIndex = 0;
            this.pictureBoxOne.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 41);
            this.label2.TabIndex = 8;
            this.label2.Text = "WINNER!!!";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::FirstGame.Properties.Resources.Nun;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudgeButtonThree);
            this.Controls.Add(this.nudgeButtonTwo);
            this.Controls.Add(this.nudgeButtonOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.pictureBoxThree);
            this.Controls.Add(this.pictureBoxTwo);
            this.Controls.Add(this.pictureBoxOne);
            this.Location = new System.Drawing.Point(-50, 0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOne;
        private System.Windows.Forms.PictureBox pictureBoxTwo;
        private System.Windows.Forms.PictureBox pictureBoxThree;
        private System.Windows.Forms.Button spinButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nudgeButtonOne;
        private System.Windows.Forms.Button nudgeButtonTwo;
        private System.Windows.Forms.Button nudgeButtonThree;
        private System.Windows.Forms.Label label2;
    }
}

