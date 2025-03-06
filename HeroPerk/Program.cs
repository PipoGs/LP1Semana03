using System;
using HeroPerks;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string perk = args[0].Trim().ToLower();

            Perks playerPerks = 0;

            int countW = 0;
            int countA = 0;
            int countS = 0;
            int countD = 0;

            foreach (char c in perk)
            {
                if (c != 'w' && c != 'a' && c != 's' && c != 'd')
                {
                    Console.WriteLine("!Unknown perk!");
                    return;
                }
                switch (c)
                {
                    case 'w': countW++; break;
                    case 'a': countA++; break;
                    case 's': countS++; break;
                    case 'd': countD++; break;
                }
            }
            if (countW % 2 != 0) playerPerks |= Perks.WarpShift;
            if (countA % 2 != 0) playerPerks |= Perks.AutoHeal;
            if (countS % 2 != 0) playerPerks |= Perks.Stealth;
            if (countD % 2 != 0) playerPerks |= Perks.DoubleJump;

            if (playerPerks != 0)
            {
                Console.WriteLine(playerPerks);
                if ((playerPerks & Perks.Stealth) != 0 && (playerPerks & Perks.DoubleJump) != 0)
                {
                    Console.WriteLine("!Silent Jumper!");
                }
                if ((playerPerks & Perks.AutoHeal) == 0)
                {
                    Console.WriteLine("!Not gonna make it!");
                }
            }
            else
            {
                Console.WriteLine("!No perks at all!");
                Console.WriteLine("!Not gonna make it!");
            }
        }
    }
}