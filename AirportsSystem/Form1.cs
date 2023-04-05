namespace AirportsSystem
{
    public partial class Form1 : Form
    {
        static public List<Airport> airports = new List<Airport>();
        static public List<Destination> destinations = new List<Destination>();
        public Form1()
        {
            InitializeComponent();

            List<Destination> dst = new List<Destination>();
            dst.Add(new Destination("Виена", 1240, 260));
            dst.Add(new Destination("Франкфурт", 1550, 290));
            dst.Add(new Destination("Лондон", 2150, 440));
            listAirports.Items.Add(new Airport("Скопје", "Александар Велики", "SKP", dst));
            List<Destination> dst1 = new List<Destination>();
            dst1.Add(new Destination("Кина", 9000, 5000));
            dst1.Add(new Destination("Марсеј", 4550, 1300));
            dst1.Add(new Destination("Берлин", 4000, 320));
            listAirports.Items.Add(new Airport("Барселона", "Ел Прат", "BAR", dst1));
            List<Destination> dst2 = new List<Destination>();
            dst2.Add(new Destination("Њу Јорк", 10000, 9060));
            dst2.Add(new Destination("Атина", 650, 100));
            dst2.Add(new Destination("Белград", 600, 120));
            listAirports.Items.Add(new Airport("Виена", "Виена ИА", "VIE", dst2));
            List<Destination> dst3 = new List<Destination>();
            dst3.Add(new Destination("Алепо", 7000, 4590));
            dst3.Add(new Destination("Каиро", 7050, 2400));
            dst3.Add(new Destination("Мадрид", 5050, 450));
            listAirports.Items.Add(new Airport("Истанбул", "Ататурк ИА", "IST", dst3));
        }

        private void addDestination_Click(object sender, EventArgs e)
        {
            Airport? theSelectedAirport = listAirports.SelectedItem as Airport;
            if (theSelectedAirport != null)
            {
                novaDestinacija nD = new novaDestinacija();
                DialogResult result = nD.ShowDialog();

                if(result == DialogResult.Yes)
                {
                    theSelectedAirport.Destinations.Add(destinations[0]);
                    destinations.Clear();
                }

            }
        }

        private void addAirport_Click(object sender, EventArgs e)
        {
            novAerodrom nA = new novAerodrom();
            nA.ShowDialog();

            foreach (Airport airport in airports)
            {
                listAirports.Items.Add(airport);
            }
        }

        private void listAirports_SelectedIndexChanged(object sender, EventArgs e)
        {
            listDestinations.Items.Clear();
            if(listAirports.SelectedItem != null)
            {
                Airport? selectedAirport = listAirports.SelectedItem as Airport;
                Destination mostExpensiveDestination = new Destination();
                decimal averageDistance = 0;
                if (selectedAirport != null && selectedAirport.Destinations != null)
                {
                    if (selectedAirport.Destinations.Count != 0)
                    {
                        mostExpensiveDestination = selectedAirport.Destinations[0];
                    }
                    foreach (Destination destination in selectedAirport.Destinations)
                    {
                        if (destination.Price > mostExpensiveDestination.Price)
                        {
                            mostExpensiveDestination = destination;
                        }
                        averageDistance += destination.Distance;
                        listDestinations.Items.Add(destination);
                    }
                    if (listDestinations.Items.Count != 0)
                    {
                        textBoxMostExpensiveDestination.Text = mostExpensiveDestination.ToString();
                        textBoxAverageLengthOfDestinations.Text = String.Format("{0:0.0}", averageDistance / (decimal)selectedAirport.Destinations.Count);
                    }
                }

            }
        }

        private void deleteAirport_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =  MessageBox.Show("Дали сте сигурни дека сакате да го избришете селектираниот аеродром?", "Избриши аеродром?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.Yes)
                listAirports.Items.Remove(listAirports.SelectedItem);
        }
    }
}