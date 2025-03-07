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
            EnemyType enemy = Enum.Parse<EnemyType>(args[0]);
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
            Weapons weapon = 0;
            foreach (string str in args)
            {
                if (str == "SilverBullet")
                {
                    weapon ^= Weapons.SilverBullet;
                }
                
                if (str == "Garlic")
                {
                    weapon ^= Weapons.Garlic;
                }

                if (str == "HolyWater")
                {
                    weapon ^= Weapons.HolyWater;
                }
            }
        }

        /// <summary>
        /// Is the enemy killed with any of the weapons?
        /// </summary>
        /// <param name="enemy">The enemy we're trying to kill.</param>
        /// <param name="weapons">The weapons used to try and kill the enemy.</param>
        /// <returns>Wether the enemy was killed or not.</returns>
        private static bool WeaponsKillEnemy(EnemyType enemy, Weapons weapons)
        {
            bool dies = false;
            if ((enemy == EnemyType.Zombie && weapons == Weapons.SilverBullet) ||
                (enemy == EnemyType.Vampire && weapons == Weapons.Garlic) ||
                (enemy == EnemyType.Vampire && weapons == Weapons.HolyWater) ||
                (enemy == EnemyType.Werewolf && weapons == Weapons.SilverBullet) ||
                (enemy == EnemyType.Ghost && weapons == Weapons.HolyWater))
            {
                return WeaponsKillEnemy(dies = true);
            }

            if 
        }

        /// <summary>
        /// Display information on wether the enemy was killed or not.
        /// </summary>
        /// <param name="enemy">The enemy we're trying to kill.</param>
        private static void DisplayResult(EnemyType enemy, bool survives)
        {
            // ////////// //
            // CHANGE ME! //
            // ////////// //
        }
    }
}
