using System;

namespace GME1011A3
{
    internal class Vampire : Minion
    {
        private int _bloodlust;

        public Vampire(int health, int armour, int bloodlust) : base(health, armour)
        {
            if (bloodlust < 1 || bloodlust > 10)
                bloodlust = 5;
            _bloodlust = bloodlust;
        }

        public override void TakeDamage(int damage)
        {
            int actualDamage = (int)(damage * 0.75);
            _health -= (actualDamage - _armour);
            if (_health < 0) _health = 0;
        }

        public override int DealDamage()
        {
            Random rng = new Random();
            return rng.Next(4, 10);
        }

        public int BloodDrain()
        {
            Console.WriteLine("  *** The vampire DRAINS your life force!! ***");
            Random rng = new Random();
            int drain = _bloodlust * rng.Next(2, 4);

            _health += drain / 2;
            if (_health > 35) _health = 35; // cap at max

            Console.WriteLine("  (The vampire heals " + (drain / 2) + " health from the drain!)");
            return drain;
        }

        public int GetBloodlust() { return _bloodlust; }

        public override string ToString()
        {
            return "Vampire[" + base.ToString() + ", bloodlust: " + _bloodlust + "]";
        }
    }
}
