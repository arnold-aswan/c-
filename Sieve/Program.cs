namespace Sieve;

class Program
{
    static bool IsEvenNumber(int number) => number % 2 == 0;
    static bool IsPositiveNumber(int number) => number >= 0;
    static bool IsMultiplesOf10(int number) => number % 10 == 0;
    
    static void Main()
    {
        Console.WriteLine("Pick one of the following filters " +
                          "\n1. Even number. " +
                          "\n2. Positive numbers. " +
                          "\n3. Multiples of 10.");
        int choice =  Convert.ToInt32(Console.ReadLine());

        Sieve sieve;
        string filterName;
        switch (choice)
        {
            case 1:
                sieve = new Sieve(IsEvenNumber);
                filterName = "Even numbers";
                break;
            case 2:
                sieve = new Sieve(IsPositiveNumber);
                filterName = "Positive numbers";
                break;
            case 3:
                sieve = new Sieve(IsMultiplesOf10);
                filterName = "Multiples of 10 numbers";
                break;
            default:
                Console.WriteLine("Invalid choice, defaulting to even numbers.");
                sieve = new Sieve(IsEvenNumber);
                filterName = "Even numbers";
                break;
        }

        Console.WriteLine($"Selected Filter is: {filterName}");
        Console.WriteLine("Enter numbers to test, (Q) to exit \n");

        while (true)
        {
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
                break;

            if (int.TryParse(input, out int number))
            {
                bool isGood = sieve.IsGood(number);
                Console.WriteLine($"{number} is a {(isGood ? "Good" : "Bad")} number");
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }

    }
}

public class Sieve
{
    private Func<int, bool> _testDelegate;

    public Sieve(Func<int, bool> testDelegate)
    {
        _testDelegate = testDelegate;
    }

    public bool IsGood(int number)
    {
        return _testDelegate(number);
    }
}