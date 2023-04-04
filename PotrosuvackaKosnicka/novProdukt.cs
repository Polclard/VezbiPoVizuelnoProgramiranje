using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PotrosuvackaKosnicka
{
    public partial class novProdukt : Form
    {
        Form1 form1 = new Form1();
        public novProdukt()
        {
            InitializeComponent();
        }

        ErrorProvider errorProviderName = new ErrorProvider();
        ErrorProvider errorProviderCategory = new ErrorProvider();
        ErrorProvider errorProviderPrice = new ErrorProvider();


        private void otkaziForma2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dodadiForma2_Click(object sender, EventArgs e)
        {
            if (nameForma2.Text != "" && cateogryForma2.Text != "" && priceForma2.Text != "")
            {
                Product product = new Product(nameForma2.Text, cateogryForma2.Text, float.Parse(priceForma2.Text));
                Form1.listOfProducts.Add(product);
                this.Close();
            }
        }

        private void nameForma2_Validated(object sender, EventArgs e)
        {
            if (nameForma2.Text.Length == 0)
            {
                errorProviderName.SetError(nameForma2, "Внесете име!");
            }
            else
            {
                errorProviderName.SetError(nameForma2, null);
            }
        }

        private void cateogryForma2_Validated(object sender, EventArgs e)
        {
            if (cateogryForma2.Text.Length == 0)
            {
                errorProviderCategory.SetError(cateogryForma2, "Внесете категорија!");
            }
            else
            {
                errorProviderCategory.SetError(cateogryForma2, null);
            }
        }

        private void priceForma2_Validated(object sender, EventArgs e)
        {
            if (priceForma2.Text.Length == 0)
            {
                errorProviderPrice.SetError(priceForma2, "Внесете цена!");
            }
            else
            {
                errorProviderPrice.SetError(priceForma2, null);
            }
        }
    }
}
