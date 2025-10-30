namespace Excepti;

public class Game
{
    private static Random _random = new Random();
    private static int oatmealRaisinCookie = _random.Next(10);
    private static List<int> _numbers = new List<int>();

    public void Run()
    {
        Console.WriteLine("Game started");
        Console.WriteLine("Two players will take turns picking cookies (numbers 0-9)."); 
        Console.WriteLine("One cookie is oatmeal raisin... don't pick it!\n");
        try
        {
            int currentPlayer = 1;
            while (true)
            {
                PickANumber(player:currentPlayer);
                currentPlayer = (currentPlayer == 1) ? 2 : 1;
            } ;
        }
        catch (OatMealRaisinCookieException e)
        {
            Console.WriteLine("Game ended");
            Console.WriteLine(e.Message);
            int winner = (e.PlayerNumber == 1) ? 2 : 1;
            Console.WriteLine($"Player {winner} won the game!!");
        }
    }

    private void PickANumber(int player)
    {
        int choice;
        Console.Write($"Player {player} pick a number between 0  and 9: ");
        choice = Convert.ToInt32(Console.ReadLine());
        
        while (_numbers.Contains(choice) || choice < 0 || choice > 9)
        {
            if (_numbers.Contains(choice))
                Console.Write($"{choice} already exists, pick again between 0  and 9: ");
            else
                Console.Write("Invalid number! Pick between 0 and 9: "); 
            choice = Convert.ToInt32(Console.ReadLine());
        }  
        _numbers.Add(choice);
        
        if (choice == oatmealRaisinCookie)
        {
            throw new OatMealRaisinCookieException(player);
        }
        Console.WriteLine($"Player {player} got a chocolate chip cookie!");
    }
}

public class OatMealRaisinCookieException : Exception
{
    public int PlayerNumber { get; }

    public OatMealRaisinCookieException(int playerNumber)
        : base($"💀 Player {playerNumber} ate oatmeal raisin cookie!!")
    {
        PlayerNumber = playerNumber;
    }
}