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
            Cells = GetNextGeneration(Cells);
        }

        private string[,] GetNextGeneration(string[,] curGen)
        {
            var nextGen = new string[curGen.GetLength(0), curGen.GetLength(1)];

            // TODO: Update nextGen with the next cell generation

            return nextGen;
        }
    }
}