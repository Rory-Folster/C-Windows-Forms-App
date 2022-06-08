using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDV_Main_App
{
    public partial class TourCostsStaffForm : Form
    {

        public TourCostsStaffForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TourCostsStaffForm_Load(object sender, EventArgs e)
        {

        }

        //Methods
        string tempPath = @"CostsTemp.txt";

        private void saveCost()
        {
                        try
            {
                using (StreamWriter tw = new StreamWriter(tempPath, true))
                {
                    CostsStaffClass costsStaffClass = new CostsStaffClass();
                    string DayDiff = (DateTime.Parse(TourCostsStaffFormStartDatePicker.Text) - DateTime.Parse(TourCostsStaffFormEndDatePicker.Text)).TotalDays.ToString();

                    tw.Write(costsStaffClass.Type = "Staff");
                    tw.Write(",");
                    tw.Write(costsStaffClass.Name = TourCostsStaffFormNameTxtBox.Text);
                    tw.Write(",");
                    tw.Write(costsStaffClass.DailyRate = float.Parse(TourCostsStaffFormDailyRateTxtBox.Text));
                    tw.Write(",");
                    tw.Write(costsStaffClass.StartDate = DateTime.Parse(TourCostsStaffFormStartDatePicker.Text));
                    tw.Write(",");
                    tw.Write(costsStaffClass.EndDate = DateTime.Parse(TourCostsStaffFormEndDatePicker.Text));
                    tw.Write(",");
                    tw.Write(costsStaffClass.TotalCost = float.Parse(TourCostsStaffFormDailyRateTxtBox.Text) + float.Parse(DayDiff));
                    tw.WriteLine("");
                    tw.Flush();
                    tw.Close();

                    TourCostsStaffFormNameTxtBox.Clear();
                    TourCostsStaffFormDailyRateTxtBox.Clear();

                    this.Close();

                    AddNewTour addNewTour = new AddNewTour();
                    addNewTour.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                TourCostsStaffFormNameTxtBox.Clear();
                TourCostsStaffFormDailyRateTxtBox.Clear();
            } 
        }
    }
}
