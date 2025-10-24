namespace Challenge7;

public class Game
{
    private int Round { get; set; } = 1;
    public void Run(Character a, Character b)
    {
        Console.WriteLine("_________ GAME STARTED __________");

        while (a.IsAlive && b.IsAlive)
        { 
           Console.WriteLine($"\n═══ Round {Round} ═══");
           
           Console.ForegroundColor = ConsoleColor.DarkCyan;
           Console.WriteLine($"═══ Stats ═══");
           a.PrintStatus();
           b.PrintStatus();
           Console.WriteLine($"═══ Stats ═══");
           Console.ResetColor();
           
           a.Attack(b);
           Console.WriteLine();
           b.Attack(a);
           Round++;
           
           if (!b.IsAlive || !a.IsAlive)
               break;
        }
        
        Console.WriteLine($"\n🎮 Game Over! Winner: {(a.IsAlive ? a.Name : b.Name)}");
    }
}
