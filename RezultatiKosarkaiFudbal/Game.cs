using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezultatiKosarkaiFudbal
{
    public class Game<T>
    {
        public string homeTeamName { get; set; }
        public string awayTeamName { get; set; }
        public int homeTeamScore { get; set; }
        public int awayTeamScore { get; set; }
        public T homeTeamDetails { get; set; }
        public T awayTeamDetails { get; set; }
        public DateTime date { get; set; }
    }
}
