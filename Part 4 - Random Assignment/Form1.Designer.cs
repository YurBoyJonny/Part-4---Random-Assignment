namespace Part_4___Random_Assignment
{
    partial class RandomNumbers
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
            this.btnRandomInteger = new System.Windows.Forms.Button();
            this.lblRandom = new System.Windows.Forms.Label();
            this.btnRandomDouble = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRandomInteger
            // 
            this.btnRandomInteger.Location = new System.Drawing.Point(12, 125);
            this.btnRandomInteger.Name = "btnRandomInteger";
            this.btnRandomInteger.Size = new System.Drawing.Size(383, 32);
            this.btnRandomInteger.TabIndex = 0;
            this.btnRandomInteger.Text = "Get integer";
            this.btnRandomInteger.UseVisualStyleBackColor = true;
            this.btnRandomInteger.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 69F);
            this.lblRandom.Location = new System.Drawing.Point(12, 160);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(96, 104);
            this.lblRandom.TabIndex = 1;
            this.lblRandom.Text = "0";
            // 
            // btnRandomDouble
            // 
            this.btnRandomDouble.Location = new System.Drawing.Point(401, 125);
            this.btnRandomDouble.Name = "btnRandomDouble";
            this.btnRandomDouble.Size = new System.Drawing.Size(387, 32);
            this.btnRandomDouble.TabIndex = 2;
            this.btnRandomDouble.Text = "Get double";
            this.btnRandomDouble.UseVisualStyleBackColor = true;
            this.btnRandomDouble.Click += new System.EventHandler(this.btnRandom1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbl1.Location = new System.Drawing.Point(12, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(586, 39);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Enter a minimum and maximum value";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMin.Location = new System.Drawing.Point(23, 58);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(72, 20);
            this.lblMin.TabIndex = 4;
            this.lblMin.Text = "Minimum";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMax.Location = new System.Drawing.Point(23, 97);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(76, 20);
            this.lblMax.TabIndex = 5;
            this.lblMax.Text = "Maximum";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(101, 60);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(687, 20);
            this.txtMin.TabIndex = 6;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(101, 99);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(687, 20);
            this.txtMax.TabIndex = 7;
            // 
            // RandomNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnRandomDouble);
            this.Controls.Add(this.lblRandom);
            this.Controls.Add(this.btnRandomInteger);
            this.Name = "RandomNumbers";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRandomInteger;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.Button btnRandomDouble;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
    }
}

