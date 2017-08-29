namespace constructAFarm
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
            this.numericUpDownCow = new System.Windows.Forms.NumericUpDown();
            this.labelCow = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCow)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownCow
            // 
            this.numericUpDownCow.Location = new System.Drawing.Point(126, 52);
            this.numericUpDownCow.Name = "numericUpDownCow";
            this.numericUpDownCow.Size = new System.Drawing.Size(196, 20);
            this.numericUpDownCow.TabIndex = 0;
            this.numericUpDownCow.ValueChanged += new System.EventHandler(this.numericUpDownCow_ValueChanged);
            // 
            // labelCow
            // 
            this.labelCow.AutoSize = true;
            this.labelCow.Location = new System.Drawing.Point(33, 54);
            this.labelCow.Name = "labelCow";
            this.labelCow.Size = new System.Drawing.Size(87, 13);
            this.labelCow.TabIndex = 1;
            this.labelCow.Text = "Number of cows:";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(126, 91);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(196, 23);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 160);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelCow);
            this.Controls.Add(this.numericUpDownCow);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Cow Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownCow;
        private System.Windows.Forms.Label labelCow;
        private System.Windows.Forms.Button buttonCalculate;
    }
}

