namespace RoomCoordinates
{
    public struct Coordinate
    {
        public int Row { get; }
        public int Column { get; }

        public Coordinate(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public static bool IsAdjacent(Coordinate a,  Coordinate b)
        {
            int rowDiff = a.Row - b.Row;
            int columnDiff = a.Column - b.Column;

            if (Math.Abs(rowDiff) == 1 && columnDiff == 0) return true;
            if (Math.Abs(columnDiff) == 1 && rowDiff == 0) return true;
            return false;
        }
    }

    class Program
    {
        public static void Main()
        {
            Coordinate c1 = new Coordinate(0, 0);
            Coordinate c2 = new Coordinate(0, 1);
            Coordinate c3 = new Coordinate(0, 1);

            Console.WriteLine(Coordinate.IsAdjacent(c3, c2));
        }
    }
}