namespace InventorySystem;

public class Inventory
{
    private List<Item> Items { get; }
    private readonly int _maxWeight;
    private int _totalValue;

    public Inventory()
    {
        Items =  new List<Item>();
        _maxWeight = 100;
        _totalValue = 0;
    }

    public float CurrentWeight => Items.Sum(i => i.Weight);
    public void AddItem(Item item)
    {
        if (CurrentWeight + item.Weight <= _maxWeight)
        {
            Items.Add(item);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Added {item.Name} to inventory.");
            Console.ResetColor();
        }
        else
        {
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Uh Oh, Inventory max weight reached!");
            Console.ResetColor();
        }
    }

    public void RemoveItem(Item item)
    {
        Items.Remove(item);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Removed {item.Name} from inventory.");
        Console.ResetColor();
    }

    public void ListItems()
    {
        Console.WriteLine();
        Console.WriteLine("________ INVENTORY _________\n");
        foreach(Item item in Items)
        {
            _totalValue += item.Value;
            Console.WriteLine($"{Items.IndexOf(item) + 1}. {item.Describe()}");
        }
        
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Value: {_totalValue} - Weight: {CurrentWeight}/{_maxWeight}");
        Console.ResetColor();
    }
}