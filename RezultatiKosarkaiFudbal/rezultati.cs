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
    public partial class rezultati : Form
    {
        public rezultati()
        {
            InitializeComponent();
        }

        public List<Game<Football>> footbalGames = new List<Game<Football>>();
        public List<Game<Basketball>> basketballGame = new List<Game<Basketball>>();

        private void dodadiNatprevar_Click(object sender, EventArgs e)
        {
            dodadiNatprevar s = new dodadiNatprevar();
            s.Show();

            //if (footbalGames.Count > 0)
            //{
            //    foreach (var element in footbalGames)
            //    {
            //        listBoxFudbal.Items.Add($"{element.homeTeamName} {element.homeTeamScore}:{element.awayTeamScore} {element.awayTeamName}");
            //    }
            //}
            //if (basketballGame.Count > 0)
            //{
            //    foreach (var element in basketballGame)
            //    {
            //        listBoxKosarka.Items.Add($"{element.homeTeamName} {element.homeTeamScore}:{element.awayTeamScore} {element.awayTeamName}");
            //    }
            //}
        }

        private void zatvoriProzorec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
