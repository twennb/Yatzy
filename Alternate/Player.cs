using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Alternate
{
    public class Player
    {
        public Dictionary<string, string> PlayerCells = new Dictionary<string, string>();

        public int ScoreSum { get; set; }
        public bool HasBonus { get; set; }

        public Player(string ones, string twos, string threes,
            string fours, string fives, string sixes)
        {
            PlayerCells.Add("ones", ones);
            PlayerCells.Add("twos", twos);
            PlayerCells.Add("threes", threes);
            PlayerCells.Add("fours", fours);
            PlayerCells.Add("fives", fives);
            PlayerCells.Add("sixes", sixes);

            ScoreSum = 0;
            HasBonus = false;
        }
    }
}
