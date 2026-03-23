using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GME1011A3
{
    internal class Archer : Hero
    {
        private int accuracy;

        public Archer() : base()
        {
            this.accuracy = 6;
        }
        public Archer(int health, string name, int accuracy) : base(health, name)
        {
                if (health > 90)
            {
                this.health = 90;
            }

            if (accuracy < 0 || accuracy > 10)
            {
                accuracy = 6;
            }

            this.accuracy = accuracy;
        }

        public override int DealDamage()
        {
            Random rng = new Random();
            return rng.Next(6, 12) + (accuracy / 2);
        }
        
        public int Snipe()
        {
            if (accuracy > 1)
            {
                accuracy -= 2;
                Random rng = new Random();
                return rng.Next(20, 30);
            }
            else
            {
                return 0;
            }
        }

        public int GetAccuracy()
        {
            return this.accuracy;
        }
        public void AddAccuracy()
        {
            if (accuracy <= 9)
                accuracy++;
        }
        public override string ToString()
        {
            return "Archer[" + base.ToString() + ", accuracy: " + this.accuracy + "]";
        }
    }
}
