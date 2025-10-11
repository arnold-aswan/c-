namespace WarPreparation
{
    public enum Materials {Wood, Bronze, Iron, Steel, Binarium};
    public enum Gemstones {Emerald, Amber, Saphire, Diamond, Bitstone};
    public record Sword(Materials Material, Gemstones? Gemstone, int Length, int CrossguardWidth);

    class Program
    {
    public static void Main()
    {
        Sword s = new Sword(Materials.Iron, null, 20, 7);
        Sword s1 = s with { Material = Materials.Steel, Length = 23 };
        Sword s2 = s with { Material = Materials.Binarium };
        Console.WriteLine(s2.ToString());
        Console.WriteLine(s2.Equals(s1));
    }
    }
}

