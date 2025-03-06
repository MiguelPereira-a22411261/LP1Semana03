using System;

namespace HeroPerk
{
    [Flags]
    enum Perks
        {
            WarpShift = 1 << 0 ,
            Stealth = 1 << 0,
            AutoHeal = 1 << 0,
            DoubleJump = 1 << 0
        }
    public class Program
    {
        private static void Main(string[] args)
        {
            Perks perks = 0;
            Perks silJ = Perks.Stealth | Perks.DoubleJump;
            bool unkPerk = false;
            string input = args[0];

            foreach (char chr in input)
            {
                if (chr == 'w')
                {
                    perks ^= Perks.WarpShift;
                }
                else if (chr == 'a')
                {
                    perks ^= Perks.AutoHeal;
                }
                else if (chr == 's')
                {
                    perks ^= Perks.Stealth;
                }
                else if (chr == 'd')
                {
                    perks ^= Perks.DoubleJump;
                }
                else
                {
                    unkPerk = true;
                    break;
                }
            }
        }
    }
}
