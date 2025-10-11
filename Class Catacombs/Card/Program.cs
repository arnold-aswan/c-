class Card
{
    // properties
    public Colors color {get;}
    public CardRank rank { get; }

    // Constructor
    public Card(Colors cardColor, CardRank cardRank)
    {
        color = cardColor;
        rank = cardRank;
    }

    public Card()
    {
        color = Colors.Blue;
        rank = CardRank.Nine;
    }
    
    // Method
    public bool IsNumberCard =>  (int)rank >= 1 && (int)rank <= 10;
    public bool IsSymbol => !IsNumberCard;
    public string CardToString => $"The {color} {rank}";
    
}

class Program
{
    public static void Main()
    {
        Colors[] colors = new Colors[] { Colors.Red , Colors.Green, Colors.Blue, Colors.Yellow};
        CardRank[] ranks = new CardRank[]
        {
            CardRank.One , CardRank.Two, CardRank.Three, CardRank.Four, CardRank.Five, CardRank.Six, 
            CardRank.Seven, CardRank.Eight, CardRank.Nine, CardRank.Ten, CardRank.Ampersand, 
            CardRank.Percent, CardRank.Caret, CardRank.Dollar
        };

        foreach (Colors color in colors)
        {
            foreach (CardRank rank in ranks)
            {
                Card card = new Card(color, rank);
                Console.WriteLine(card.CardToString);
                
            }
        }
    }
}

enum Colors {
    Red,
    Green,
    Blue,
    Yellow
};

enum CardRank
{
    One = 1,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,

    Dollar,   // $
    Percent,  // %
    Caret,    // ^
    Ampersand // &
}