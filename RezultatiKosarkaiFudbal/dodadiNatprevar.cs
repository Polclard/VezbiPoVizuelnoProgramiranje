using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezultatiKosarkaiFudbal
{
    public partial class dodadiNatprevar : Form
    {
        public Game<Football> footballGame;
        public Game<Basketball> basketballGame;

        public string natprevarTip;

        rezultati rz = new rezultati();

        public dodadiStrelec ds = new dodadiStrelec();

        public dodadiNatprevar()
        {
            InitializeComponent();
        }

        private void dodadiPrva_Click(object sender, EventArgs e)
        {
            natprevarTip = tipNatprevarDropDown.SelectedItem.ToString();
            if (tipNatprevarDropDown.SelectedItem == "Football")
            {
                footballGame = new Game<Football>();

                footballGame.homeTeamName = textBoxDomakin.Text;
                footballGame.awayTeamName = textBoxGostin.Text;
                footballGame.homeTeamScore = int.Parse(rezultatDomasni.Text);
                footballGame.awayTeamScore = int.Parse(rezultatGosti.Text);
            
                rz.footbalGames.Add(footballGame);
            }
            else if (tipNatprevarDropDown.SelectedItem == "Basketball")
            {
                basketballGame = new Game<Basketball>();

                basketballGame.homeTeamName = textBoxDomakin.Text;
                basketballGame.awayTeamName = textBoxGostin.Text;
                basketballGame.homeTeamScore = int.Parse(rezultatDomasni.Text);
                basketballGame.awayTeamScore = int.Parse(rezultatGosti.Text);

                rz.basketballGame.Add(basketballGame);
            }
        }

        private void otkaziPrva_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dodadiStrelciDoma_Click(object sender, EventArgs e)
        {
            dodadiStrelec ds = new dodadiStrelec();
            ds.Show();
        }

        private void dodadiStrelciGosti_Click(object sender, EventArgs e)
        {
            dodadiStrelec dsg = new dodadiStrelec();
            dsg.Show();
        }
    }
}
