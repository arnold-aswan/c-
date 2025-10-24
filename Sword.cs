namespace WeaponForge;

class Sword : Weapon
{
    public Sword(string name, int damage) : base(name, damage){ }

    public override void DisplayInfo() => Console.WriteLine($"{Name}: slashing weapon type Sword, damage: {Damage} ");
    public override void Use() => Console.WriteLine("Swish");
}

class Bow : Weapon
{
    public Bow(string name, int damage) : base(name, damage){ }

    public override void DisplayInfo() => Console.WriteLine($"{Name}: weapon type Bow, used with arrows. damage: {Damage} ");
    public override void Use() => Console.WriteLine("Wuush");
}

class Staff : Weapon
{
    public Staff(string name, int damage) : base(name, damage){ }

    public override void DisplayInfo() => Console.WriteLine($"{Name} weapon type Staff, damage: {Damage} ");
    public override void Use() => Console.WriteLine("smack");
}