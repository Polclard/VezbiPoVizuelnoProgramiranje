using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashAccount
{
    public partial class newProduct : Form
    {
        public newProduct()
        {
            InitializeComponent();
        }

        ErrorProvider duplicateCodeError = new ErrorProvider();
        ErrorProvider noNameError = new ErrorProvider();

        private void enter_Click(object sender, EventArgs e)
        {
            if (numericUpDownCode.Value > 0 && numericUpDownPrice.Value > 0 && textBoxName.Text != "" && !Form1.UsedCodes.Contains((int)numericUpDownCode.Value))
            {
                Form1.Product = new Product((int)numericUpDownCode.Value, textBoxName.Text, (decimal)numericUpDownPrice.Value);
                this.Close();
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                noNameError.SetError(textBoxName, "Внеси име!");
            }
            else
            {
                noNameError.SetError(textBoxName, null);
            }
        }

        private void numericUpDownCode_ValueChanged(object sender, EventArgs e)
        {
            if (Form1.UsedCodes.Contains((int)numericUpDownCode.Value))
            {
                duplicateCodeError.SetError(numericUpDownCode, "Продукт со таков код веќе постои!");
            }
            else
            {
                duplicateCodeError.SetError(numericUpDownCode, null);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
