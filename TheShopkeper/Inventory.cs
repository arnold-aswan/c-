namespace ShopKeeper;

public class Inventory
{
    public List<Item> _inventory { get; } = new List<Item>();

    public Inventory()
    {
        _inventory = new List<Item>();
    }

    public void AddItem(Item item)
    {
        if (!_inventory.Contains(item))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            _inventory.Add(item);
            Console.WriteLine($"Added {item.Name} to your inventory!");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{item.Name} is already in the inventory!");
            Console.ResetColor();
        }
    }
    public void RemoveItem(Item item)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        _inventory.Remove(item);
        Console.WriteLine($"Removed {item.Name} from your inventory!");
        Console.ResetColor();
    }

    private string Describe(Item item) => $"{item.Name} - Value: {item.Value}";

    public void ListItems()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("________ INVENTORY __________");
        foreach(Item item in _inventory)
            Console.WriteLine($"{_inventory.IndexOf(item) + 1}. {Describe(item)}");
        Console.ResetColor();
        Console.WriteLine();
    }

    public Item FindItem(int index) => _inventory[index];
}