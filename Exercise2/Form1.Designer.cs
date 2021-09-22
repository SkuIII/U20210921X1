
namespace Exercise2
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
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.labelList = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelColors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxCars
            // 
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.Location = new System.Drawing.Point(12, 51);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.Size = new System.Drawing.Size(120, 290);
            this.listBoxCars.TabIndex = 0;
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelList.Location = new System.Drawing.Point(6, 17);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(108, 31);
            this.labelList.TabIndex = 2;
            this.labelList.Text = "Car List";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelInfo.Location = new System.Drawing.Point(149, 17);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(111, 31);
            this.labelInfo.TabIndex = 3;
            this.labelInfo.Text = "Car Info";
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.Location = new System.Drawing.Point(155, 51);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(120, 121);
            this.listBoxInfo.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(435, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // labelColors
            // 
            this.labelColors.AutoSize = true;
            this.labelColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelColors.Location = new System.Drawing.Point(429, 17);
            this.labelColors.Name = "labelColors";
            this.labelColors.Size = new System.Drawing.Size(93, 31);
            this.labelColors.TabIndex = 6;
            this.labelColors.Text = "Colors";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 679);
            this.Controls.Add(this.labelColors);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBoxInfo);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.listBoxCars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCars;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ListBox listBoxInfo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelColors;
    }
}

