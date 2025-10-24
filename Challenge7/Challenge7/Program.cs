
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

/*
 * 🕹 Challenge 8: The Turn-Based Arena (500 XP)
 * Concepts: OOP interaction, game logic, encapsulation
 * Extend your Character class with attack methods.
 * Simulate a 2-player turn-based fight system:
 * Each turn: one attacks, one defends
 * Randomized damage Display health each round
 * 🔹 Bonus: Use inheritance for specialized classes like Warrior, Mage, Archer.
 */


namespace Challenge7;
    class Program
    {
        public static void Main()
        {
        Archer c1 = new Archer("Oliver Queen", 1, 20);
        Mage c2 = new Mage("Stephen Strange", 1, 20);

        Game game = new Game();
        game.Run(c1, c2);
        }   
    }