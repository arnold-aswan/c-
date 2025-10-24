
class Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Point()
    {
        X = 0;
        Y = 0;
    }

    public string ToCoord()
    {
        return $"({X}, {Y})";
    }
}

class Program
{
    static void Main()
    {
        Point p = new Point(2, 3);
        Point p1 = new Point(-4, 0);
        
        Console.WriteLine(p.ToCoord());
        Console.WriteLine(p1.ToCoord());
    }
}
