using System;

namespace GME1011A3
{
    internal class Hero
    {
        protected int health;
        private string name;

        public Hero()
        {
            health = 100;
            name = "unnamed hero";
        }

        public Hero(int health, string name)
        {
            if (health < 0 || health > 100) { health = 100; }
            this.health = health;
            if (name == "") { name = "unnamed hero"; }
            this.name = name;
        }

        public int GetHealth() { return health; }
        public string GetName() { return name; }

        public virtual int DealDamage() { return 10; }

        public virtual void Heal(int health)
        {
            this.health += health;
            if (this.health > 100) this.health = 100;
        }

        public void TakeDamage(int damage)
        {
            this.health -= damage;
            if (this.health < 0) { this.health = 0; }
        }

        public bool isDead() { return health <= 0; }

        public override string ToString()
        {
            return "Hero[" + health + ", " + name + "]";
        }
    }
}
