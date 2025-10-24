/*
🔥 LEVEL 4: Advanced OOP Logic
   💬 Challenge 7: The Quest Board (450 XP)
   
   Concepts: Interfaces, collections, polymorphism
   Create an IQuest interface with:
   string Title
   void Execute()
   Implement multiple quest types:
   FetchQuest (collect items)
   KillQuest (defeat monsters)
   ExploreQuest (discover locations)
   Store them in a List<IQuest> and simulate completing them all. 
   🔹 Bonus: Give each quest XP rewards.
 */
 
 namespace QuestBoard;

 public class Program
 {
     public static void Main()
     {
         List<IQuest> quests = new List<IQuest>
         {
          new FetchQuest("Collectors"),
          new ExplorerQuest("dora the explorer"),
          new KillQuest ("Assassins gamble")
         };
         
         foreach(IQuest quest in quests)
             quest.Execute();
         
     }
 }