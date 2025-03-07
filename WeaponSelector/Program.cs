using System;

namespace WeaponSelector
{
    public class Program
    {
        /// <summary>
        /// Main method. Do not change it!
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        private static void Main(string[] args)
        {
            // DO NOT CHANGE THIS METHOD!
            EnemyType enemy = Enum.Parse<EnemyType>(args[0], true);
            Weapons weapon = ParseWeapons(args);
            bool dies = WeaponsKillEnemy(enemy, weapon);
            DisplayResult(enemy, dies);
            // DO NOT CHANGE THIS METHOD!
        }

        /// <summary>
        /// Parse the command line arguments to get the weapon.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>The weapons.</returns>
        private static Weapons ParseWeapons(string[] args)
        {
            Weapons weapons = 0;
            foreach (string i in args)
            {
                if (i == "SilverBullet")
                {
                    weapons |= Weapons.SilverBullet;
                }
                else if (i == "Garlic")
                {
                    weapons |= Weapons.Garlic;
                }
                else if (i == "HolyWater")
                {
                    weapons |= Weapons.HolyWater;
                }
            }
            return weapons;
        }

        /// <summary>
        /// Is the enemy killed with any of the weapons?
        /// </summary>
        /// <param name="enemy">The enemy we're trying to kill.</param>
        /// <param name="weapons">The weapons used to try and kill the enemy.</param>
        /// <returns>Whether the enemy was killed or not.</returns>
        private static bool WeaponsKillEnemy(EnemyType enemy, Weapons weapons)
        {

            if (enemy == EnemyType.Vampire)
            {
                if ((weapons & Weapons.Garlic) == Weapons.Garlic)
                {
                    return true;
                }
            }
            if (enemy == EnemyType.Vampire)
            {
                if ((weapons & Weapons.HolyWater) == Weapons.HolyWater)
                {
                    return true;
                }
            }
            else if (enemy == EnemyType.Werewolf)
            {
                if ((weapons & Weapons.SilverBullet) == Weapons.SilverBullet)
                {
                    return true;
                }

            }
            else if (enemy == EnemyType.Zombie)
            {
                if ((weapons & Weapons.SilverBullet) == Weapons.SilverBullet)
                {
                    return true;
                }
            }
            return false;


        }

        /// <summary>
        /// Display information on whether the enemy was killed or not.
        /// </summary>
        /// <param name="enemy">The enemy we're trying to kill.</param>
        /// <param name="survives">Whether the enemy was killed or not.</param>
        private static void DisplayResult(EnemyType enemy, bool survives)
        {
            if (survives)
            {
                Console.WriteLine($"{enemy} dies");
            }
            else
            {
                Console.WriteLine($"{enemy} survives");
            }
        }
    }
}
