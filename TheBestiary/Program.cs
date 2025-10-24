/*
🐉 Challenge 6: The Bestiary (400 XP)
   
   Concepts: Polymorphism, lists of base types
   Create an abstract Creature class with:
   Name, Health, and abstract method Attack()
   Then create Goblin, Dragon, and Slime subclasses that override Attack().
   Store them in a List<Creature> and make them all attack in a loop.   
   🔹 Bonus: Give each creature a random health value and unique attack messages.
*/

namespace TheBestiary;

static class Program
{
   static void Main()
   {
      Random random = new Random();

      Goblin goblin = new Goblin("gobta", random.Next(10, 100));
      Dragon dragon = new Dragon("droga", random.Next(10, 100));
      Slime slime = new Slime("rimuru",  random.Next(10, 100));
      
      List<Creature> creatures = new List<Creature>();
      creatures.Add(goblin);
      creatures.Add(dragon);
      creatures.Add(slime);
      
      foreach(Creature creature in creatures)
         creature.Attack();
      
   }
}