using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    class Item
    {
        public int id;
        public string name;
        public string description;
        public int value;
        public int price;
        public int levelRequirement;
        public int damageMin;
        public int damageMax;

        public Item(int id, string name, string description, int value, int price, int levelRequirement, int damageMin, int damageMax)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.value = value;
            this.price = price;
            this.levelRequirement = levelRequirement;
            this.damageMin = damageMin;
            this.damageMax = damageMax;
        }

        
        public static Item scrapGun = new Item(1, "Scrap Gun", "A gun made from scrap metal.", 5, 10, 1, 1, 6);
        public static Item scrapKnife = new Item(2, "Scrap Knife", "A knife made from scrap metal.", 3, 5, 1, 2, 4);
        

        public static List<Item> initialItems = new List<Item>
        {
            scrapGun,
            scrapKnife
        };
    }
}
