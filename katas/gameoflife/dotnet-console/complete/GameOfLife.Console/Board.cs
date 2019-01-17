using System;

namespace GameOfLife.Console
{
    /// <summary>
    /// Manages and updates the state of cells on a board
    /// </summary>
    public class Board
    {
        public Board(string[,] cells)
        {
            if (cells == null)
            {
                throw new ArgumentNullException(nameof(cells));
            }

            for (var x = 0; x < cells.GetLength(0); x++)
            {
                for (var y = 0; y < cells.GetLength(1); y++)
                {
                    if (cells[x, y] != "." && cells[x, y] != "*")
                    {
                        throw new ArgumentException(
                            $"Invalid cell value '{cells[x, y]}' encountered at position [{x}, {y}]. Only the characters '.' and '*' are allowed.");
                    }
                }
            }

            Cells = cells;
        }

        /// <summary>
        /// Gets the current state of all cells on the board
        /// </summary>
        public string[,] Cells { get; private set; }

        /// <summary>
        /// Calculates the next generation of the board and updates the board <see cref="Cells" />
        /// </summary>
        public void Update()
        {
            var nextGen = new string[Cells.GetLength(0), Cells.GetLength(1)];

            for (var row = 0; row < Cells.GetLength(0); row++)
            {
                for (var col = 0; col < Cells.GetLength(1); col++)
                {
                    var liveCount = CountLiveNeighbors(row, col, Cells);

                    if (Cells[row, col] == "*")
                    {
                        if (liveCount < 2 || liveCount > 3)
                        {
                            nextGen[row, col] = ".";
                        }
                        else
                        {
                            nextGen[row, col] = Cells[row, col];
                        }
                    }
                    else
                    {
                        if (liveCount == 3)
                        {
                            nextGen[row, col] = "*";
                        }
                        else
                        {
                            nextGen[row, col] = Cells[row, col];
                        }
                    }
                }
            }

            Cells = nextGen;
        }

        private int CountLiveNeighbors(int row, int col, string[,] cells)
        {
            var count = 0;

            // one row above
            if (row > 0)
            {
                if (col > 0)
                {
                    count += cells[row - 1, col - 1] == "*" ? 1 : 0;
                }
                count += cells[row - 1, col] == "*" ? 1 : 0;
                if (col < cells.GetLength(1) - 1)
                {
                    count += cells[row - 1, col + 1] == "*" ? 1 : 0;
                }
            }

            // current row
            if (col > 0)
            {
                count += cells[row, col - 1] == "*" ? 1 : 0;
            }
            if (col < cells.GetLength(1) - 1)
            {
                count += cells[row, col + 1] == "*" ? 1 : 0;
            }

            // one row below
            if (row < cells.GetLength(0) - 1)
            {
                if (col > 0)
                {
                    count += cells[row + 1, col - 1] == "*" ? 1 : 0;
                }
                count += cells[row + 1, col] == "*" ? 1 : 0;
                if (col < cells.GetLength(1) - 1)
                {
                    count += cells[row + 1, col + 1] == "*" ? 1 : 0;
                }
            }

            return count;
        }
    }
}