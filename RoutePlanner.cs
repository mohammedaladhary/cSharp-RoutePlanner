using System;
namespace routePlanner
{
	public class RoutePlanner
        
	{
        public static bool RouteExists(bool[][] mapMatrix, int fromRow, int fromColumn, int toRow, int toColumn)
        {
            int numRows = mapMatrix.Length;
            int numColumns = mapMatrix[0].Length;

            // Helper function to perform DFS
            bool DepthFirstSearch(int row, int col)
            {
                // Check if the current cell is out of bounds or not a road (false)
                if (row < 0 || row >= numRows || col < 0 || col >= numColumns || !mapMatrix[row][col])
                    return false;

                // Check if the current cell is the destination
                if (row == toRow && col == toColumn)
                    return true;

                // Mark the current cell as visited by setting it to false (to avoid revisiting)
                mapMatrix[row][col] = false;

                // Recursively explore adjacent cells
                bool foundPath = DepthFirstSearch(row + 1, col) ||
                                 DepthFirstSearch(row - 1, col) ||
                                 DepthFirstSearch(row, col + 1) ||
                                 DepthFirstSearch(row, col - 1);

                return foundPath;
            }

            // Call DFS from the starting point (fromRow, fromColumn)
            return DepthFirstSearch(fromRow, fromColumn);
        }
    }
}

