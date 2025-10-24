namespace ColoredItems
{
    public class Sword
    {
        public override string ToString() => "Sword";
    }

    public class Bow
    {
        public override string ToString() => "Bow";
    }

    public class Axe
    {
        public override string ToString() => "Axe";
    }

    public class ColoredItem<T>
    {
        public T Item { get; set; }
        public ConsoleColor Color { get; set; }

        public ColoredItem(T item, ConsoleColor color)
        {
            Item = item;
            Color = color;
        }
        
        public void Display()
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = Color;
            Console.WriteLine(Item?.ToString());
            Console.ForegroundColor = oldColor;
        }
    }

    class Program
    {
        static void Main()
        {
            var blueSword = new ColoredItem<Sword>(new Sword(), ConsoleColor.Cyan);
            var yellowBow = new ColoredItem<Bow>(new Bow(), ConsoleColor.DarkYellow);
            var redAxe = new ColoredItem<Axe>(new Axe(), ConsoleColor.DarkRed);
            
            blueSword.Display();
            yellowBow.Display();
            redAxe.Display();
        }
    }
}