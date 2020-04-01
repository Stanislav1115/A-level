using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_11_Grishchenko.Players
{
    class UberPlayer : BasePlayer
    {
        private int currentGuess = MinBoundary;
        protected override string PlayerType => "Uber Player";
        public override int GuessNumber()
        {
            return currentGuess++;
        }
    }
}
