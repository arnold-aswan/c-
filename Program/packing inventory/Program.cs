
// Pack Limits
// 1. total number of items it can hold.
// 2. weight it can carry.
// 3. volume it can hold.

// each item has weight and volume.
// Items
// 1. Arrow             // 2. Bow               // 3. Rope
// weight => 0.1        // weight => 1          // weight => 1
// volume => 0.05       // volume => 4          // volume => 1.5

// 4. Water             // 5. Food Rations      // 6. Sword
// weight => 2          // weight => 1          // weight => 5
// volume => 3          // volume => 0.5        // volume => 3

namespace packing_inventory
{
    class Pack
    {
        
        // properties
        public int MaxItems { get; }
        public double MaxWeight { get; }
        public double MaxVolume { get; }

        private readonly InventoryItem[] _items;
        public int CurrentItemsCount { get; private set; }
        public double CurrentVolume { get; private set; }
        public double CurrentWeight { get; private set; }

        public Pack(int maxItems, double maxWeight, double maxVolume)
        {
            MaxItems = maxItems;
            MaxWeight = maxWeight;
            MaxVolume = maxVolume;

            _items = new InventoryItem[MaxItems];
        }

        // methods
        public bool AddInventoryItem(InventoryItem item)
        {
            if (CurrentItemsCount >= MaxItems) return false;
            if (CurrentWeight + item.Weight > MaxWeight) return false;
            if (CurrentVolume + item.Volume > MaxVolume) return false;

            _items[CurrentItemsCount] = item;
            CurrentItemsCount++;
            CurrentWeight += item.Weight;
            CurrentVolume += item.Volume;
            return true;
        }
        public void PrintPackInventory()
        {
            Console.WriteLine($"\nPack status:");
            Console.WriteLine($"Items: {CurrentItemsCount}/{MaxItems}");
            Console.WriteLine($"Weight: {CurrentWeight}/{MaxWeight}");
            Console.WriteLine($"Volume: {CurrentVolume}/{MaxVolume}");
            Console.WriteLine("--------------------------");
            
            if (_items.Length == 0)
                Console.WriteLine("Pack is currently empty!");
            else
            {
                Console.WriteLine($"Pack Contents:");
                for (int i = 0; i < _items.Length; i++)
                {
                    var item = _items[i];
                    if (item == null) continue; // skip empty slots

                    Console.WriteLine($"- {item.GetType().Name} (W: {item.Weight}, V: {item.Volume})");
                }
            }
            Console.WriteLine();
        }
    }
    class InventoryItem
    {
        public double Weight { get;}
        public double Volume { get;}

        protected InventoryItem(double weight, double volume)
        {
            Weight = weight;
            Volume = volume;
        }

        public override string ToString() => base.GetType().Name;
    }

    class Arrow : InventoryItem { public Arrow() : base(0.1, 0.05) {} }
    class Bow : InventoryItem { public Bow() : base(1, 4) {} }
    class Rope : InventoryItem { public Rope(): base(1, 1.5) {}}
    class Water : InventoryItem { public Water(): base(2, 3) {} }
    class Food : InventoryItem { public Food(): base(1, 0.5) {} }
    class Sword : InventoryItem { public Sword(): base(5, 3) {} }

    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the Fountain of Objects – Pack Builder!");
            Console.WriteLine("--------------------------------------------------");
           
            Pack pack = new Pack(10, 20,  30);
            Rope rope = new Rope();
            Sword sword = new Sword();
            Console.WriteLine(sword.ToString());
            pack.AddInventoryItem(rope);

            // bool done = false;
            // while (!done)
            // {
            //     Console.WriteLine($"Pack is currently at {pack.CurrentItemsCount}/{pack.MaxItems} items, {pack.CurrentWeight}/{pack.MaxWeight} weight, and {pack.CurrentVolume}/{pack.MaxVolume} volume.");
            //
            //     Console.WriteLine("\nChoose an item to add:");
            //     Console.WriteLine("1 - Arrow");
            //     Console.WriteLine("2 - Bow");
            //     Console.WriteLine("3 - Rope");
            //     Console.WriteLine("4 - Water");
            //     Console.WriteLine("5 - Food Rations");
            //     Console.WriteLine("6 - Sword");
            //     Console.WriteLine("0 - Exit");
            //     
            //     int choice = int.Parse(Console.ReadLine());
            //
            //     InventoryItem item = null;
            //     switch (choice)
            //     {
            //         case 1: item =  new Arrow(); break;
            //         case 2: item = new Bow(); break;
            //         case 3: item = new Rope(); break;
            //         case 4: item = new Water(); break;
            //         case 5: item = new Food(); break;
            //         case 6: item = new Sword(); break;
            //         case 0: done = true; continue;
            //         default:
            //             Console.WriteLine("Invalid choice. Try again.");
            //             continue;
            //     }
            //
            //     if (item != null)
            //     {
            //         bool added = pack.AddInventoryItem(item);
            //         if (added)
            //             Console.WriteLine($"{item.GetType().Name} added successfully!");
            //         else
            //             Console.WriteLine($"❌ Cannot add {item.GetType().Name}: Pack limit exceeded!");
            //     }
            //     pack.PrintPackInventory();
            // }
        }
    }
}