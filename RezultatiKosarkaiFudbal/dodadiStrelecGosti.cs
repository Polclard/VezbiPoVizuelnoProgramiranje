using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezultatiKosarkaiFudbal
{
    public partial class dodadiStrelecGosti : Form
    {
        dodadiNatprevar dn;
        public dodadiStrelecGosti()
        {
            InitializeComponent();
        }

        private void dodadiStrelecVtoraForma_Click(object sender, EventArgs e)
        {
            if (dn.natprevarTip == "Football")
            {
                dn.footballGame.awayTeamDetails.Details.Add(new Details<string, string>(igracVtoraForma.Text, poeniMinutaVtoraForma.Text));
            }
            else if (dn.natprevarTip == "Basketball")
            {
                dn.basketballGame.awayTeamDetails.Details.Add(new Details<string, int>(igracVtoraForma.Text, int.Parse(poeniMinutaVtoraForma.Text)));
            }
        }

        private void otkaziVtoraForma_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
