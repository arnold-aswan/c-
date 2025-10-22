namespace PotionBrewer;
public static class PotionFactory
{
    private static readonly List<string> _potionNames = new List<string>()
    {
        "Elixir of Life",
        "Arcane Infusion",
        "Titan's Brew",
        "Quicksilver Potion",
        "Shadow Veil",
        "Fireward Potion",
        "Phoenix Tears",
        "Bottled Courage",
        "Moonwell Elixir",
        "Ironhide Philter"
    };

    public static Potion BrewPotion()
    {
        Random random = new Random();
        string potionName = _potionNames[random.Next(10)];
        int potionPotency = random.Next(1, 11);
        PotionRarity potionRarity = (PotionRarity)random.Next(4);

        return new Potion(potionName, potionPotency, potionRarity);
    }
}