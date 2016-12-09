namespace Towers_of_Hanoi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Solveb = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Previous = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.NumberOfDisks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreteTower = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeText = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 346);
            this.panel1.TabIndex = 0;
            // 
            // Solveb
            // 
            this.Solveb.Location = new System.Drawing.Point(40, 52);
            this.Solveb.Name = "Solveb";
            this.Solveb.Size = new System.Drawing.Size(75, 23);
            this.Solveb.TabIndex = 1;
            this.Solveb.Text = "Solve";
            this.Solveb.UseVisualStyleBackColor = true;
            this.Solveb.Click += new System.EventHandler(this.Solveb_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Previous);
            this.groupBox1.Controls.Add(this.Next);
            this.groupBox1.Location = new System.Drawing.Point(721, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Steps";
            // 
            // Previous
            // 
            this.Previous.Location = new System.Drawing.Point(6, 30);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(75, 23);
            this.Previous.TabIndex = 1;
            this.Previous.Text = "Previous";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(87, 30);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 0;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // NumberOfDisks
            // 
            this.NumberOfDisks.Location = new System.Drawing.Point(94, 24);
            this.NumberOfDisks.Name = "NumberOfDisks";
            this.NumberOfDisks.Size = new System.Drawing.Size(72, 20);
            this.NumberOfDisks.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number Of Disks";
            // 
            // CreteTower
            // 
            this.CreteTower.Location = new System.Drawing.Point(63, 59);
            this.CreteTower.Name = "CreteTower";
            this.CreteTower.Size = new System.Drawing.Size(75, 23);
            this.CreteTower.TabIndex = 5;
            this.CreteTower.Text = "Create";
            this.CreteTower.UseVisualStyleBackColor = true;
            this.CreteTower.Click += new System.EventHandler(this.CreteTower_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CreteTower);
            this.groupBox2.Controls.Add(this.NumberOfDisks);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(721, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 91);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.TimeText);
            this.groupBox3.Controls.Add(this.Solveb);
            this.groupBox3.Location = new System.Drawing.Point(721, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 87);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Solve With Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time";
            // 
            // TimeText
            // 
            this.TimeText.Location = new System.Drawing.Point(43, 26);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(72, 20);
            this.TimeText.TabIndex = 2;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(808, 335);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 368);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Tower";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Solveb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.TextBox NumberOfDisks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreteTower;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TimeText;
        private System.Windows.Forms.Button Exit;
    }
}

