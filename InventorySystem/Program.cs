/*
🧱 Challenge 1: The Inventory System (150 XP)

   Concepts: Lists, encapsulation, methods
   Create an Inventory class that holds a list of Item objects.
   Each item has a Name, Weight, and Value.
   Add methods to:
   Add or remove an item
   Show total weight and total value
   List all items nicely formatted
   🔹 Bonus: Prevent adding items if total weight exceeds 100.
*/

namespace  InventorySystem;

class Program
{
   public static void Main()
   {
      Inventory inventory = new Inventory();
      
      Item salt = new Item("salt", 30, 1);
      Item sugar = new Item("sugar", 25, 3);
      Item water = new Item("water", 25, 5);
      Item wood = new Item("wood", 45, 5);
      
      inventory.AddItem(salt);
      inventory.AddItem(sugar);
      inventory.AddItem(wood);
      inventory.AddItem(water);
      inventory.ListItems();
   }
}