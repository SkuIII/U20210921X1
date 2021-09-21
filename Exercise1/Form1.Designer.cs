
namespace Exercise1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnRedAmount = new System.Windows.Forms.Button();
            this.btnOldCars = new System.Windows.Forms.Button();
            this.btnGreyVolvo = new System.Windows.Forms.Button();
            this.btnAverageBMW = new System.Windows.Forms.Button();
            this.btnExpensive = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(637, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(133, 290);
            this.listBox1.TabIndex = 0;
            // 
            // btnRedAmount
            // 
            this.btnRedAmount.Location = new System.Drawing.Point(249, 29);
            this.btnRedAmount.Name = "btnRedAmount";
            this.btnRedAmount.Size = new System.Drawing.Size(123, 54);
            this.btnRedAmount.TabIndex = 1;
            this.btnRedAmount.Text = "Amount of Red Cars";
            this.btnRedAmount.UseVisualStyleBackColor = true;
            // 
            // btnOldCars
            // 
            this.btnOldCars.Location = new System.Drawing.Point(249, 89);
            this.btnOldCars.Name = "btnOldCars";
            this.btnOldCars.Size = new System.Drawing.Size(123, 55);
            this.btnOldCars.TabIndex = 2;
            this.btnOldCars.Text = "Cars older than 2003";
            this.btnOldCars.UseVisualStyleBackColor = true;
            // 
            // btnGreyVolvo
            // 
            this.btnGreyVolvo.Location = new System.Drawing.Point(249, 150);
            this.btnGreyVolvo.Name = "btnGreyVolvo";
            this.btnGreyVolvo.Size = new System.Drawing.Size(123, 52);
            this.btnGreyVolvo.TabIndex = 3;
            this.btnGreyVolvo.Text = "Amount of Grey Volvos";
            this.btnGreyVolvo.UseVisualStyleBackColor = true;
            // 
            // btnAverageBMW
            // 
            this.btnAverageBMW.Location = new System.Drawing.Point(249, 208);
            this.btnAverageBMW.Name = "btnAverageBMW";
            this.btnAverageBMW.Size = new System.Drawing.Size(123, 52);
            this.btnAverageBMW.TabIndex = 4;
            this.btnAverageBMW.Text = "Average KM for BMW";
            this.btnAverageBMW.UseVisualStyleBackColor = true;
            // 
            // btnExpensive
            // 
            this.btnExpensive.Location = new System.Drawing.Point(249, 266);
            this.btnExpensive.Name = "btnExpensive";
            this.btnExpensive.Size = new System.Drawing.Size(123, 55);
            this.btnExpensive.TabIndex = 5;
            this.btnExpensive.Text = "Most Expensive Car?";
            this.btnExpensive.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 31);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(231, 290);
            this.listBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(631, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cars";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnExpensive);
            this.Controls.Add(this.btnAverageBMW);
            this.Controls.Add(this.btnGreyVolvo);
            this.Controls.Add(this.btnOldCars);
            this.Controls.Add(this.btnRedAmount);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnRedAmount;
        private System.Windows.Forms.Button btnOldCars;
        private System.Windows.Forms.Button btnGreyVolvo;
        private System.Windows.Forms.Button btnAverageBMW;
        private System.Windows.Forms.Button btnExpensive;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
    }
}

