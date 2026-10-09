using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGStore
{
    public class Weapon :IItem
    {
        public string Name { get; }
        public int Price { get; }
        public int Damage { get; set; }
        public Weapon(string name, int price, int damage)
        {
            Name = name;
            Price = price;
            Damage = damage;
        }
    }
}
