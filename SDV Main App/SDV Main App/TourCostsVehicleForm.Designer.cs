namespace SDV_Main_App
{
    partial class TourCostsVehicleForm
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
            this.TourCostsFormLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TourCostsVehicleFormDetailsTxtBox = new System.Windows.Forms.TextBox();
            this.TourCostsVehicleFormKmChargeTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TourCostsVehicleFormDistanceTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TourCostsFormLbl
            // 
            this.TourCostsFormLbl.AccessibleName = "TourCostsVehicleFormMainLbl";
            this.TourCostsFormLbl.AutoSize = true;
            this.TourCostsFormLbl.Location = new System.Drawing.Point(290, 43);
            this.TourCostsFormLbl.Name = "TourCostsFormLbl";
            this.TourCostsFormLbl.Size = new System.Drawing.Size(108, 15);
            this.TourCostsFormLbl.TabIndex = 0;
            this.TourCostsFormLbl.Text = "Create Vehicle Cost";
            // 
            // label1
            // 
            this.label1.AccessibleName = "TourCostsVehicleFormDetailsLbl";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Details:";
            // 
            // TourCostsVehicleFormDetailsTxtBox
            // 
            this.TourCostsVehicleFormDetailsTxtBox.AccessibleName = "TourCostsVehicleFormDetailsTxtBox";
            this.TourCostsVehicleFormDetailsTxtBox.Location = new System.Drawing.Point(256, 133);
            this.TourCostsVehicleFormDetailsTxtBox.Name = "TourCostsVehicleFormDetailsTxtBox";
            this.TourCostsVehicleFormDetailsTxtBox.Size = new System.Drawing.Size(199, 23);
            this.TourCostsVehicleFormDetailsTxtBox.TabIndex = 2;
            this.TourCostsVehicleFormDetailsTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TourCostsVehicleFormKmChargeTxtBox
            // 
            this.TourCostsVehicleFormKmChargeTxtBox.AccessibleName = "TourCostsVehicleFormKmChargeTxtBox";
            this.TourCostsVehicleFormKmChargeTxtBox.Location = new System.Drawing.Point(256, 190);
            this.TourCostsVehicleFormKmChargeTxtBox.Name = "TourCostsVehicleFormKmChargeTxtBox";
            this.TourCostsVehicleFormKmChargeTxtBox.Size = new System.Drawing.Size(199, 23);
            this.TourCostsVehicleFormKmChargeTxtBox.TabIndex = 4;
            this.TourCostsVehicleFormKmChargeTxtBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AccessibleName = "TourCostsVehicleFormKmChargeLbl";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "KM-Charge:";
            // 
            // TourCostsVehicleFormDistanceTxtBox
            // 
            this.TourCostsVehicleFormDistanceTxtBox.AccessibleName = "TourCostsVehicleFormDistanceTxtBox";
            this.TourCostsVehicleFormDistanceTxtBox.Location = new System.Drawing.Point(256, 248);
            this.TourCostsVehicleFormDistanceTxtBox.Name = "TourCostsVehicleFormDistanceTxtBox";
            this.TourCostsVehicleFormDistanceTxtBox.Size = new System.Drawing.Size(199, 23);
            this.TourCostsVehicleFormDistanceTxtBox.TabIndex = 6;
            this.TourCostsVehicleFormDistanceTxtBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AccessibleName = "TourCostsVehicleFormDistanceLbl";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Distance Travelled:";
            // 
            // button1
            // 
            this.button1.AccessibleName = "TourCostsVehicleFormAddBtn";
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(290, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Vehicle Cost";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TourCostsVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TourCostsVehicleFormDistanceTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TourCostsVehicleFormKmChargeTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TourCostsVehicleFormDetailsTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TourCostsFormLbl);
            this.Name = "TourCostsVehicleForm";
            this.Text = "TourCostsForm";
            this.Load += new System.EventHandler(this.TourCostsVehicleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TourCostsFormLbl;
        private Label label1;
        private TextBox TourCostsVehicleFormDetailsTxtBox;
        private TextBox TourCostsVehicleFormKmChargeTxtBox;
        private Label label2;
        private TextBox TourCostsVehicleFormDistanceTxtBox;
        private Label label3;
        private Button button1;
    }
}