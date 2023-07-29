

using routePlanner;

internal class Program
{
    public static void Main(string[] args)
    {
        bool[][] mapMatrix = new bool[][]
        {
            new bool[] { false, false, true, true, true },
            new bool[] { true, true, true, false, true },
            new bool[] { false, true, false, true, true },
            new bool[] { true, true, true, true, false },
            new bool[] { true, false, true, true, true }
        };

        int fromRow = 0;
        int fromColumn = 0;
        int toRow = 4;
        int toColumn = 4;

        bool isRouteExists = RoutePlanner.RouteExists(mapMatrix, fromRow, fromColumn, toRow, toColumn);

        if (isRouteExists)
        {
            Console.WriteLine("Destination is reachable!");
        }
        else
        {
            Console.WriteLine("Destination is not reachable.");
        }
    }
}