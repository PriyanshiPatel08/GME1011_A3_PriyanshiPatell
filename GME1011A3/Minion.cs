using System;

namespace GME1011A3
{
    internal class Minion
    {
        protected int _health;
        protected int _armour;

        public Minion(int health, int armour)
        {
            if (health <= 0 || health > 35)
                health = 35;
            _health = health;

            if (armour < 0 || armour > 5)
                armour = 3;
            _armour = armour;
        }

        public int GetHealth() { return _health; }
        public int GetArmour() { return _armour; }

        public virtual void TakeDamage(int damage) { _health -= (damage - _armour); }

        public virtual int DealDamage() { return 5; }

        public bool isDead() { return _health <= 0; }

        public override string ToString()
        {
            return "Minion[" + _health + "," + _armour + "]";
        }
    }
}
