
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
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.labelColors = new System.Windows.Forms.Label();
            this.listBoxModels = new System.Windows.Forms.ListBox();
            this.labelEditInfo = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxKm = new System.Windows.Forms.TextBox();
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
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(435, 51);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(136, 21);
            this.comboBoxColor.TabIndex = 5;
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
            // listBoxModels
            // 
            this.listBoxModels.FormattingEnabled = true;
            this.listBoxModels.Location = new System.Drawing.Point(435, 115);
            this.listBoxModels.Name = "listBoxModels";
            this.listBoxModels.Size = new System.Drawing.Size(136, 95);
            this.listBoxModels.TabIndex = 7;
            // 
            // labelEditInfo
            // 
            this.labelEditInfo.AutoSize = true;
            this.labelEditInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelEditInfo.Location = new System.Drawing.Point(12, 364);
            this.labelEditInfo.Name = "labelEditInfo";
            this.labelEditInfo.Size = new System.Drawing.Size(165, 31);
            this.labelEditInfo.TabIndex = 8;
            this.labelEditInfo.Text = "Edit Car Info";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelID.Location = new System.Drawing.Point(14, 410);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 20);
            this.labelID.TabIndex = 9;
            this.labelID.Text = "ID";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPrice.Location = new System.Drawing.Point(14, 468);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(44, 20);
            this.labelPrice.TabIndex = 10;
            this.labelPrice.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(25, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "KM";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(111, 408);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(52, 23);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit Car";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(111, 541);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(52, 25);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(41, 410);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(39, 20);
            this.textBoxId.TabIndex = 14;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(63, 468);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 15;
            // 
            // textBoxKm
            // 
            this.textBoxKm.Location = new System.Drawing.Point(63, 505);
            this.textBoxKm.Name = "textBoxKm";
            this.textBoxKm.Size = new System.Drawing.Size(100, 20);
            this.textBoxKm.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 603);
            this.Controls.Add(this.textBoxKm);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelEditInfo);
            this.Controls.Add(this.listBoxModels);
            this.Controls.Add(this.labelColors);
            this.Controls.Add(this.comboBoxColor);
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
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label labelColors;
        private System.Windows.Forms.ListBox listBoxModels;
        private System.Windows.Forms.Label labelEditInfo;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxKm;
    }
}

