using System;

namespace GME1011A3
{
    internal class Fighter : Hero
    {
        private int strength;

        public Fighter() : base()
        {
            this.strength = 5;
        }

        public Fighter(int health, string name, int strength) : base(health, name)
        {
            if (strength < 0 || strength > 10)
                strength = 5;

            this.strength = strength;
        }

        public override int DealDamage()
        {
            Random rng = new Random();
            return rng.Next(8, 15);
        }

        public int GetStrength() { return this.strength; }

        public void AddStrength() { if (this.strength <= 9) strength++; }

        public int Berserk()
        {
            if (strength > 0)
            {
                strength--;
                Random rng = new Random();
                return rng.Next(10, 20) * strength;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return "Fighter[" + base.ToString() + ", strength: " + this.strength + "]";
        }
    }
}
