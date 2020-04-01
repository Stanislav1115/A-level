using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_11_Grishchenko.Players
{
    public class GamePlayer : BasePlayer
    {
        private readonly List<int> passedGuessings;

        public GamePlayer()
        {
            passedGuessings = new List<int>();
        }

        protected override string PlayerType => "Game Player";
        public override int GuessNumber()
        {
            var randNumber =  new Random().Next(maxValue: MaxBoundary, minValue: MinBoundary);
            var counter = 1;
            while (passedGuessings.Contains(randNumber))
            {
                if (counter < 6)
                {
                    counter++;
                    randNumber = new Random().Next(maxValue: MaxBoundary, minValue: MinBoundary);
                }
            }
            passedGuessings.Add(randNumber);
            return randNumber;
        }
    }
}
