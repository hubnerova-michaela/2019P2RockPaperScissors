using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissors.Model
{
    public class Rps
    {
        public Rps(int winCount = 0, int lossCount = 0, int drawCount = 0)
        {
            WinCount = winCount;
            LossCount = lossCount;
            DrawCount = drawCount;
            IsWinner = null;
        }

        public bool? IsWinner { get; set; }
        public int WinCount { get; set; }
        public int LossCount { get; set; }
        public int DrawCount { get; set; }

    }
}
