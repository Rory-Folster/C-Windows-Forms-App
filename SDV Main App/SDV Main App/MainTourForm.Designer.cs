namespace SDV_Main_App
{
    partial class MainTour
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MainTourFormAddTourBtn = new System.Windows.Forms.Button();
            this.MainTourFormTourDetailListBox = new System.Windows.Forms.ListBox();
            this.MainTourFormCurrentToursListBox = new System.Windows.Forms.ListBox();
            this.MainTourFormExitBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MainTourSortByComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Current Tours";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(837, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tour Cost Log";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MainTourFormAddTourBtn
            // 
            this.MainTourFormAddTourBtn.AccessibleDescription = "MainTourFormAddTourBtn";
            this.MainTourFormAddTourBtn.Location = new System.Drawing.Point(461, 71);
            this.MainTourFormAddTourBtn.Name = "MainTourFormAddTourBtn";
            this.MainTourFormAddTourBtn.Size = new System.Drawing.Size(156, 93);
            this.MainTourFormAddTourBtn.TabIndex = 4;
            this.MainTourFormAddTourBtn.Text = "Add a Tour";
            this.MainTourFormAddTourBtn.UseVisualStyleBackColor = true;
            this.MainTourFormAddTourBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainTourFormTourDetailListBox
            // 
            this.MainTourFormTourDetailListBox.AccessibleDescription = "MainTourFormTourDetailListBox";
            this.MainTourFormTourDetailListBox.FormattingEnabled = true;
            this.MainTourFormTourDetailListBox.ItemHeight = 15;
            this.MainTourFormTourDetailListBox.Location = new System.Drawing.Point(693, 48);
            this.MainTourFormTourDetailListBox.MultiColumn = true;
            this.MainTourFormTourDetailListBox.Name = "MainTourFormTourDetailListBox";
            this.MainTourFormTourDetailListBox.Size = new System.Drawing.Size(328, 289);
            this.MainTourFormTourDetailListBox.TabIndex = 5;
            this.MainTourFormTourDetailListBox.SelectedIndexChanged += new System.EventHandler(this.MainTourFormTourDetailListBox_SelectedIndexChanged);
            // 
            // MainTourFormCurrentToursListBox
            // 
            this.MainTourFormCurrentToursListBox.AccessibleDescription = "MainTourFormCurrentToursListBox";
            this.MainTourFormCurrentToursListBox.FormattingEnabled = true;
            this.MainTourFormCurrentToursListBox.HorizontalScrollbar = true;
            this.MainTourFormCurrentToursListBox.ItemHeight = 15;
            this.MainTourFormCurrentToursListBox.Location = new System.Drawing.Point(25, 48);
            this.MainTourFormCurrentToursListBox.MultiColumn = true;
            this.MainTourFormCurrentToursListBox.Name = "MainTourFormCurrentToursListBox";
            this.MainTourFormCurrentToursListBox.Size = new System.Drawing.Size(328, 289);
            this.MainTourFormCurrentToursListBox.TabIndex = 6;
            this.MainTourFormCurrentToursListBox.SelectedIndexChanged += new System.EventHandler(this.MainTourFormCurrentToursListBox_SelectedIndexChanged);
            // 
            // MainTourFormExitBtn
            // 
            this.MainTourFormExitBtn.AccessibleDescription = "MainTourFormExitBtn";
            this.MainTourFormExitBtn.Location = new System.Drawing.Point(461, 339);
            this.MainTourFormExitBtn.Name = "MainTourFormExitBtn";
            this.MainTourFormExitBtn.Size = new System.Drawing.Size(156, 41);
            this.MainTourFormExitBtn.TabIndex = 7;
            this.MainTourFormExitBtn.Text = "Exit";
            this.MainTourFormExitBtn.UseVisualStyleBackColor = true;
            this.MainTourFormExitBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cost of all Tours: $";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(914, 303);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 9;
            this.button1.Text = "Delete Entry";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(710, 303);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 22);
            this.button2.TabIndex = 10;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // MainTourSortByComboBox
            // 
            this.MainTourSortByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MainTourSortByComboBox.FormattingEnabled = true;
            this.MainTourSortByComboBox.Location = new System.Drawing.Point(246, 22);
            this.MainTourSortByComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainTourSortByComboBox.Name = "MainTourSortByComboBox";
            this.MainTourSortByComboBox.Size = new System.Drawing.Size(107, 23);
            this.MainTourSortByComboBox.TabIndex = 11;
            this.MainTourSortByComboBox.SelectedIndexChanged += new System.EventHandler(this.MainTourSortByComboBox_SelectedIndexChanged);
            // 
            // MainTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 409);
            this.Controls.Add(this.MainTourSortByComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MainTourFormExitBtn);
            this.Controls.Add(this.MainTourFormCurrentToursListBox);
            this.Controls.Add(this.MainTourFormTourDetailListBox);
            this.Controls.Add(this.MainTourFormAddTourBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainTour";
            this.Text = "MainTourForm";
            this.Load += new System.EventHandler(this.MainTour_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Button MainTourFormAddTourBtn;
        private ListBox MainTourFormTourDetailListBox;
        private ListBox MainTourFormCurrentToursListBox;
        private Button MainTourFormExitBtn;
        private Label label3;
        private Button button1;
        private Button button2;
        private ComboBox MainTourSortByComboBox;
    }
}