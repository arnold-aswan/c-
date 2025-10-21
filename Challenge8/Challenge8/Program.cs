// CHALLENGE 8
/*
🧩 Bonus “Object” Challenge (250 XP)
Concepts: object composition, enums.
Create a small RPG inventory system:
Class Item with properties Name, ItemType, and Value
Enum ItemType with values like Weapon, Armor, Potion
Class Player with Name, Gold, and a List<Item> Inventory
Methods to AddItem(), RemoveItem(), and PrintInventory()
 */
namespace Challenge8
{
    public enum ItemType
    {
        Weapon,
        Armor,
        Potion,
        Misc
    };
    public class Item
    {
        public string Name { get; }
        public ItemType Type { get; }
        public int Value { get; }

        public Item(string name, ItemType type, int value)
        {
            Name = name;
            Type = type;
            Value = value;
        }
        public string Describe() => $"{Name} ({Type}) - {Value} gold";
    }
    public class ItemCatalog
    {
        public static List<Item> AvailableItems { get; } = new List<Item>
        {
            new Item("Iron Sword", ItemType.Weapon, 50),
            new Item("Steel Dagger", ItemType.Weapon, 35),
            new Item("Longbow", ItemType.Weapon, 60),

            new Item("Leather Armor", ItemType.Armor, 45),
            new Item("Iron Shield", ItemType.Armor, 40),
            new Item("Mage Robe", ItemType.Armor, 55),

            new Item("Healing Potion", ItemType.Potion, 15),
            new Item("Mana Potion", ItemType.Potion, 20),
            new Item("Antidote", ItemType.Potion, 10),

            new Item("Torch", ItemType.Misc, 5),
            new Item("LockPick", ItemType.Misc, 8),
            new Item("Rope", ItemType.Misc, 12)
        };
        public void ListAvailableItems()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            foreach(Item item in AvailableItems)
                Console.WriteLine($"{AvailableItems.IndexOf(item) +1}. {item.Describe()} ");
            Console.ResetColor();
        }
        public int CatalogCount => AvailableItems.Count;
        public List<Item> CatalogList => AvailableItems;
    }
    public class Player
    {
        public string Name { get; set; }
        public int Gold { get; set; }
        public List<Item> Inventory { get; set; }

        public Player()
        {
            Console.Write("Enter your name: ");
            Name = Console.ReadLine();
            Console.WriteLine($"Welcome {Name}! You start with 100 gold.");
            Gold = 100;
            Inventory = new List<Item>();
        }

        public void AddItem(Item item)
        {
            if (Gold >= item.Value)
            {
                Inventory.Add(item);
                Gold -= item.Value;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You dont have enough gold to add this item to inventory!");
                Console.ResetColor();
            }
        } 
            
        public void RemoveItem(Item item) => Inventory.Remove(item);
        private void TotalInventoryValue()
        {
            int gold = 0;
            foreach (Item item in Inventory)
                gold += item.Value;
            Console.WriteLine($"Total value: {gold} gold");
        }
        public void PrintInventory()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("________ INVENTORY ________");
            foreach (Item item in Inventory)
                Console.WriteLine($"{Inventory.IndexOf(item) + 1}. {item.Describe()}");
            TotalInventoryValue();
            Console.ResetColor();
        }
    }

    public class Program
    {
        static void Main()
        {
            ItemCatalog catalog = new ItemCatalog();
            Player player = new Player();

            bool running = true;
            
            while (running)
            {
                Console.WriteLine("What would you like to do? ");
                Console.WriteLine($"1. List & Add available items \n2. Remove item \n3. View inventory \n4. Exit \n");
                int? action = int.Parse(Console.ReadLine());
                
                switch (action)
                {
                    case 1:
                        catalog.ListAvailableItems();
                        Console.WriteLine("What would you like to add to Inventory? ");
                        int choice = int.Parse(Console.ReadLine());
                        if (choice > 0 && choice <= catalog.CatalogCount)
                        {
                            Item selectedItem = catalog.CatalogList[choice - 1];
                            player.AddItem(selectedItem);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid choice");
                            Console.ResetColor();
                        }
                        break;
                    case 2:
                        player.PrintInventory();
                        Console.Write("Select which item to remove by their number: ");
                        int remove = int.Parse(Console.ReadLine());
                        if (remove > 0 && remove <= catalog.CatalogCount)
                        {
                            Item selectedItem = catalog.CatalogList[remove - 1];
                            player.RemoveItem(selectedItem);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid choice");
                            Console.ResetColor();
                        }
                        break;
                    case 3:
                        player.PrintInventory();
                        break;
                    case 4:
                        running = false;
                        break;
                    default:
                        Console.Beep();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid action!");
                        Console.ResetColor();
                        break;
                }
            }
        }
    }
}
