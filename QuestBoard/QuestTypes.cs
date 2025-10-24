namespace QuestBoard;
public class FetchQuest : IQuest
{
    public string Title { get; }

    public FetchQuest(string title)
    {
        Title = title;
    }
    public void Execute() => Console.WriteLine($"You have successfully completed {Title} quest which mainly entails collecting items. You have earned 100XP.");

}

public class KillQuest : IQuest
{
    public string Title { get; }
    public KillQuest(string title)
    {
        Title = title;
    }
    public void Execute() => Console.WriteLine($"You have successfully completed {Title} quest which mainly entails defeating monsters. You have earned 500XP."); 
}

public class ExplorerQuest : IQuest
{
    public string Title { get; }

    public ExplorerQuest(string title)
    {
        Title = title;
    }
    public void Execute() => Console.WriteLine($"You have successfully completed {Title} quest which mainly entails finding new locations. You have earned 3500XP."); 
}
