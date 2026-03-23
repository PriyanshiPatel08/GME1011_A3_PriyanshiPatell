using System;

namespace GME1011A3
{
    internal class Goblin : Minion
    {
        private int _dexterity;

        public Goblin(int health, int armour, int dexterity) : base(health, armour)
        {
            if (dexterity < 0 || dexterity > 10)
                dexterity = 5;
            _dexterity = dexterity;
        }

        public override void TakeDamage(int damage)
        {
            Random rng = new Random();
            if (rng.Next(1, 15) < _dexterity)
            {
                Console.WriteLine("**Goblin-dodge, sneaky**");
            }
            else
            {
                _health -= (damage - _armour);
            }
        }

        public override int DealDamage()
        {
            Random rng = new Random();
            return rng.Next(1, _dexterity) + 1;
        }

        public int GoblinBite()
        {
            Console.WriteLine("  *** CHOMP! The goblin bites!! ***");
            Random rng = new Random();
            return _dexterity * rng.Next(1, 3);
        }

        public override string ToString()
        {
            return "Goblin[" + base.ToString() + ", dex: " + _dexterity + "]";
        }
    }
}
