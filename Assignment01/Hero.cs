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
        // makes the hero fight. If a hit lands then the damage will be shown
        public void fight()
        {
            if (hitAttempt() == true)
            {
                Console.WriteLine("Target hit for {0} damage!", hitDamage());
            }
            else
            {
                Console.Write("Missed! ");

                switch (randomNum.Next(1, 6))
                {
                    case 1:
                        Console.WriteLine("What kinda hero misses?");
                        break;
                    case 2:
                        Console.WriteLine("You only missed by a 100 km.");
                        break;
                    case 3:
                        Console.WriteLine("Consider a change in career, something that doesn't require coordination.");
                        break;
                    case 4:
                        Console.WriteLine("Are you really a hero or are you just wearing a costume?");
                        break;
                    case 5:
                        Console.WriteLine("Did you hit by kryptonite recently?");
                        break;
                    default:
                        Console.WriteLine("How did you break my program?!");
                        break;
                }
                
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
            strength = randomNum.Next(1, 101);
            speed = randomNum.Next(1, 101);
            health = randomNum.Next(1, 101);
        }

        // randomly determines if the hero hits, chance of hitting is 20%
        private bool hitAttempt()
        {
            if (randomNum.Next(1, 6) == 1)
            {
                return true;
            }

            return false;
        }

        // calculates the damage the hero causes to the target on a hit
        private int hitDamage()
        {
            return randomNum.Next(1, 7) * this.strength;
        }
    }
}
