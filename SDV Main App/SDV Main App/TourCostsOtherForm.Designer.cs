namespace SDV_Main_App
{
    partial class TourCostsOtherForm
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
            this.TourCostsOtherFormPriceTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TourCostsOtherFormDescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TourCostsFormLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TourCostsOtherFormPriceTxtBox
            // 
            this.TourCostsOtherFormPriceTxtBox.AccessibleName = "TourCostsOtherFormPriceTxtBox";
            this.TourCostsOtherFormPriceTxtBox.Location = new System.Drawing.Point(279, 289);
            this.TourCostsOtherFormPriceTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TourCostsOtherFormPriceTxtBox.Name = "TourCostsOtherFormPriceTxtBox";
            this.TourCostsOtherFormPriceTxtBox.Size = new System.Drawing.Size(227, 27);
            this.TourCostsOtherFormPriceTxtBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AccessibleName = "TourCostsOtherFormPriceLbl";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Price:";
            // 
            // TourCostsOtherFormDescriptionTxtBox
            // 
            this.TourCostsOtherFormDescriptionTxtBox.AccessibleName = "TourCostsOtherFormDescriptionTxtBox";
            this.TourCostsOtherFormDescriptionTxtBox.Location = new System.Drawing.Point(279, 213);
            this.TourCostsOtherFormDescriptionTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TourCostsOtherFormDescriptionTxtBox.Name = "TourCostsOtherFormDescriptionTxtBox";
            this.TourCostsOtherFormDescriptionTxtBox.Size = new System.Drawing.Size(227, 27);
            this.TourCostsOtherFormDescriptionTxtBox.TabIndex = 7;
            this.TourCostsOtherFormDescriptionTxtBox.TextChanged += new System.EventHandler(this.TourCostsVehicleFormDetailsTxtBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AccessibleName = "TourCostsOtherFormDescriptionLbl";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Description:";
            // 
            // TourCostsFormLbl
            // 
            this.TourCostsFormLbl.AccessibleName = "TourCostsOtherFormMainLbl";
            this.TourCostsFormLbl.AutoSize = true;
            this.TourCostsFormLbl.Location = new System.Drawing.Point(335, 85);
            this.TourCostsFormLbl.Name = "TourCostsFormLbl";
            this.TourCostsFormLbl.Size = new System.Drawing.Size(126, 20);
            this.TourCostsFormLbl.TabIndex = 5;
            this.TourCostsFormLbl.Text = "Create Other Cost";
            this.TourCostsFormLbl.Click += new System.EventHandler(this.TourCostsFormLbl_Click);
            // 
            // button1
            // 
            this.button1.AccessibleName = "TourCostsOtherFormAddBtn";
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(323, 437);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add Other Cost";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TourCostsOtherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 667);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TourCostsOtherFormPriceTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TourCostsOtherFormDescriptionTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TourCostsFormLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TourCostsOtherForm";
            this.Text = "TourCostsOtherForm";
            this.Load += new System.EventHandler(this.TourCostsOtherForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TourCostsOtherFormPriceTxtBox;
        private Label label2;
        private TextBox TourCostsOtherFormDescriptionTxtBox;
        private Label label1;
        private Label TourCostsFormLbl;
        private Button button1;
    }
}