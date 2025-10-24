
// CHALLENGE 7

/*
 🧍‍♂️ Challenge 7: The Character Creator (150 XP)
   Concepts: classes, fields, constructors, and properties.
   Create a Character class with:
   Name (string)
   Level (int)
   Health (int)
   A constructor that takes these three values,
   A method PrintStats() that displays them nicely.
   Then, in Main(), create two characters and print their stats.
  
   ⚔️ Challenge 8: The Battle Simulator (200 XP)
   Concepts: multiple classes, methods, basic logic.
   Extend the previous challenge.
   Create a simple turn-based battle between two characters.
   Each attack:
   Reduces the opponent’s health by a random amount (1–10)
   Alternates turns until one reaches 0 or below.
   Print out each attack and who wins.
 */
namespace Challenge7
{
    public class Character
    {
        public string Name { get; }
        private int Level { get; }
        public int Health { get; private set; }

        public Character(string name, int level, int health)
        {
            Name = name;
            Level = level;
            Health = health;
        }
        private void PrintStatus() => Console.WriteLine($"Name: {Name} \nLevel: {Level} \nHealth: {Health}");

        public void TakeDamage()
        {
            Random damage = new Random();
            int damageTaken = damage.Next(1, 10);
            if (Health > 0)
            {
                Health -= damageTaken;
                Console.WriteLine($"{Name} took {damageTaken} damage.");
                PrintStatus();
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Player {Name} has died of low Health");
                PrintStatus();
                Console.WriteLine();
            }
        }
    }

    public class Game
    {
      public void Run(Character a, Character b)
      {
          Console.WriteLine("_________ GAME STARTED __________");
          Console.WriteLine();

          while (a.Health > 0 && b.Health > 0)
          {
              a.TakeDamage();
              b.TakeDamage();
          }
          
          if (a.Health > 0 && b.Health < 0)
              Console.WriteLine($"{a.Name} Won");
          else
              Console.WriteLine($"{b.Name} Won");
      }
    }

    class Program
    {
        public static void Main()
        {
        Character c1 = new Character("John Doe", 1, 20);
        Character c2 = new Character("Jane Doe", 1, 20);

        Game game = new Game();
        game.Run(c1, c2);
        }   
    }
}