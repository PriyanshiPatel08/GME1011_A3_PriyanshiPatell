using System;

namespace GME1011A3
{
    internal class Healer : Hero
    {
        private int dexterity;

        public Healer() : base()
        {
            this.dexterity = 5;
        }

        public Healer(int health, string name, int dexterity) : base(health, name)
        {
            if (this.health > 80)
                this.health = 80;

            if (dexterity < 0 || dexterity > 10)
                dexterity = 5;

            this.dexterity = dexterity;
        }

        public override int DealDamage()
        {
            Random rng = new Random();
            return rng.Next(3, 9);
        }

        public override void Heal(int health)
        {
            this.health += health;
            if (this.health > 80) this.health = 80;
        }

        public int GetDexterity() { return this.dexterity; }

        public void AddDexterity() { if (this.dexterity <= 9) dexterity++; }

        public int HealPartyMember()
        {
            if (dexterity > 0)
            {
                dexterity--;
                Random rng = new Random();
                return rng.Next(20, 35);
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return "Healer[" + base.ToString() + ", dexterity: " + this.dexterity + "]";
        }
    }
}
