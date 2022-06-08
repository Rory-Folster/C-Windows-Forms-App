namespace SDV_Main_App
{
    partial class AddNewTour
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
            this.NewTourUniqueCodeLTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NewTourDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NewTourStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.NewTourEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.NewTourMaxPassengersTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NewTourTravelDistanceTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NewTourMarkUpTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NewTourNewCostListBox = new System.Windows.Forms.ListBox();
            this.CreateNewCostBtn = new System.Windows.Forms.Button();
            this.NewTourCostsComboBox = new System.Windows.Forms.ComboBox();
            this.NewTourNameTxtBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NewTourNewAddBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.AddNewTourTotalCostLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "";
            this.label1.AccessibleName = "NewTourUniqueCodeLbl";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unique Code:";
            // 
            // NewTourUniqueCodeLTxtBox
            // 
            this.NewTourUniqueCodeLTxtBox.AccessibleName = "NewTourUniqueCodeLTxtBox";
            this.NewTourUniqueCodeLTxtBox.Location = new System.Drawing.Point(205, 169);
            this.NewTourUniqueCodeLTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewTourUniqueCodeLTxtBox.Name = "NewTourUniqueCodeLTxtBox";
            this.NewTourUniqueCodeLTxtBox.Size = new System.Drawing.Size(228, 27);
            this.NewTourUniqueCodeLTxtBox.TabIndex = 1;
            this.NewTourUniqueCodeLTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AccessibleName = "NewTourDescriptionLbl";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // NewTourDescriptionRichTextBox
            // 
            this.NewTourDescriptionRichTextBox.AccessibleName = "NewTourDescriptionRichTextBox";
            this.NewTourDescriptionRichTextBox.Location = new System.Drawing.Point(205, 271);
            this.NewTourDescriptionRichTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewTourDescriptionRichTextBox.Name = "NewTourDescriptionRichTextBox";
            this.NewTourDescriptionRichTextBox.Size = new System.Drawing.Size(228, 120);
            this.NewTourDescriptionRichTextBox.TabIndex = 3;
            this.NewTourDescriptionRichTextBox.Text = "";
            this.NewTourDescriptionRichTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AccessibleName = "NewTourStartDateLbl";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Start Date:";
            // 
            // NewTourStartDatePicker
            // 
            this.NewTourStartDatePicker.AccessibleName = "NewTourStartDatePicker";
            this.NewTourStartDatePicker.CustomFormat = "";
            this.NewTourStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NewTourStartDatePicker.Location = new System.Drawing.Point(205, 423);
            this.NewTourStartDatePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewTourStartDatePicker.Name = "NewTourStartDatePicker";
            this.NewTourStartDatePicker.Size = new System.Drawing.Size(228, 27);
            this.NewTourStartDatePicker.TabIndex = 5;
            this.NewTourStartDatePicker.Value = new System.DateTime(2022, 3, 29, 23, 22, 30, 0);
            this.NewTourStartDatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // NewTourEndDatePicker
            // 
            this.NewTourEndDatePicker.AccessibleName = "NewTourEndDatePicker";
            this.NewTourEndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NewTourEndDatePicker.Location = new System.Drawing.Point(205, 481);
            this.NewTourEndDatePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewTourEndDatePicker.Name = "NewTourEndDatePicker";
            this.NewTourEndDatePicker.Size = new System.Drawing.Size(228, 27);
            this.NewTourEndDatePicker.TabIndex = 7;
            this.NewTourEndDatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label4
            // 
            this.label4.AccessibleName = "NewTourEndDateLbl";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "End Date:";
            // 
            // NewTourMaxPassengersTxtBox
            // 
            this.NewTourMaxPassengersTxtBox.AccessibleName = "NewTourMaxPassengersTxtBox";
            this.NewTourMaxPassengersTxtBox.Location = new System.Drawing.Point(205, 544);
            this.NewTourMaxPassengersTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewTourMaxPassengersTxtBox.Name = "NewTourMaxPassengersTxtBox";
            this.NewTourMaxPassengersTxtBox.Size = new System.Drawing.Size(228, 27);
            this.NewTourMaxPassengersTxtBox.TabIndex = 9;
            this.NewTourMaxPassengersTxtBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AccessibleName = "NewTourMaxPassengersLbl";
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 548);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Max Passengers:";
            // 
            // NewTourTravelDistanceTxtBox
            // 
            this.NewTourTravelDistanceTxtBox.AccessibleName = "NewTourTravelDistanceTxtBox";
            this.NewTourTravelDistanceTxtBox.Location = new System.Drawing.Point(205, 604);
            this.NewTourTravelDistanceTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewTourTravelDistanceTxtBox.Name = "NewTourTravelDistanceTxtBox";
            this.NewTourTravelDistanceTxtBox.Size = new System.Drawing.Size(228, 27);
            this.NewTourTravelDistanceTxtBox.TabIndex = 11;
            this.NewTourTravelDistanceTxtBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AccessibleName = "NewTourTravelDistanceLbl";
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 608);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Travel Distance:";
            // 
            // NewTourMarkUpTxtBox
            // 
            this.NewTourMarkUpTxtBox.AccessibleName = "NewTourMarkUpTxtBox";
            this.NewTourMarkUpTxtBox.Location = new System.Drawing.Point(205, 665);
            this.NewTourMarkUpTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewTourMarkUpTxtBox.Name = "NewTourMarkUpTxtBox";
            this.NewTourMarkUpTxtBox.Size = new System.Drawing.Size(228, 27);
            this.NewTourMarkUpTxtBox.TabIndex = 13;
            this.NewTourMarkUpTxtBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AccessibleName = "NewTourMarkUpLbl";
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 668);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mark Up:";
            // 
            // label8
            // 
            this.label8.AccessibleName = "NewTourNewCostLbl";
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(898, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Currently added Costs";
            // 
            // NewTourNewCostListBox
            // 
            this.NewTourNewCostListBox.AccessibleName = "NewTourNewCostListBox";
            this.NewTourNewCostListBox.FormattingEnabled = true;
            this.NewTourNewCostListBox.ItemHeight = 20;
            this.NewTourNewCostListBox.Location = new System.Drawing.Point(762, 148);
            this.NewTourNewCostListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewTourNewCostListBox.Name = "NewTourNewCostListBox";
            this.NewTourNewCostListBox.Size = new System.Drawing.Size(415, 644);
            this.NewTourNewCostListBox.TabIndex = 15;
            this.NewTourNewCostListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // CreateNewCostBtn
            // 
            this.CreateNewCostBtn.AccessibleName = "NewTourNewCostBtn";
            this.CreateNewCostBtn.Location = new System.Drawing.Point(592, 356);
            this.CreateNewCostBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreateNewCostBtn.Name = "CreateNewCostBtn";
            this.CreateNewCostBtn.Size = new System.Drawing.Size(146, 41);
            this.CreateNewCostBtn.TabIndex = 16;
            this.CreateNewCostBtn.Text = "Create a new Cost";
            this.CreateNewCostBtn.UseVisualStyleBackColor = true;
            this.CreateNewCostBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewTourCostsComboBox
            // 
            this.NewTourCostsComboBox.AccessibleName = "NewTourCostsComboBox";
            this.NewTourCostsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NewTourCostsComboBox.FormattingEnabled = true;
            this.NewTourCostsComboBox.Location = new System.Drawing.Point(592, 287);
            this.NewTourCostsComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewTourCostsComboBox.Name = "NewTourCostsComboBox";
            this.NewTourCostsComboBox.Size = new System.Drawing.Size(146, 28);
            this.NewTourCostsComboBox.TabIndex = 19;
            this.NewTourCostsComboBox.SelectedIndexChanged += new System.EventHandler(this.NewTourCostsComboBox_SelectedIndexChanged);
            // 
            // NewTourNameTxtBox
            // 
            this.NewTourNameTxtBox.AccessibleName = "NewTourNameTxtBox";
            this.NewTourNameTxtBox.Location = new System.Drawing.Point(205, 224);
            this.NewTourNameTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewTourNameTxtBox.Name = "NewTourNameTxtBox";
            this.NewTourNameTxtBox.Size = new System.Drawing.Size(228, 27);
            this.NewTourNameTxtBox.TabIndex = 21;
            this.NewTourNameTxtBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label11
            // 
            this.label11.AccessibleDescription = "";
            this.label11.AccessibleName = "NewTourNameLbl";
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(150, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Name:";
            // 
            // button1
            // 
            this.button1.AccessibleName = "NewTourBackBtn";
            this.button1.Location = new System.Drawing.Point(14, 847);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 22;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // NewTourNewAddBtn
            // 
            this.NewTourNewAddBtn.AccessibleName = "NewTourNewAddBtn";
            this.NewTourNewAddBtn.Location = new System.Drawing.Point(509, 783);
            this.NewTourNewAddBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewTourNewAddBtn.Name = "NewTourNewAddBtn";
            this.NewTourNewAddBtn.Size = new System.Drawing.Size(121, 68);
            this.NewTourNewAddBtn.TabIndex = 23;
            this.NewTourNewAddBtn.Text = "Add Tour";
            this.NewTourNewAddBtn.UseVisualStyleBackColor = true;
            this.NewTourNewAddBtn.Click += new System.EventHandler(this.NewTourNewAddBtn_Click);
            // 
            // label12
            // 
            this.label12.AccessibleDescription = "AddNewTourUselessLabel";
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(764, 814);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Total cost of Costs: $ ";
            // 
            // AddNewTourTotalCostLbl
            // 
            this.AddNewTourTotalCostLbl.AccessibleDescription = "AddNewTourTotalCostLbl";
            this.AddNewTourTotalCostLbl.AutoSize = true;
            this.AddNewTourTotalCostLbl.Location = new System.Drawing.Point(903, 814);
            this.AddNewTourTotalCostLbl.Name = "AddNewTourTotalCostLbl";
            this.AddNewTourTotalCostLbl.Size = new System.Drawing.Size(13, 20);
            this.AddNewTourTotalCostLbl.TabIndex = 25;
            this.AddNewTourTotalCostLbl.Text = " ";
            // 
            // AddNewTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 951);
            this.Controls.Add(this.AddNewTourTotalCostLbl);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.NewTourNewAddBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NewTourNameTxtBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.NewTourCostsComboBox);
            this.Controls.Add(this.CreateNewCostBtn);
            this.Controls.Add(this.NewTourNewCostListBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NewTourMarkUpTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NewTourTravelDistanceTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NewTourMaxPassengersTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NewTourEndDatePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NewTourStartDatePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewTourDescriptionRichTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewTourUniqueCodeLTxtBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddNewTour";
            this.Text = "AddNewTour";
            this.Load += new System.EventHandler(this.AddNewTour_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox NewTourUniqueCodeLTxtBox;
        private Label label2;
        private RichTextBox NewTourDescriptionRichTextBox;
        private Label label3;
        private DateTimePicker NewTourStartDatePicker;
        private DateTimePicker NewTourEndDatePicker;
        private Label label4;
        private TextBox NewTourMaxPassengersTxtBox;
        private Label label5;
        private TextBox NewTourTravelDistanceTxtBox;
        private Label label6;
        private TextBox NewTourMarkUpTxtBox;
        private Label label7;
        private Label label8;
        private Button CreateNewCostBtn;
        private ComboBox NewTourCostsComboBox;
        private TextBox NewTourNameTxtBox;
        private Label label11;
        private Button button1;
        public ListBox NewTourNewCostListBox;
        private Button NewTourNewAddBtn;
        private Label label12;
        private Label AddNewTourTotalCostLbl;
    }
}