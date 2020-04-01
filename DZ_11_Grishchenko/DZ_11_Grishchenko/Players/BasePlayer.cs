using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_11_Grishchenko.Players
{
    public abstract class BasePlayer
    {
        protected const int MinBoundary = 40;

        protected const int MaxBoundary = 140;
        protected abstract string PlayerType { get; }

        public abstract int GuessNumber();
        public void PrintCurrentResult(int guessedNumber)
        {

            Console.WriteLine($"{PlayerType} guessedl {guessedNumber}");
        }
        public override string ToString()
        {
            return $"{PlayerType} выиграл игру";
        }
    }
}
