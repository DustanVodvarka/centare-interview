namespace GameOfLife.Console
{
    /// <summary>
    /// Represents a pre-defined game of life demo state
    /// </summary>
    public class Demo
    {
        /// <summary>
        /// The number of iterations to run
        /// </summary>
        public int Iterations { get; set; }

        /// <summary>
        /// The initial cell state the board will start at
        /// </summary>
        public CellState[,] InitialState { get; set; }
    }
}