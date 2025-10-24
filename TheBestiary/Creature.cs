namespace TheBestiary;

public abstract class Creature
{
    public string Name { get; }
    public int Health { get; }
    public Creature(string name, int health)
    {
        Name = name;
        Health = health;
    }
    public abstract void Attack();
}

class Goblin : Creature
{
    public Goblin(string name, int health) : base(name, health){}
    public override void Attack() => Console.WriteLine($"{Name} the goblin (HP: {Health}) goes berserk and attacks you.");
}

class Dragon : Creature
{
    public Dragon(string name, int health) : base(name, health){}
    public override void Attack() =>  Console.WriteLine($"{Name} the Dragon king (HP: {Health}), roars and breathes fire to attacks you.");
}

class Slime : Creature
{
    public Slime(string name, int health) : base(name, health){}
    public override void Attack() => Console.WriteLine($"{Name} the Slime (HP: {Health}), activates ultimate skill Beelzebub to eat you!");
}