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
    public partial class TourCostsVehicleForm : Form
    {
        public TourCostsVehicleForm()
        {
            InitializeComponent();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void TourCostsVehicleForm_Load(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveCost();
        }

        //Methods
        string tempPath = @"CostsTemp.txt";

        private void saveCost()
        {
            try
            {
                using (StreamWriter tw = new StreamWriter(tempPath, true))
                {
                    TourCostsOtherForm _tourCostsOtherForm = new TourCostsOtherForm();
                    CostsVehicleClass costsVehicleClass = new CostsVehicleClass();

                    tw.Write(costsVehicleClass.Type = "Vehicle");
                    tw.Write(",");
                    tw.Write(costsVehicleClass.Details = TourCostsVehicleFormDetailsTxtBox.Text);
                    tw.Write(",");
                    tw.Write(costsVehicleClass.KmCharge = float.Parse(TourCostsVehicleFormKmChargeTxtBox.Text));
                    tw.Write(",");
                    tw.Write(costsVehicleClass.DistanceTravelled = int.Parse(TourCostsVehicleFormDistanceTxtBox.Text));
                    tw.Write(",");
                    tw.Write(costsVehicleClass.TotalCost = float.Parse(TourCostsVehicleFormKmChargeTxtBox.Text) + int.Parse(TourCostsVehicleFormDistanceTxtBox.Text));
                    tw.WriteLine("");
                    tw.Flush();
                    tw.Close();

                    TourCostsVehicleFormDetailsTxtBox.Clear();
                    TourCostsVehicleFormKmChargeTxtBox.Clear();
                    TourCostsVehicleFormDistanceTxtBox.Clear();

                    this.Close();

                    AddNewTour addNewTour = new AddNewTour();
                    addNewTour.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                TourCostsVehicleFormDetailsTxtBox.Clear();
                TourCostsVehicleFormKmChargeTxtBox.Clear();
                TourCostsVehicleFormDistanceTxtBox.Clear();
            }
        }
    }     
}
