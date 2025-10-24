namespace PotionBrewer;

public enum PotionRarity
{
    Common,
    Uncommon,
    Rare,
    Legendary
};
public class Potion
{
    private string Name {get;}
    private int Potency { get;  }
    private PotionRarity Rarity { get; }

    public Potion(string name, int potency,  PotionRarity rarity)
    {
        Name = name;
        Potency = potency;
        Rarity = rarity;
    }

    public string Describe => $"{Name} Potency: {Potency} - Rarity: {Rarity}";
}