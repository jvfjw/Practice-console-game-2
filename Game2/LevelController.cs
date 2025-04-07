using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    class LevelController 
    {
        public Player player;

        
        public LevelController(Player player)
        {
            this.player = player;
        }
        public Player LevelUp(Player player)
        {
            if (player.experience >= 100)
            {
                player.level++;
                player.experience -= 100;
                Console.WriteLine($"Congratulations! You've leveled up to level {player.level}!");
                return player;
            }
            else
            {
                Console.WriteLine("You need more experience to level up.");
                return player;
            }
        }

        public Player addXp(Player player, int xp)
        {
            player.experience += xp;
            Console.WriteLine($"You gained {xp} experience points!");
            return player;
        }
    }
}