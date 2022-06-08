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
    public partial class TourCostsOtherForm : Form
    {
        public TourCostsOtherForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            saveCost();
        }

        private void TourCostsVehicleFormDetailsTxtBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TourCostsFormLbl_Click(object sender, EventArgs e)
        {

        }

        private void TourCostsOtherForm_Load(object sender, EventArgs e)
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

                    CostsOtherClass costsOtherClass = new CostsOtherClass();

                    tw.Write(costsOtherClass.Type = "Other");
                    tw.Write(",");
                    tw.Write(costsOtherClass.Description = TourCostsOtherFormDescriptionTxtBox.Text);
                    tw.Write(",");
                    tw.Write(costsOtherClass.Price = float.Parse(TourCostsOtherFormPriceTxtBox.Text));
                    tw.WriteLine("");
                    tw.Flush();
                    tw.Close();

                    TourCostsOtherFormDescriptionTxtBox.Clear();
                    TourCostsOtherFormPriceTxtBox.Clear();

                    this.Close();

                    AddNewTour addNewTour = new AddNewTour();
                    addNewTour.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                TourCostsOtherFormDescriptionTxtBox.Clear();
                TourCostsOtherFormPriceTxtBox.Clear();
            }
        }
    }
}
