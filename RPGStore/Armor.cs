using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGStore
{
    public class Armory : IItem
    {
        public string Name { get; }
        public int Price { get; }
        public int Armor { get; set; }

        public Armory(string name, int price, int armor)
        {
            Name = name;
            Price = price;
            Armor = armor;
        }
    }
}
