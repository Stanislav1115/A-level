using System;

namespace DZ_11_Grishchenko.Players
{
    public class UsualPlayer : BasePlayer
    {
        protected override string PlayerType => "Usual Player";

        public override int GuessNumber()
        {
            return new Random().Next(maxValue: MaxBoundary, minValue: MinBoundary);
        }
    }
}
