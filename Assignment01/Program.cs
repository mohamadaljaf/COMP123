///------------------------------------------------------------------------------------------
///   Project:              Assignment 01 - The Hero Class
/// 
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
///                         2015-01-30: Polished the program by adding an unlimited fight mode
///------------------------------------------------------------------------------------------
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

            Console.WriteLine("Press the spacebar to hit the target. Press any other key to quit you coward.");

            // lets the user fight as long as they want
            do
            {
                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    hero.fight();
                }
                else
                {
                    break;
                }
            } while (true);

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
