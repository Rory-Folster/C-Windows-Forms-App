using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel.DataAnnotations;

namespace SDV_Main_App
{
    public partial class AddNewTour : Form
    {
        private string[] _tourCostsComboOptions = { " ", "Vehicle", "Staff", "Other" };

        public AddNewTour()
        {
            InitializeComponent();
            LoadCosts();
            NewTourCostsComboBox.DataSource = _tourCostsComboOptions;
        
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CostComboBoxLoad();
        }


        private void NewTourCostsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();

            MainTour mainTour = new MainTour();
            mainTour.Show();
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            NewTourStartDatePicker.Format = DateTimePickerFormat.Custom;
            NewTourStartDatePicker.CustomFormat = "dd/mm/yyyy";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            NewTourEndDatePicker.Format = DateTimePickerFormat.Custom;
            NewTourEndDatePicker.CustomFormat = "dd/mm/yyyy";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewTourNewAddBtn_Click(object sender, EventArgs e)
        {
            SaveTours();
        }
        private void AddNewTour_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }



        //Methods
        
        
        private void LoadCosts()
        {
            List<CostsOtherClass> costsOtherClass = new List<CostsOtherClass>();

            try
            {
                using (StreamReader sr = new StreamReader(@"Tours.txt", true))
                {
                    while (sr.Peek() >= 0)
                    {
                        string str;
                        string[] strArray;
                        str = sr.ReadLine();
                        strArray = str.Split(",");

                        if (strArray[0] == "Vehicle")
                        {
                            CostsVehicleClass currentVehicleCost = new CostsVehicleClass();

                            string vehicleType = currentVehicleCost.Type = strArray[0];
                            string vehicleDetails = currentVehicleCost.Details = strArray[1];
                            float vehicleKmCharge = currentVehicleCost.KmCharge = float.Parse(strArray[2]);
                            int vehicleDistanceTravelled = currentVehicleCost.DistanceTravelled = int.Parse(strArray[3]);
                            float vehicleTotalCost = currentVehicleCost.TotalCost = float.Parse(strArray[4]);

                            NewTourNewCostListBox.Items.Add("Type: " + vehicleType);
                            NewTourNewCostListBox.Items.Add("Details: " + vehicleDetails);
                            NewTourNewCostListBox.Items.Add("KM Charge: " + vehicleKmCharge);
                            NewTourNewCostListBox.Items.Add("Distance Travelled: " + vehicleDistanceTravelled);
                            NewTourNewCostListBox.Items.Add("Total Cost: $" + vehicleTotalCost);

                            float addFloat = float.Parse(strArray[4]);
                            AddNewTourTotalCostLbl.Text += addFloat;
                        }
                        if (strArray[0] == "Staff")
                        {
                            CostsStaffClass currentStaffCost = new CostsStaffClass();

                            string staffType = currentStaffCost.Type = strArray[0];
                            string staffName = currentStaffCost.Name = strArray[1];
                            float staffDailyRate = currentStaffCost.DailyRate = float.Parse(strArray[2]);
                            DateTime staffStartDate = currentStaffCost.StartDate = DateTime.Parse(strArray[3]);
                            DateTime staffEndDate = currentStaffCost.EndDate = DateTime.Parse(strArray[4]);
                            float staffTotalCost = currentStaffCost.TotalCost = float.Parse(strArray[5]);

                            NewTourNewCostListBox.Items.Add("Type: " + staffType);
                            NewTourNewCostListBox.Items.Add("Name: " + staffName);
                            NewTourNewCostListBox.Items.Add("Daily Rate: " + staffDailyRate);
                            NewTourNewCostListBox.Items.Add("Start Date: " + staffStartDate);
                            NewTourNewCostListBox.Items.Add("End Date: " + staffEndDate);
                            NewTourNewCostListBox.Items.Add("Total Cost: $" + staffTotalCost);

                            float addFloat = float.Parse(strArray[5]);
                            AddNewTourTotalCostLbl.Text += addFloat;
                        }
                        if (strArray[0] == "Other")
                        {
                            CostsOtherClass currentOtherCost = new CostsOtherClass();

                            string otherType = currentOtherCost.Type = strArray[0];
                            string otherDescription = currentOtherCost.Description = strArray[1];
                            float otherPrice = currentOtherCost.Price = float.Parse(strArray[2]);

                            NewTourNewCostListBox.Items.Add("Type: " + otherType);
                            NewTourNewCostListBox.Items.Add("Description: " + otherDescription);
                            NewTourNewCostListBox.Items.Add("Total Price: $" + otherPrice);

                            float addFloat = float.Parse(strArray[2]);
                            AddNewTourTotalCostLbl.Text += addFloat;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveTours()
        {
            try
            {
                using (StreamWriter tw = new StreamWriter(@"Tours.txt", true))
                 {
                     Tours _addTours = new Tours();

                     tw.Write(_addTours.TourUniqueCode = int.Parse(NewTourUniqueCodeLTxtBox.Text));
                        tw.Write(",");
                        tw.Write(_addTours.TourName = NewTourNameTxtBox.Text);
                        tw.Write(",");
                        tw.Write(_addTours.TourDescription = NewTourDescriptionRichTextBox.Text); //Need to add Costs text box to save to file!
                        tw.Write(",");
                        tw.Write(_addTours.TourStartDate = DateTime.Parse(NewTourStartDatePicker.Text));
                        tw.Write(",");
                        tw.Write(_addTours.TourEndDate = DateTime.Parse(NewTourEndDatePicker.Text));
                        tw.Write(",");
                        tw.Write(_addTours.TourMaxPassengers = int.Parse(NewTourMaxPassengersTxtBox.Text));
                        tw.Write(",");
                        tw.Write(_addTours.TourTravelDistance = int.Parse(NewTourTravelDistanceTxtBox.Text));
                        tw.Write(",");
                        tw.Write(_addTours.TourMarkUp = int.Parse(NewTourMarkUpTxtBox.Text));
                        tw.Write(",");
                        using (StreamReader lines = new StreamReader(@"CostsTemp.txt"))
                        {
                            while (lines.Peek() >= 0)
                            {
                                tw.Write(lines.ReadLine());
                            }
                        }
                        using (StreamWriter rewriteTemp = new StreamWriter(@"CostsTemp.txt"))
                        {
                            rewriteTemp.Write("");
                        }
                        tw.WriteLine("");
                        tw.Flush();
                        tw.Close();

                        NewTourUniqueCodeLTxtBox.Clear();
                        NewTourNameTxtBox.Clear();
                        NewTourDescriptionRichTextBox.Clear();
                        NewTourMaxPassengersTxtBox.Clear();
                        NewTourTravelDistanceTxtBox.Clear();
                        NewTourMarkUpTxtBox.Clear();

                        MessageBox.Show("Tour added.");

                        this.Close();

                        MainTour mainTour = new MainTour();
                        mainTour.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    NewTourUniqueCodeLTxtBox.Clear();
                    NewTourNameTxtBox.Clear();
                    NewTourDescriptionRichTextBox.Clear();
                    NewTourMaxPassengersTxtBox.Clear();
                    NewTourTravelDistanceTxtBox.Clear();
                    NewTourMarkUpTxtBox.Clear();
                }
        }
        
    
        private void CostComboBoxLoad()
        {
            if (NewTourCostsComboBox.SelectedIndex == 0)
            {
                string message = "Please select a Cost type.";
                string caption = "Cost box empty";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                MessageBox.Show(message, caption, buttons);
            }
            else if (NewTourCostsComboBox.SelectedIndex == 1)
            {
                this.Close();

                TourCostsVehicleForm tourCostsForm = new TourCostsVehicleForm();
                tourCostsForm.Show();
            }

            else if (NewTourCostsComboBox.SelectedIndex == 2)
            {
                this.Close();

                TourCostsStaffForm tourCostsStaffForm = new TourCostsStaffForm();
                tourCostsStaffForm.Show();
            }

            else if (NewTourCostsComboBox.SelectedIndex == 3)
            {
                this.Close();

                TourCostsOtherForm tourCostsOtherForm = new TourCostsOtherForm();
                tourCostsOtherForm.Show();

            }
        }
    }
}
