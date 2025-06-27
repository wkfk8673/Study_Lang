using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HighLowGame
{
    static class HiLoGame
    {
        public const int MAXIMUM = 10;
        public static Random random = new Random();

        private static int currNumber = random.Next(1, MAXIMUM + 1);
        private static int pot = 10;
        internal static void Guess(bool higher)
        {
            int num = random.Next(1, MAXIMUM + 1);

            if (higher && num >= currNumber || !higher && num < currNumber)
            {
                Console.WriteLine("You guessed right!");
                pot++;
            }
            else
            {
                Console.WriteLine("Bad luck, you guessed wrong!");
                pot--;
            }
            currNumber = num;
            Console.WriteLine($"The current number is {currNumber}");
        }

        public static int GetPot()
        {
            return pot;
        }


        public static void Hint()
        {
            int half = MAXIMUM / 2;
            if (currNumber >= half)
            {
                Console.WriteLine($"The number is at least {half}");
            }
            else
            {
                Console.WriteLine($"The number is at most {half}");
            }
            pot--;
        }
    }
}
