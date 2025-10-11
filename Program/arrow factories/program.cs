// shaft => 0.05/cm
enum ArrowHead {Steel = 10, Wood = 3, Obsidian = 5};
enum ArrowFletching {Plastic = 10, TurkeyFeathers = 5, GooseFeathers = 3};

class Arrow
{
    private string arrowHead;
    private int arrowLength;
    private string arrowFletching;

    public Arrow(string arrowHead, int arrowLength, string arrowFletching)
    {
        this.arrowHead = arrowHead;
        this.arrowLength = arrowLength;
        this.arrowFletching = arrowFletching;
    }
    public float GetCost()
    {
        int arrowHeadCost = GetArrowHead(arrowHead);
        int arrowLengthCost = this.arrowLength;
        int arrowFletchCost = GetFetchingType(arrowFletching);
        
        float totalArrowLengthCost = (float)(arrowLengthCost * 0.05);
        float total = (float)arrowHeadCost + (float)arrowFletchCost + (float)totalArrowLengthCost;
        return total;
    }
    public string GetCostBreakdown()
    {
        int arrowHeadCost = GetArrowHead(arrowHead);
        int arrowLengthCost = this.arrowLength;
        int arrowFletchCost = GetFetchingType(arrowFletching);
        
        float totalArrowLengthCost = (float)(arrowLengthCost * 0.05);
        float total = (float)arrowHeadCost + (float)arrowFletchCost + (float)totalArrowLengthCost;

        return
            $"Arrow Head: {arrowHead}: {arrowHeadCost}\n" +
            $"Arrow Fletch: {arrowFletching}: {arrowFletchCost}\n" +
            $"Arrow Shaft: {arrowLength} cm: * 0.05: {totalArrowLengthCost}\n" +
            $"total cost: {total}";
    }
    private int GetArrowHead(string head)
    {
        return head switch
        {
            "steel" => (int)ArrowHead.Steel,
            "wood" => (int)ArrowHead.Wood,
            "obsidian" => (int)ArrowHead.Obsidian,
            "_" => (int)ArrowHead.Steel,
        };
    }
    private int GetFetchingType(string fletch)
    {
        return fletch switch
        {
            "plastic" => (int)ArrowFletching.Plastic,
            "turkey" => (int)ArrowFletching.TurkeyFeathers,
            "goose" => (int)ArrowFletching.GooseFeathers,
            "_" => (int)ArrowFletching.Plastic,
        };
    }

    public static Arrow CreateEliteArrow() => new Arrow("steel", 95, "plastic");
    public static Arrow CreateBeginnerArrow() => new Arrow("wood", 75, "goose");
    public static Arrow CreateMarksmanArrow() => new Arrow("steel", 65, "goose");
}

class program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Vin Fletcher’s Arrows!");
        Console.WriteLine("Choose an arrow type:");
        Console.WriteLine("1. Elite Arrow (arrow-head: steel, fletching-type: plastic, shaft-length: 95 cm)");
        Console.WriteLine("2. Beginner Arrow (arrow-head: wood, fletching-type: goose, shaft-length: 75 cm)");
        Console.WriteLine("3. Marksman Arrow (arrow-head: steel, fletching-type: goose, shaft-length: 65 cm)");
        Console.WriteLine("4. Custom Arrow");

        Console.Write("Your choice (1-4):");
        string? choice = Console.ReadLine();

        Arrow arrow = choice switch
        {
            "1" => Arrow.CreateEliteArrow(),
            "2" => Arrow.CreateBeginnerArrow(),
            "3" => Arrow.CreateMarksmanArrow(),
            "4" => CreateCustomArrow(),
            _ => Arrow.CreateBeginnerArrow()
        };

        Console.WriteLine("\n__________ Cost BreakDown ___________");
        Console.WriteLine(arrow.GetCostBreakdown());
        Console.WriteLine("\n__________ Total Cost ___________");
        Console.WriteLine(arrow.GetCost());
    }
    static Arrow CreateCustomArrow()
    {
        Arrow arrow;
        string arrowHead = GetArrowHeadInput();
        string arrowFletching = GetFletchingTypeInput();
        int arrowLength = GetArrowLength();

        static string GetArrowHeadInput()
        {
            Console.Write("Pick an arrow head: (steel, wood, obsidian): ");
            return Console.ReadLine().ToLower();
        }

        static string GetFletchingTypeInput()
        {
            Console.Write("Pick an arrow fletching type: (plastic, turkey, goose): ");
            return Console.ReadLine().ToLower();
        }

        static int GetArrowLength()
        {
            int arrowLength;
            do
            {
                Console.Write("Pick an arrow length: (60-100 cm long): ");
                arrowLength = int.Parse(Console.ReadLine());
            } while (arrowLength < 60 || arrowLength > 100);

            return arrowLength;
        }

        return new Arrow(arrowHead, arrowLength, arrowFletching);
    }
}

