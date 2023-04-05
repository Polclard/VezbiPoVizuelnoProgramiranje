using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportsSystem
{
    public partial class novaDestinacija : Form
    {
        public novaDestinacija()
        {
            InitializeComponent();
        }

        ErrorProvider nameError = new ErrorProvider();
        ErrorProvider lengthError = new ErrorProvider();
        ErrorProvider priceError = new ErrorProvider();

        private void textBoxTownName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length == 0)
            {
                nameError.SetError(textBoxName, "Внеси име!");
            }
            else
            {
                nameError.SetError(textBoxName, null);
            }
        }

        private void numericUpDownLength_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownLength.Value == 0)
            {
                lengthError.SetError(numericUpDownLength, "Внеси должина!");
            }
            else
            {
                lengthError.SetError(numericUpDownLength, null);
            }
        }

        private void numericUpDownPrice_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownPrice.Value == 0)
            {
                priceError.SetError(numericUpDownPrice, "Внеси цена!");
            }
            else
            {
                priceError.SetError(numericUpDownPrice, null);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (textBoxName.Name != "" && numericUpDownLength.Value != 0 && numericUpDownPrice.Value != 0)
            {
                Destination newDestination = new Destination(textBoxName.Text, numericUpDownLength.Value, numericUpDownPrice.Value);
                Form1.destinations.Add(newDestination);
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
