namespace InventorySystem;

public class Item
{
    public string Name { get; }
    public float Weight { get; }
    public int Value { get; }

    public Item(string name, float weight, int value)
    {
        Name = name;
        Weight = weight;
        Value = value;
    }
    public string Describe() => $"{Name} - Weighs: {Weight} - Value: {Value}";
}