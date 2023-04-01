using System.Collections.ObjectModel;
using System.Windows.Forms.VisualStyles;

namespace NarackaNaPica
{
    public partial class Form1 : Form
    {
        public float finalPrice { get; set; }

        public Form1()
        {
            InitializeComponent();
        }


        public void changeFinalPrice(float price, char addSub)
        {
            if (addSub == '-')
            {
                finalPrice -= price;
            }
            if (addSub == '+')
            {
                finalPrice += price;
            }
            vkupnoZaNaplata.Text = finalPrice.ToString();
        }



        public void recalculateTotal()
        {
            float total = 0;
            if (mala.Checked)
            {
                total += float.Parse(cenaMala.Text);
            }
            if (sredna.Checked)
            {
                total += float.Parse(cenaSredna.Text);
            }
            if (golema.Checked)
            {
                total += float.Parse(cenaGolema.Text);
            }

            if (checkBoxFeferoni.Checked)
            {
                total += float.Parse(cenaFeferoni.Text);
            }
            if (checkBoxEkstraSirenje.Checked)
            {
                total += float.Parse(cenaEkstraSirenje.Text);
            }
            if (checkBoxKecap.Checked)
            {
                total += float.Parse(cenaKecap.Text);
            }

            if (vkupnoKFS.Text != "")
            {
                total += float.Parse(vkupnoKFS.Text);
            }
            if (vkupnoJP.Text != "")
            {
                total += float.Parse(vkupnoJP.Text);
            }
            if (vkunpPivo.Text != "")
            {
                total += float.Parse(vkunpPivo.Text);
            }

            total += float.Parse(cenaDesert.Text);

            vkupnoZaNaplata.Text = total.ToString();


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            recalculateTotal();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (kolicinaKFS.Text != "" && cenaKFS.Text != "")
            {
                float kolicinaxcena = float.Parse(kolicinaKFS.Text) * float.Parse(cenaKFS.Text);
                vkupnoKFS.Text = kolicinaxcena.ToString();
                recalculateTotal();
            }
        }

        private void mala_CheckedChanged(object sender, EventArgs e)
        {
            recalculateTotal();
        }

        private void sredna_CheckedChanged(object sender, EventArgs e)
        {
            recalculateTotal();
        }

        private void checkBoxFeferoni_CheckedChanged(object sender, EventArgs e)
        {
            recalculateTotal();
        }

        private void checkBoxEkstraSirenje_CheckedChanged(object sender, EventArgs e)
        {
            recalculateTotal();
        }

        private void checkBoxKecap_CheckedChanged(object sender, EventArgs e)
        {
            recalculateTotal();
        }

        private void cenaKFS_TextChanged(object sender, EventArgs e)
        {
            if (kolicinaKFS.Text != "" && cenaKFS.Text != "")
            {
                float kolicinaxcena = float.Parse(kolicinaKFS.Text) * float.Parse(cenaKFS.Text);
                vkupnoKFS.Text = kolicinaxcena.ToString();
                recalculateTotal();
                //float vkupnaSuma = float.Parse(vkupnoZaNaplata.Text)
            }
        }

        private void kolicinaJP_TextChanged(object sender, EventArgs e)
        {
            if (kolicinaJP.Text != "" && kolicinaJP.Text != "")
            {
                float kolicinaxcena = float.Parse(kolicinaJP.Text) * float.Parse(cenaJP.Text);
                vkupnoJP.Text = kolicinaxcena.ToString();
                recalculateTotal();
                //float vkupnaSuma = float.Parse(vkupnoZaNaplata.Text)
            }
        }

        private void cenaJP_TextChanged(object sender, EventArgs e)
        {
            if (kolicinaJP.Text != "" && cenaJP.Text != "")
            {
                float kolicinaxcena = float.Parse(kolicinaJP.Text) * float.Parse(cenaJP.Text);
                vkupnoJP.Text = kolicinaxcena.ToString();
                recalculateTotal();
                //float vkupnaSuma = float.Parse(vkupnoZaNaplata.Text)
            }
        }

        private void cenaPivo_TextChanged(object sender, EventArgs e)
        {
            if (kolicinaPivo.Text != "" && cenaPivo.Text != "")
            {
                float kolicinaxcena = float.Parse(kolicinaPivo.Text) * float.Parse(cenaPivo.Text);
                vkunpPivo.Text = kolicinaxcena.ToString();
                recalculateTotal();
                //float vkupnaSuma = float.Parse(vkupnoZaNaplata.Text)
            }
        }

        private void kolicinaPivo_TextChanged(object sender, EventArgs e)
        {
            if (kolicinaPivo.Text != "" && cenaPivo.Text != "")
            {
                float kolicinaxcena = float.Parse(kolicinaPivo.Text) * float.Parse(cenaPivo.Text);
                vkunpPivo.Text = kolicinaxcena.ToString();
                recalculateTotal();
                //float vkupnaSuma = float.Parse(vkupnoZaNaplata.Text)
            }
        }

        private void listDeserts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDeserts.SelectedItems.Count > 0)
            {
                int a = listDeserts.SelectedIndex;
                if (a == 0)
                {
                    cenaDesert.Text = "290";
                }
                else if (a == 1)
                {
                    cenaDesert.Text = "80";
                }
                else if (a == 2)
                {
                    cenaDesert.Text = "300";
                }
            }
            recalculateTotal();
        }

        private void cenaMala_TextChanged(object sender, EventArgs e)
        {
            recalculateTotal();
        }

        private void cenaSredna_TextChanged(object sender, EventArgs e)
        {
            recalculateTotal();
        }

        private void cenaGolema_TextChanged(object sender, EventArgs e)
        {
            recalculateTotal();
        }

        private void cenaFeferoni_TextChanged(object sender, EventArgs e)
        {
            recalculateTotal();
        }

        private void cenaEkstraSirenje_TextChanged(object sender, EventArgs e)
        {
            recalculateTotal();
        }

        private void cenaKecap_TextChanged(object sender, EventArgs e)
        {
            recalculateTotal();
        }

        private void buttonNaracaj_Click(object sender, EventArgs e)
        {
            if (float.Parse(naplateno.Text) >= float.Parse(vkupnoZaNaplata.Text) && float.Parse(vkupnoZaNaplata.Text) != 0)
            {
                zaVrakjanje.Text = (float.Parse(naplateno.Text) - float.Parse(vkupnoZaNaplata.Text)).ToString();
                naplateno.BackColor = Color.Green;
            }
            else
            {
                naplateno.BackColor = Color.Red;
                MessageBox.Show("Nemas dovolno pari!");
            }
        }

        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}