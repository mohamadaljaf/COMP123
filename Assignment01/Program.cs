///-----------------------------------------------------------------
///   Author:               Mohamad Al-Jaf   
///   
///   Date last modified:   Janurary 30, 2015
///   
///   Program description:  A program that creates a hero class and makes the hero fight
///                         while displaying the damage done if the hit lands on the target
///                         
///   Revision History:     2015-01-20: Added a hero class
///                         2015-01-25: Completed the hero class
///                         2015-01-30: Completed the main method and tested the program
///-----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Super Goat");
            hero.show();

            for (int i = 0; i < 20; i++)
            {
                hero.fight();
            }
        }
    }
}
