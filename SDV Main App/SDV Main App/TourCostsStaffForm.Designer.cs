namespace SDV_Main_App
{
    partial class TourCostsStaffForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TourCostsStaffFormNameTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TourCostsStaffFormDailyRateTxtBox = new System.Windows.Forms.TextBox();
            this.TourCostsStaffFormStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.TourCostsStaffFormEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleName = "TourCostsStaffFormNameLbl";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TourCostsStaffFormNameTxtBox
            // 
            this.TourCostsStaffFormNameTxtBox.AccessibleName = "TourCostsStaffFormNameTxtBox";
            this.TourCostsStaffFormNameTxtBox.Location = new System.Drawing.Point(307, 177);
            this.TourCostsStaffFormNameTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TourCostsStaffFormNameTxtBox.Name = "TourCostsStaffFormNameTxtBox";
            this.TourCostsStaffFormNameTxtBox.Size = new System.Drawing.Size(219, 27);
            this.TourCostsStaffFormNameTxtBox.TabIndex = 1;
            this.TourCostsStaffFormNameTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AccessibleName = "TourCostsStaffFormDailyRateLbl";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Daily Rate:";
            // 
            // TourCostsStaffFormDailyRateTxtBox
            // 
            this.TourCostsStaffFormDailyRateTxtBox.AccessibleName = "TourCostsStaffFormDailyRateTxtBox";
            this.TourCostsStaffFormDailyRateTxtBox.Location = new System.Drawing.Point(307, 230);
            this.TourCostsStaffFormDailyRateTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TourCostsStaffFormDailyRateTxtBox.Name = "TourCostsStaffFormDailyRateTxtBox";
            this.TourCostsStaffFormDailyRateTxtBox.Size = new System.Drawing.Size(219, 27);
            this.TourCostsStaffFormDailyRateTxtBox.TabIndex = 6;
            this.TourCostsStaffFormDailyRateTxtBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TourCostsStaffFormStartDatePicker
            // 
            this.TourCostsStaffFormStartDatePicker.AccessibleName = "TourCostsStaffFormStartDatePicker";
            this.TourCostsStaffFormStartDatePicker.Location = new System.Drawing.Point(307, 292);
            this.TourCostsStaffFormStartDatePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TourCostsStaffFormStartDatePicker.Name = "TourCostsStaffFormStartDatePicker";
            this.TourCostsStaffFormStartDatePicker.Size = new System.Drawing.Size(219, 27);
            this.TourCostsStaffFormStartDatePicker.TabIndex = 8;
            this.TourCostsStaffFormStartDatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // TourCostsStaffFormEndDatePicker
            // 
            this.TourCostsStaffFormEndDatePicker.AccessibleName = "TourCostsStaffFormEndDatePicker";
            this.TourCostsStaffFormEndDatePicker.Location = new System.Drawing.Point(307, 352);
            this.TourCostsStaffFormEndDatePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TourCostsStaffFormEndDatePicker.Name = "TourCostsStaffFormEndDatePicker";
            this.TourCostsStaffFormEndDatePicker.Size = new System.Drawing.Size(219, 27);
            this.TourCostsStaffFormEndDatePicker.TabIndex = 9;
            this.TourCostsStaffFormEndDatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label4
            // 
            this.label4.AccessibleName = "TourCostsStaffFormStartDateLbl";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Start Date:";
            // 
            // label5
            // 
            this.label5.AccessibleName = "TourCostsStaffFormEndDateLbl";
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "End Date:";
            // 
            // label6
            // 
            this.label6.AccessibleName = "TourCostsStaffFormMainLbl";
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Create Staff Cost";
            // 
            // button1
            // 
            this.button1.AccessibleName = "TourCostsStaffFormAddBtn";
            this.button1.Location = new System.Drawing.Point(341, 451);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add Staff Cost";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TourCostsStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 577);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TourCostsStaffFormEndDatePicker);
            this.Controls.Add(this.TourCostsStaffFormStartDatePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TourCostsStaffFormDailyRateTxtBox);
            this.Controls.Add(this.TourCostsStaffFormNameTxtBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TourCostsStaffForm";
            this.Text = "TourCostsStaffForm";
            this.Load += new System.EventHandler(this.TourCostsStaffForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TourCostsStaffFormNameTxtBox;
        private Label label3;
        private TextBox TourCostsStaffFormDailyRateTxtBox;
        private DateTimePicker TourCostsStaffFormStartDatePicker;
        private DateTimePicker TourCostsStaffFormEndDatePicker;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
    }
}