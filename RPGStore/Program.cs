using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGStore
{
    public interface IItem
    {
        string Name { get; }
        int Price { get; }
    }
    internal class Program
    {
        static List<IItem> Store = new List<IItem>();
        static List<Player> Players = new List<Player>();
        static void Main(string[] args)
        {
            Store.Add(new Weapon("Katana", 2000, 20));
            Store.Add(new Weapon("LongSword", 5000, 35));
            Store.Add(new Armory("Shield", 1500, 10));
            Store.Add(new Armory("Helmet", 1000, 5));
            Console.WriteLine("Please write your nickname");
            string writtenNick = Console.ReadLine();
            Player CurrentPlayer = Players.Find(p => p.nickname == writtenNick);
            if (CurrentPlayer == null)
            {
                Console.WriteLine("Your nickname is not on the system, creating new player...\n");
                CurrentPlayer = new Player(writtenNick);
                Players.Add(CurrentPlayer);
            }
            else
            {
                Console.WriteLine($"Welcome back {writtenNick}");
            }
            while (true)
            {
                    Console.WriteLine("Choose What You Want To Do \n\n" +
                        "[1] List The Items In Store\n" +
                        "[2] Buy An Item\n" +
                        "[3] See Your Inventory and Balance\n" +
                        "[4] Exit");
                int Selection = Convert.ToInt16(Console.ReadLine());
                if(Selection == 1)
                {
                    foreach (var item in Store)
                    {
                        Console.WriteLine($"\nItem: {item.Name} | Price: {item.Price}\n");
                    }
                }
                else if(Selection == 2)
                {
                    Console.WriteLine("Select The Item You Want To Buy:\n");
                    foreach (var item in Store)
                    {
                        Console.WriteLine($"Item: {item.Name} | Price: {item.Price}");
                    }
                    int ItemSelection = Convert.ToInt16(Console.ReadLine());
                    int ArrayIndex = ItemSelection - 1;
                    IItem SelectedItem = Store[ArrayIndex];
                    if(CurrentPlayer.Budget < SelectedItem.Price)
                    {
                        Console.WriteLine("Your budget is not enough to buy this item!!!");
                    }
                    else
                    {
                        Console.WriteLine("You succesfully bought the item");
                        CurrentPlayer.Inventory.Add(SelectedItem);
                        CurrentPlayer.Budget -= SelectedItem.Price;
                    }
                }
                else if(Selection == 3)
                {
                    Console.WriteLine($"\nYour items:");
                    foreach(var item in CurrentPlayer.Inventory)
                    {
                        Console.WriteLine($"{item.Name}, ");
                    }
                    Console.WriteLine($"Your budget is : {CurrentPlayer.Budget}");
                }
                else if(Selection == 4)
                {
                    Console.WriteLine("Çıkış yapılıyor...");
                    Environment.Exit(0);
                }
            }
        }
    }
}
