using DZ_11_Grishchenko.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_11_Grishchenko
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numberOfAttempts = 100;
            var basketWeight = new Random().Next(40, 140);
            var playersList = new List<BasePlayer>()
            {
                new GamePlayer(),
                new UberPlayer(),
                new UsualPlayer()
            };
            for (int i = 0; i < numberOfAttempts - playersList.Count - 1; i += playersList.Count)
            {
                foreach (var player in playersList)
                {
                    var guessedNumber = player.GuessNumber();
                    player.PrintCurrentResult(guessedNumber);
                    if (guessedNumber == basketWeight)
                    {
                        Console.WriteLine(player.ToString());
                    }
                }
                Console.WriteLine("----------------------------------------------");
            }
        }
    }
}

