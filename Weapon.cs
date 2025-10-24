namespace WeaponForge;

public class Weapon
{
    public string Name { get; }
    public int Damage { get; }

    public Weapon(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }
    
    public virtual void DisplayInfo() =>  Console.WriteLine($"{Name} - DMG: {Damage}");
    public virtual void Use() => Console.WriteLine($"Attack deals a damage of {Damage}");
}