using System;

namespace GME1011A3
{
    internal class Skellie : Minion
    {
        public Skellie(int health, int armour) : base(health, armour)
        {
            _armour = 0;
        }

        public override void TakeDamage(int damage)
        {
            _health -= damage / 2;
        }

        public override int DealDamage()
        {
            Random rng = new Random();
            return rng.Next(2, 8);
        }

        public int SkellieRattle()
        {
            Console.WriteLine("  *** Spooky rattling!! The skellie shakes its bones! ***");
            Random rng = new Random();
            return rng.Next(7, 15);
        }

        public override string ToString()
        {
            return "Skellie[" + base.ToString() + "]";
        }
    }
}
