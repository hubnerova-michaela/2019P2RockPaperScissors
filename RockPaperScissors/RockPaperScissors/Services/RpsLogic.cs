using RockPaperScissors.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissors.Services
{
    public class RpsLogic
    {

        private readonly Random random;

        public RpsLogic(Random random)
        {
            this.random = random;
        }

        public Rps userData { get; set; }

        public void GameRound(RpsMode userChoice)
        {
            RpsMode aiChoice = (RpsMode)random.Next(1, 4);

            if (aiChoice == RpsMode.Rock && userChoice == RpsMode.Scissors ||
                aiChoice == RpsMode.Paper && userChoice == RpsMode.Rock ||
                aiChoice == RpsMode.Scissors && userChoice == RpsMode.Paper)
            {
                userData.LossCount++;
                userData.IsWinner = false;
            }

            else if (aiChoice == userChoice)
            {
                userData.DrawCount++;
                userData.IsWinner = null;

            }

            else
            {
                userData.WinCount++;
                userData.IsWinner = true;

            }
                
                
                
            







        }
    }
}
