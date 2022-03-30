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
            this.minInput = new System.Windows.Forms.NumericUpDown();
            this.maxInput = new System.Windows.Forms.NumericUpDown();
            this.lblRounding = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtDecimal = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.minInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDecimal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRandomInteger
            // 
            this.btnRandomInteger.BackColor = System.Drawing.Color.Aqua;
            this.btnRandomInteger.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRandomInteger.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRandomInteger.ForeColor = System.Drawing.Color.Red;
            this.btnRandomInteger.Location = new System.Drawing.Point(20, 134);
            this.btnRandomInteger.Name = "btnRandomInteger";
            this.btnRandomInteger.Size = new System.Drawing.Size(190, 44);
            this.btnRandomInteger.TabIndex = 0;
            this.btnRandomInteger.Text = "GET INTEGER";
            this.btnRandomInteger.UseVisualStyleBackColor = false;
            this.btnRandomInteger.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRandom.Location = new System.Drawing.Point(35, 229);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(69, 76);
            this.lblRandom.TabIndex = 1;
            this.lblRandom.Text = "0";
            // 
            // btnRandomDouble
            // 
            this.btnRandomDouble.BackColor = System.Drawing.Color.Red;
            this.btnRandomDouble.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRandomDouble.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRandomDouble.ForeColor = System.Drawing.Color.Aqua;
            this.btnRandomDouble.Location = new System.Drawing.Point(221, 134);
            this.btnRandomDouble.Name = "btnRandomDouble";
            this.btnRandomDouble.Size = new System.Drawing.Size(184, 45);
            this.btnRandomDouble.TabIndex = 2;
            this.btnRandomDouble.Text = "GET DOUBLE";
            this.btnRandomDouble.UseVisualStyleBackColor = false;
            this.btnRandomDouble.Click += new System.EventHandler(this.btnRandom1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl1.Location = new System.Drawing.Point(15, 23);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(471, 26);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "ENTER A MINIMUM AND MAXIMUM VALUE";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMin.Location = new System.Drawing.Point(16, 58);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(89, 20);
            this.lblMin.TabIndex = 4;
            this.lblMin.Text = "Minimum: ";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMax.Location = new System.Drawing.Point(16, 97);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(93, 20);
            this.lblMax.TabIndex = 5;
            this.lblMax.Text = "Maximum: ";
            // 
            // minInput
            // 
            this.minInput.Location = new System.Drawing.Point(111, 61);
            this.minInput.Name = "minInput";
            this.minInput.Size = new System.Drawing.Size(294, 20);
            this.minInput.TabIndex = 6;
            // 
            // maxInput
            // 
            this.maxInput.Location = new System.Drawing.Point(111, 97);
            this.maxInput.Name = "maxInput";
            this.maxInput.Size = new System.Drawing.Size(294, 20);
            this.maxInput.TabIndex = 7;
            // 
            // lblRounding
            // 
            this.lblRounding.AutoSize = true;
            this.lblRounding.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRounding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRounding.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRounding.Location = new System.Drawing.Point(411, 58);
            this.lblRounding.Name = "lblRounding";
            this.lblRounding.Size = new System.Drawing.Size(141, 20);
            this.lblRounding.TabIndex = 9;
            this.lblRounding.Text = "Round Decimal: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 426);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(20, 197);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(754, 146);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(558, 58);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(216, 20);
            this.txtDecimal.TabIndex = 12;
            // 
            // RandomNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.lblRandom);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblRounding);
            this.Controls.Add(this.maxInput);
            this.Controls.Add(this.minInput);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnRandomDouble);
            this.Controls.Add(this.btnRandomInteger);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RandomNumbers";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.minInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDecimal)).EndInit();
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
        private System.Windows.Forms.NumericUpDown minInput;
        private System.Windows.Forms.NumericUpDown maxInput;
        private System.Windows.Forms.Label lblRounding;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NumericUpDown txtDecimal;
    }
}

