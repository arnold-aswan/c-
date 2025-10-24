/*

⚔️ Challenge 5: The Weapon Forge (350 XP)
   Concepts: Inheritance, virtual methods
   Create a base Weapon class with:
   Name, Damage, and a DisplayInfo() method
   Create subclasses:
   Sword, Bow, Staff — each with unique behavior in DisplayInfo()   
   🔹 Bonus: Add a Use() method that prints a different attack message for each type.
   
*/

namespace WeaponForge;

public static class Program
{
   public static void Main()
   {
      Weapon weapon = new Weapon("random", 15);
      Sword sword = new Sword("kusanagi", 100);
      Staff staff = new Staff("staff", 100);
      Bow bow = new Bow("bow", 100);

      weapon.DisplayInfo();
      weapon.Use();
      sword.DisplayInfo();
      sword.Use();
      bow.DisplayInfo();
      bow.Use();
      staff.DisplayInfo();
      staff.Use();
   }
}