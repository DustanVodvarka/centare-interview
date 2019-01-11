namespace GameOfLife.Console
{
    /// <summary>
    /// Manages and updates the state of cells on a board
    /// </summary>
    public class Board
    {
        public Board(string[,] cells)
        {
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
            // TODO: Update the board state with the next generation
        }
    }
}