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
        private Random randomNum;

        // CONSTRUCTOR ********************/
        public Hero(string name)
        {
            this.name = name;
            randomNum = new Random(); // prevents random numbers from not being so random
            generateAbilities();
        }

        // PUBLIC Methods ********************/
        public void fight()
        {
            if (hitAttempt() == true)
            {
                Console.WriteLine("Target hit for {0} damage!", hitDamage());
            }
            else
            {
                Console.WriteLine("Missed! This goat is kinda baaaaaaaad.");
            }
        }

        // displays the hero's ability scores to the console
        public void show()
        {
            Console.WriteLine("The hero {0} has: \n\t{1} strength \n\t{2} speed \n\t{3} health.", this.name, this.strength, this.speed, this.health);
        }

        // PRIVATE Methods ********************/
        // randomly generates the ability numbers for strength, speed, and health between 1 and 100
        private void generateAbilities()
        {
            strength = randomNum.Next(1, 100);
            speed = randomNum.Next(1, 100);
            health = randomNum.Next(1, 100);
        }

        // randomly determines if the hero hits, chance of hitting is 20%
        private bool hitAttempt()
        {
            if (randomNum.Next(1, 5) == 1)
            {
                return true;
            }

            return false;
        }

        // calculates the damage the hero causes to the target on a hit
        private int hitDamage()
        {
            return randomNum.Next(1, 6) * this.strength;
        }
    }
}
