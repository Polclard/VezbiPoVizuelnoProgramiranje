using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportsSystem
{
    public partial class novAerodrom : Form
    {
        public novAerodrom()
        {
            InitializeComponent();
        }

        ErrorProvider townError = new ErrorProvider();
        ErrorProvider nameError = new ErrorProvider();
        ErrorProvider shortNameError = new ErrorProvider();

        private void textBoxTownName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTownName.Text.Length == 0)
            {
                townError.SetError(textBoxTownName, "Внеси град!");
            }
            else
            {
                townError.SetError(textBoxTownName, null);
            }
        }

        private void textBoxAirportName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAirportName.Text.Length == 0)
            {
                nameError.SetError(textBoxAirportName, "Внеси име на аеродром!");
            }
            else
            {
                nameError.SetError(textBoxAirportName, null);
            }
        }

        private void textBoxShortName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxShortName.Text.Length != 3 || textBoxShortName.Text != textBoxShortName.Text.ToUpper() || !Char.IsLetter(textBoxShortName.Text.ToCharArray()[0]) || !Char.IsLetter(textBoxShortName.Text.ToCharArray()[1]) || !Char.IsLetter(textBoxShortName.Text.ToCharArray()[2]))
            {
                shortNameError.SetError(textBoxShortName, "Кратенката мора да биде со 3 големи букви!");
            }
            //if (textBoxShortName.Text.Length != 3)
            //{
            //    shortNameError.SetError(textBoxShortName, "Кратенката мора да биде со 3 букви!");
            //}
            //if(textBoxShortName.Text != textBoxShortName.Text.ToUpper())
            //{
            //    shortNameError.SetError(textBoxShortName, "Кратенката мора да биде со големи букви!");
            //}
            else
            {
                shortNameError.SetError(textBoxShortName, null);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (textBoxTownName.Text != "" && textBoxAirportName.Text != "" && textBoxShortName.Text != "" && textBoxShortName.Text.Length == 3 && textBoxShortName.Text == textBoxShortName.Text.ToUpper() && Char.IsLetter(textBoxShortName.Text.ToCharArray()[0]) && Char.IsLetter(textBoxShortName.Text.ToCharArray()[1]) && Char.IsLetter(textBoxShortName.Text.ToCharArray()[2]))
            {
                Airport newAirport = new Airport(textBoxTownName.Text, textBoxAirportName.Text, textBoxShortName.Text);
                Form1.airports.Add(newAirport);
                this.Close();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
