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
    public partial class EditTourForm : Form
    {

        
        public EditTourForm()
        {
            InitializeComponent();
        }

        private void EditTourForm_Load(object sender, EventArgs e)
        {
        }

        private void EditTourConfirmBtn_Click(object sender, EventArgs e)
        {
            string toursPath = @"Tours.txt";

            int newTourUniqueCode = int.Parse(EditTourUniqueCodeLTxtBox.Text);
            string newTourName = EditTourNameTxtBox.Text;
            string newTourDescription = EditTourDescriptionRichTextBox.Text;
            DateTime newTourStartDate = EditTourStartDatePicker.Value;
            DateTime newTourEndDate = EditTourEndDatePicker.Value;
            int newTourMaxPassengers = int.Parse(EditTourMaxPassengersTxtBox.Text);
            int newTourTravelDistance = int.Parse(EditTourTravelDistanceTxtBox.Text);
            int newTourMarkUpPrice = int.Parse(EditTourMarkUpTxtBox.Text);

            string toFile = newTourUniqueCode+","+newTourName + "," + newTourDescription + "," + newTourStartDate + "," 
                   + newTourEndDate + "," + newTourMaxPassengers + "," + newTourTravelDistance + "," + newTourMarkUpPrice;

            string tempFile = Path.GetTempFileName();
            string tempUnqiue = newTourUniqueCode.ToString();
            using(var sr = new StreamReader(toursPath))
                using(var sw = new StreamWriter(tempFile))
            {
                string[] fields = toursPath.Split(',');
                string line;

                while((line = sr.ReadLine()) != null)
                {
                    if (!line.Contains(tempUnqiue))
                        sw.WriteLine(line);
                    else
                        sw.WriteLine(line.Replace(line, toFile));
                }
            }

            File.Delete(toursPath);
            File.Move(tempFile, toursPath);

            MessageBox.Show("Entry updated!");
            MainTour mainTour = new MainTour();
            mainTour.Show();
            this.Close();
        }





        //Methods for sending entry data to AddNewTours form. This allows the input fields to be updated with the entry data, for example, the unique tour code of the entry will be added to the
        //unique code input field for editing. 

        public string tourUniqueCode
        {
            get { return EditTourUniqueCodeLTxtBox.Text; }
            set { EditTourUniqueCodeLTxtBox.Text = value; }
        }

        public string tourName
        {
            get { return EditTourNameTxtBox.Text; }
            set { EditTourNameTxtBox.Text = value; }
        }

        public string tourDescription
        {
            get { return EditTourDescriptionRichTextBox.Text; }
            set { EditTourDescriptionRichTextBox.Text = value; }
        }

        public DateTime startDate
        {
            get { return EditTourStartDatePicker.Value; }
            set { EditTourStartDatePicker.Value = value; }
        }

        public DateTime endDate
        {
            get { return EditTourEndDatePicker.Value; }
            set { EditTourEndDatePicker.Value = value; }
        }

        public string maxPassengers
        {
            get { return EditTourMaxPassengersTxtBox.Text; }
            set { EditTourMaxPassengersTxtBox.Text = value; }
        }

        public string travelDistance
        {
            get { return EditTourTravelDistanceTxtBox.Text; }
            set { EditTourTravelDistanceTxtBox.Text = value; }
        }

        public string markUp
        {
            get { return EditTourMarkUpTxtBox.Text; }
            set { EditTourMarkUpTxtBox.Text = value; }
        }

        private void EditTourUniqueCodeLTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}
