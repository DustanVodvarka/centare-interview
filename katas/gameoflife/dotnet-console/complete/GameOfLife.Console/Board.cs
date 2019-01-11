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
            Cells = cells ?? throw new ArgumentNullException(nameof(cells));
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
            var newState = new string[Cells.GetLength(0), Cells.GetLength(1)];

            for (var row = 0; row < Cells.GetLength(0); row++)
            {
                for (var col = 0; col < Cells.GetLength(1); col++)
                {
                    var liveCount = CountLiveNeighbors(row, col, Cells);

                    if (Cells[row, col] == "*")
                    {
                        if (liveCount < 2 || liveCount > 3)
                        {
                            newState[row, col] = ".";
                        }
                        else
                        {
                            newState[row, col] = Cells[row, col];
                        }
                    }
                    else
                    {
                        if (liveCount == 3)
                        {
                            newState[row, col] = "*";
                        }
                        else
                        {
                            newState[row, col] = Cells[row, col];
                        }
                    }
                }
            }

            Cells = newState;
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