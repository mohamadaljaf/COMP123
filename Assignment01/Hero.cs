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

        // PRIVATE Methods ********************/
        // randomly generates the ability numbers for strength, speed, and health
        private void generateAbilities()
        {
            Random rnd = new Random();

            strength = rnd.Next(1, 100);
            speed = rnd.Next(1, 100);
            health = rnd.Next(1, 100);
        }
    }
}
