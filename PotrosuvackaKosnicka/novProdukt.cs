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



        private void otkaziForma2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dodadiForma2_Click(object sender, EventArgs e)
        {
            if(nameForma2.Text != "" && cateogryForma2.Text != "" && priceForma2.Text != "")
            {
                Product product = new Product(nameForma2.Text, cateogryForma2.Text, float.Parse(priceForma2.Text));
                Form1.listOfProducts.Add(product);
                this.Close();
            }
        }
    }
}
