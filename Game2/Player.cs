using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    class Player 
    {
        public int id;
        public string name;
        public int level;
        public int experience;
        public int health;
        public int maxHealth;
        public List<Item> inventory;
        public int gold;


        public Player(string name, List<Item> inventory, int gold = 15, int maxHealth = 20, int health = 20, int experience = 0, int level = 1, int id = 1)
        {
            this.id = id;
            this.name = name;
            this.level = level;
            this.experience = experience;
            this.health = health;
            this.maxHealth = maxHealth;
            this.inventory = inventory;
            this.gold = gold;

        }


        public void AddItemToInventory(Item item)
        {
            inventory.Add(item);
        }

        public void ShowInventory()
        {
            if (inventory == null || inventory.Count == 0)
            {
                Console.WriteLine("Your inventory is empty.");
                return;
            }

            Console.WriteLine("Your inventory contains:");
            foreach (var item in inventory)
            {
                Console.WriteLine($"- {item.name} - Damage: {item.damageMin} - {item.damageMax}");
            }
        }

        public void ShowStats()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Experience: {experience}");
            Console.WriteLine($"Health: {health}/{maxHealth}");
            Console.WriteLine($"Gold: {gold}");
        }

        















    }
}    

