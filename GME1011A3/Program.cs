using System;
using System.Collections.Generic;

namespace GME1011A3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();

            Console.WriteLine("========================================");
            Console.WriteLine("   Welcome to the Epic Hero Battle!!   ");
            Console.WriteLine("========================================\n");

            
            Console.Write("Enter your hero's name: ");
            string heroName = Console.ReadLine();
            if (heroName == null || heroName.Trim() == "")
                heroName = "unnamed hero";

            int heroHealth = 0;
            Console.Write("Enter your hero's health (1-100): ");
            while (!int.TryParse(Console.ReadLine(), out heroHealth) || heroHealth < 1 || heroHealth > 100)
            {
                Console.Write("Please enter a number between 1 and 100: ");
            }

            int heroStrength = 0;
            Console.Write("Enter your hero's strength (1-10): ");
            while (!int.TryParse(Console.ReadLine(), out heroStrength) || heroStrength < 1 || heroStrength > 10)
            {
                Console.Write("Please enter a number between 1 and 10: ");
            }

            int numBaddies = 0;
            Console.Write("How many enemies do you want to face? (1-10): ");
            while (!int.TryParse(Console.ReadLine(), out numBaddies) || numBaddies < 1 || numBaddies > 10)
            {
                Console.Write("Please enter a number between 1 and 10: ");
            }

            Fighter hero = new Fighter(heroHealth, heroName, heroStrength);
            Console.WriteLine("\nHere is our heroic hero: " + hero);
            Console.WriteLine();

            int numAliveBaddies = numBaddies;

            List<Minion> baddies = new List<Minion>();
            for (int i = 0; i < numBaddies; i++)
            {
                int roll = rng.Next(1, 4);

                if (roll == 1)
                {
                    baddies.Add(new Goblin(rng.Next(30, 35), rng.Next(1, 5), rng.Next(1, 10)));
                }
                else if (roll == 2)
                {
                    baddies.Add(new Skellie(rng.Next(25, 31), 0));
                }
                else
                {
                    baddies.Add(new Vampire(rng.Next(28, 35), rng.Next(1, 4), rng.Next(3, 8)));
                }
            }

            Console.WriteLine("Here are the baddies you'll be fighting:");
            for (int i = 0; i < baddies.Count; i++)
            {
                Console.WriteLine("  Enemy #" + (i + 1) + ": " + baddies[i]);
            }

            Console.WriteLine("\n\nLet the EPIC battle begin!!");
            Console.WriteLine("----------------------------\n");

            while (numAliveBaddies > 0 && !hero.isDead())
            {
                
                int indexOfEnemy = 0;
                while (baddies[indexOfEnemy].isDead())
                {
                    indexOfEnemy++;
                }

                Console.WriteLine(hero.GetName() + " is facing enemy #" + (indexOfEnemy + 1) +
                    " of " + numBaddies + " -- it's a " + baddies[indexOfEnemy].GetType().Name + "!");

                int heroDamage = 0;
                int specialRoll = rng.Next(1, 4);

                if (specialRoll == 1 && hero.GetStrength() > 0)
                {
                    heroDamage = hero.Berserk();
                    Console.WriteLine("  >> " + hero.GetName() + " goes BERSERK!! Deals " + heroDamage + " damage!");
                }
                else
                {
                    if (specialRoll == 1 && hero.GetStrength() <= 0)
                    {
                        Console.WriteLine("  (Out of strength! Can't go berserk - using regular attack)");
                    }
                    heroDamage = hero.DealDamage();
                    Console.WriteLine("  " + hero.GetName() + " attacks for " + heroDamage + " damage.");
                }

                baddies[indexOfEnemy].TakeDamage(heroDamage);

                if (baddies[indexOfEnemy].isDead())
                {
                    numAliveBaddies--;
                    Console.WriteLine("  Enemy #" + (indexOfEnemy + 1) + " has been defeated!!");
                    
                    if (!hero.isDead() && numAliveBaddies > 0)
                    {
                        int healAmount = rng.Next(3, 8);
                        hero.Heal(healAmount);
                        Console.WriteLine("  (Victory rush! " + hero.GetName() + " recovers " + healAmount + " health.)");
                    }
                }
                else
                {
                    int baddieDamage = 0;
                    int minionSpecialRoll = rng.Next(1, 4);

                    if (minionSpecialRoll == 1)
                    {
                        if (baddies[indexOfEnemy] is Goblin goblin)
                        {
                            baddieDamage = goblin.GoblinBite();
                        }
                        else if (baddies[indexOfEnemy] is Skellie skellie)
                        {
                            baddieDamage = skellie.SkellieRattle();
                        }
                        else if (baddies[indexOfEnemy] is Vampire vampire)
                        {
                            baddieDamage = vampire.BloodDrain();
                        }
                        else
                        {
                            baddieDamage = baddies[indexOfEnemy].DealDamage();
                        }
                    }
                    else
                    {
                        baddieDamage = baddies[indexOfEnemy].DealDamage();
                        Console.WriteLine("  Enemy #" + (indexOfEnemy + 1) + " attacks for " + baddieDamage + " damage!");
                    }

                    hero.TakeDamage(baddieDamage);

                    Console.WriteLine("  " + hero.GetName() + " has " + hero.GetHealth() + " health remaining.");

                    if (hero.isDead())
                    {
                        Console.WriteLine("\n  " + hero.GetName() + " has fallen. The darkness wins...");
                    }
                }

                Console.WriteLine("-----------------------------------------");
            }

            if (!hero.isDead())
            {
                Console.WriteLine("\n  All enemies have been defeated!!");
                Console.WriteLine("  " + hero.GetName() + " is VICTORIOUS with " + hero.GetHealth() + " health remaining!");
                Console.WriteLine("\n  *** GLORY TO THE HERO!! ***");
            }
            else
            {
                Console.WriteLine("\n  Game over. Better luck next time...");
            }
        }
    }
}
