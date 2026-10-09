using System;
using System.Collections.Generic;

namespace RPGStore
{
    internal class Player
    {
        public string nickname { get; set; }
        public List<IItem> Inventory = new List<IItem>();
        private int budget;

        public int Budget
        {
            get { return budget; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Warning: Budget Cannot be negative");
                }
                else
                {
                    budget = value;
                }
            }
        }

        public Player(string Nickname)
        {
            Nickname = nickname;
            Budget = 6000;
        }
    }
}