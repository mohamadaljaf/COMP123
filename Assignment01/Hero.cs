using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Hero
    {
        // PUBLIC Properties ********************/
        public string name;

        // PRIVATE Properties ********************/
        private int strength, speed, health;

        // CONSTRUCTOR ********************/
        public Hero(string name)
        {
            this.name = name;
        }

        // PUBLIC Methods ********************/
        public void fight()
        {

        }

        // PRIVATE Methods ********************/
        // randomly generates the ability numbers for strength, speed, and health between 1 and 100
        private void generateAbilities()
        {
            Random rnd = new Random();

            strength = rnd.Next(1, 100);
            speed = rnd.Next(1, 100);
            health = rnd.Next(1, 100);
        }

        // randomly determines if the hero hits, chance of hitting is 20%
        private bool hitAttempt()
        {
            Random rnd = new Random();

            if (rnd.Next(1, 5) == 1)
            {
                return true;
            }

            return false;
        }

        // calculates the damage the hero causes to the target on a hit
        private int hitDamage()
        {
            Random rnd = new Random();

            return rnd.Next(1, 6) * this.strength;
        }
    }
}
