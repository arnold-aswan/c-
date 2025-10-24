namespace ShopKeeper;

public class Item
{
    public string Name { get; }
    public int Value { get; }

    public Item(string name, int value)
    {
        Name = name;
        Value = value;
    }
}