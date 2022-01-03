using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgifter
{
    class Player
    {

            public static string name;
            public static int health, strength, luck;
            public void SetPlayer(string name_player)
            {
                name = name_player;
                Random r = new Random();
                health = r.Next(5, 11);
                strength = r.Next(5, 11);
                luck = r.Next(5, 11);
            }
            public void PrintPlayer()
            {
                Console.WriteLine("Player is " + name + " , values of health is " + health + " , strength is " + strength + " , luck is " + luck);
            }
        }
    
}
