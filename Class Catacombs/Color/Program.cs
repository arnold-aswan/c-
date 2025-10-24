
using System.Drawing;
class Color
{
    // Properties
    public int R { get; }
    public int G { get; }
    public int B { get; }

    // Constructor
    public Color(int red, int green, int blue)
    {
        R = red;
        G = green;
        B = blue;
    }
    
    // Parameterless Constructor
    public Color()
    {
        R = 0;
        G = 0;
        B = 0;
    }
    
    // methods
    public string ColorToString()
    {
        return $"({R}, {G}, {B})";
    }
    
    // static properties
    public static Color White = new Color(255, 255, 255);
    public static Color Black = new Color(0, 0, 0);
    public static Color Red = new Color(255, 0, 0);
    public static Color Orange = new Color(255, 165, 0);
    public static Color Yellow = new Color(255, 255, 0);
    public static Color Green = new Color(0, 128, 0);
    public static Color Blue = new Color(0, 0, 255);
    public static Color Purple = new Color(128, 0, 128);
}


class Program
{
    static void Main()
    {
        Color c = new Color(123, 45, 67);
        Color c1 = Color.Orange;
        
        Console.WriteLine(c.ColorToString());
        Console.WriteLine(c1.ColorToString());
    }
}