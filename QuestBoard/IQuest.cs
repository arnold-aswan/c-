namespace QuestBoard;

public interface IQuest
{
    string Title { get; }
    void Execute();
}