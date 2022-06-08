namespace SDV_Main_App
{
    public partial class MainTour : Form
    {
        DataAccess dataAccess = new DataAccess();
        private string[] _mainTourSortByComboBox = { "Name", "Date" };
        string toursPath = @"Tours.txt";
        public MainTour()
        {
            InitializeComponent();
            loadListbox();
            MainTourSortByComboBox.DataSource = _mainTourSortByComboBox;
        }

        private void MainTour_Load(Object sender, EventArgs e)
        {

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewTour addNewTour = new AddNewTour();
            addNewTour.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainTourFormCurrentToursListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDetails();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string delete = MainTourFormCurrentToursListBox.GetItemText(MainTourFormCurrentToursListBox.SelectedItem);
            delete = delete.Split()[0];

            DialogResult dialogResult = MessageBox.Show(@$"Are you sure you want to remove {delete}'s data?", @"Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dataAccess.DeleteEntry(delete);
                loadListbox();

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            editTour();
        }

        private void MainTourSortByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadListbox();
        }

        private void MainTourFormTourDetailListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        //Methods

        private void loadListbox() //move to dataccess.
        {
            List<Tours> Tours = new List<Tours>();
            int sortBy = MainTourSortByComboBox.SelectedIndex;

            if (sortBy == 0)
            {
                using (StreamReader sr = new StreamReader(toursPath))
                {
                    while (sr.Peek() >= 0)
                    {
                        string str;
                        Label totalCost = new Label();
                        string[] strArray;
                        str = sr.ReadLine();

                        strArray = str.Split(',');
                        Tours currentTour = new Tours();
                        currentTour.TourUniqueCode = int.Parse(strArray[0]);
                        currentTour.TourName = strArray[1];
                        currentTour.TourDescription = strArray[2];
                        currentTour.TourStartDate = DateTime.Parse(strArray[3]);
                        currentTour.TourEndDate = DateTime.Parse(strArray[4]);
                        currentTour.TourMaxPassengers = int.Parse(strArray[5]);
                        currentTour.TourTravelDistance = int.Parse(strArray[6]);
                        currentTour.TourMarkUp = int.Parse(strArray[7]);
                        /*currentTour.Costs = strArray[8];*/
                        totalCost.Text += (int.Parse(strArray[5]) + int.Parse(strArray[6])); // grabs two values and adds them together. 

                        Tours.Add(currentTour);
                        this.Controls.Add(totalCost); //adds element to current form. 
                    }
                }
                MainTourFormCurrentToursListBox.DataSource = Tours;
                MainTourFormCurrentToursListBox.ValueMember = "TourUniqueCode";
                MainTourFormCurrentToursListBox.DisplayMember = "nameDate";
            }
            else if (sortBy == 1)
            {
                using (StreamReader sr = new StreamReader(toursPath))
                {
                    while (sr.Peek() >= 0)
                    {
                        string str;
                        Label totalCost = new Label();
                        string[] strArray;
                        str = sr.ReadLine();

                        strArray = str.Split(',');
                        Tours currentTour = new Tours();
                        currentTour.TourUniqueCode = int.Parse(strArray[0]);
                        currentTour.TourName = strArray[1];
                        currentTour.TourDescription = strArray[2];
                        currentTour.TourStartDate = DateTime.Parse(strArray[3]);
                        currentTour.TourEndDate = DateTime.Parse(strArray[4]);
                        currentTour.TourMaxPassengers = int.Parse(strArray[5]);
                        currentTour.TourTravelDistance = int.Parse(strArray[6]);
                        currentTour.TourMarkUp = int.Parse(strArray[7]);
                        /*currentTour.Costs = strArray[8];*/
                        totalCost.Text += (int.Parse(strArray[5]) + int.Parse(strArray[6])); // grabs two values and adds them together. 

                        Tours.Add(currentTour);
                        this.Controls.Add(totalCost); //adds element to current form. 
                    }
                }
                MainTourFormCurrentToursListBox.DataSource = Tours;
                MainTourFormCurrentToursListBox.ValueMember = "TourUniqueCode";
                MainTourFormCurrentToursListBox.DisplayMember = "dateName";
            };

        }

        private void loadDetails()
        {
            MainTourFormTourDetailListBox.Items.Clear();
            var boundList = (IList<Tours>)MainTourFormCurrentToursListBox.DataSource;
            Tours selected = boundList[MainTourFormCurrentToursListBox.SelectedIndex];

            MainTourFormTourDetailListBox.Items.Add("Unique Code: " + selected.TourUniqueCode);
            MainTourFormTourDetailListBox.Items.Add("Tour Name: " + selected.TourName);
            MainTourFormTourDetailListBox.Items.Add("Description: " + selected.TourDescription);
            MainTourFormTourDetailListBox.Items.Add("Start Date: " + selected.TourStartDate);
            MainTourFormTourDetailListBox.Items.Add("End Date: " + selected.TourEndDate);
            MainTourFormTourDetailListBox.Items.Add("Max Passengers: " + selected.TourMaxPassengers);
            MainTourFormTourDetailListBox.Items.Add("Travel Distance: " + selected.TourTravelDistance);
            MainTourFormTourDetailListBox.Items.Add("Mark Up: " + selected.TourMarkUp);
            MainTourFormTourDetailListBox.Items.Add("Costs: " + selected.Costs);
        }

        private void editTour()
        {
            
            EditTourForm editNewTour = new EditTourForm();
            var boundList = (IList<Tours>)MainTourFormCurrentToursListBox.DataSource;
            Tours selected = boundList[MainTourFormCurrentToursListBox.SelectedIndex];

            editNewTour.tourUniqueCode = selected.TourUniqueCode.ToString();
            editNewTour.tourName = selected.TourName;
            editNewTour.tourDescription = selected.TourDescription;
            editNewTour.startDate = selected.TourStartDate;
            editNewTour.endDate = selected.TourEndDate;
            editNewTour.maxPassengers = selected.TourMaxPassengers.ToString();
            editNewTour.travelDistance = selected.TourTravelDistance.ToString();
            editNewTour.markUp = selected.TourMarkUp.ToString();
            editNewTour.Show();

            this.Hide();
        }

    }
}