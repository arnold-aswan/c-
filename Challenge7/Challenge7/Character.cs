namespace Challenge7;

public class Character
{
    public string Name { get; }
    private int Level { get; }
    public int Health { get; private set; }
    public bool IsAlive => Health > 0;
    private static Random _damage = new Random();

    public Character(string name, int level, int health)
    {
        Name = name;
        Level = level;
        Health = health;
    }
    public void PrintStatus() => Console.WriteLine($"Name: {Name} __ Level: {Level} __ Health: {Health}");
        
    public void TakeDamage(int damageTaken)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Health = Math.Max(0, Health - damageTaken);
        Console.WriteLine($"{Name} took {damageTaken} damage. {(IsAlive ? "Still standing" : "💀 Has died!")}");
        Console.ResetColor();
    }

    public virtual void Attack(Character target)
    {
        if (!IsAlive)
        {   
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{Name} Died 💀 & cannot attack!!! ");
            Console.ResetColor();
            return;
        }
        Console.ForegroundColor = ConsoleColor.Green;
        int damageDealt = _damage.Next(1, 10);
        Console.WriteLine($"⚔️ {Name} attacks {target.Name}!");
        target.TakeDamage(damageDealt);
        Console.ResetColor();
    }
}

public class Warrior : Character 
{
    public Warrior(string name, int level, int health) : base(name, level, health) { }
    
    private static Random _damage = new Random();
    public override void Attack(Character target)
    {
        if (!IsAlive)
        {   
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{Name} Died 💀 & cannot attack!!! ");
            Console.ResetColor();
            return;
        }
        Console.ForegroundColor = ConsoleColor.Green;
        int damageDealt = _damage.Next(5, 15);
        Console.WriteLine($"⚔️ {Name} the Warrior lands a POWER STRIKE!!");
        target.TakeDamage(damageDealt);
        Console.ResetColor();
    }
}

public class Mage : Character 
{
    public Mage(string name, int level, int health) : base(name, level, health) { }
    private static Random _damage = new Random();
    public override void Attack(Character target)
    {
        if (!IsAlive)
        {   
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{Name} Died 💀 & cannot attack!!! ");
            Console.ResetColor();
            return;
        }
        Console.ForegroundColor = ConsoleColor.Green;
        int damageDealt = _damage.Next(10, 30);
        Console.WriteLine($"⚔️ {Name} the Mage summons fireball 🔥!!");
        target.TakeDamage(damageDealt);
        Console.ResetColor();
    }
}
public class Archer : Character 
{
    public Archer(string name, int level, int health) : base(name, level, health) { }
    private static Random _damage = new Random();

    public override void Attack(Character target)
    {
        if (!IsAlive)
        {   
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{Name} Died 💀 & cannot attack!!! ");
            Console.ResetColor();
            return;
        }
        Console.ForegroundColor = ConsoleColor.Green;
        int damageDealt = _damage.Next(10, 20);
        Console.WriteLine($"⚔️ {Name} the elusive archer headshots {target.Name}!!");
        target.TakeDamage(damageDealt);
        Console.ResetColor();
    }
}
