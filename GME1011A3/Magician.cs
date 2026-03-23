using System;

namespace GME1011A3
{
    internal class Magician : Hero
    {
        private int mana;

        public Magician() : base()
        {
            this.mana = 5;
        }

        public Magician(int health, string name, int mana) : base(health, name)
        {
            if (this.health > 50)
                this.health = 50;

            if (mana < 0 || mana > 10)
                mana = 5;

            this.mana = mana;
        }

        public override int DealDamage()
        {
            Random rng = new Random();
            return rng.Next(1, 15);
        }

        public override void Heal(int health)
        {
            this.health += health;
            if (this.health > 50) this.health = 50;
        }

        public int GetMana() { return this.mana; }

        public void AddMana() { if (this.mana <= 9) mana++; }

        public int LightningStrike()
        {
            if (mana > 1)
            {
                mana -= 2;
                Random rng = new Random();
                return rng.Next(80, 100);
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return "Magician[" + base.ToString() + ", mana: " + this.mana + "]";
        }
    }
}
