/*
 * 🧪 Challenge 3: The Potion Brewer (250 XP)
   
   Concepts: Static members, randomization, encapsulation
   Create a Potion class with Name, Potency, and Rarity.
   Add a PotionFactory static class that can randomly generate potions.
   Each potion should have:
   A random name (from a preset list)
   Random potency (1–10)
    Random rarity ("Common", "Uncommon", "Rare", "Legendary")
   🔹 Bonus: Store all created potions in a list and list them later.
 */

namespace PotionBrewer;

class Program
{
    static void Main()
    {
        List<Potion> potions = new List<Potion>();

        Potion p = PotionFactory.BrewPotion();
        Potion p1 = PotionFactory.BrewPotion();
        Potion p2 = PotionFactory.BrewPotion();
        
        potions.Add(p);
        potions.Add(p1);
        potions.Add(p2);
        
        foreach (Potion potion in potions)
            Console.WriteLine($"{potions.IndexOf(potion) + 1}. {potion.Describe} " );
    }
}