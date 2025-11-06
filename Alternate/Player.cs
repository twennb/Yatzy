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
        public List<TextBox> PlayerCells = new List<TextBox>();

        public string Name { get; set; }

        public Player(TextBox ones, TextBox twos, TextBox threes,
            TextBox fours, TextBox fives, TextBox sixes, string name)
        {
            PlayerCells.Add(ones);
            PlayerCells.Add(twos);
            PlayerCells.Add(threes);
            PlayerCells.Add(fours);
            PlayerCells.Add(fives);
            PlayerCells.Add(sixes);

            Name = name;
        }
    }
}
