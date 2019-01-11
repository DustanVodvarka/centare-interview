namespace GameOfLife.Console
{
    /// <summary>
    /// A list of interesting pre-defined game of life demos
    /// </summary>
    public static class Demos
    {
        /// <summary>
        /// Steady-state that does not change
        /// </summary>
        public static readonly Demo Canoe = new Demo()
        {
            Iterations = 10,
            InitialState = new[,] 
            {
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Live, CellState.Live, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Live, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Live, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Live, CellState.Dead, CellState.Live, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Live, CellState.Live, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead}
            }
        };

        /// <summary>
        /// Oscillates for a couple of iterations before dying out
        /// </summary>
        public static readonly Demo Cloverleaf = new Demo()
        {
            Iterations = 20,
            InitialState = new[,]
            {
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Live, CellState.Dead, CellState.Live, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Live, CellState.Live, CellState.Live, CellState.Dead, CellState.Live, CellState.Live, CellState.Live, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Live, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Live, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Live, CellState.Dead},
                {CellState.Dead, CellState.Live, CellState.Dead, CellState.Live, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Live, CellState.Dead, CellState.Live, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Live, CellState.Dead, CellState.Live, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Live, CellState.Dead, CellState.Live, CellState.Dead},
                {CellState.Dead, CellState.Live, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Live, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Live, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Live, CellState.Live, CellState.Live, CellState.Dead, CellState.Live, CellState.Live, CellState.Live, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Live, CellState.Dead, CellState.Live, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead}
            }
        };

        /// <summary>
        /// Travels from the upper left to lower right of the board
        /// </summary>
        public static readonly Demo Glider = new Demo()
        {
            Iterations = 35,
            InitialState = new[,]
            {
                {CellState.Dead, CellState.Live, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Live, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Live, CellState.Live, CellState.Live, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
            }
        };

        /// <summary>
        /// Infinitely oscillates between two states
        /// </summary>
        public static readonly Demo Oscillator = new Demo()
        {
            Iterations = 20,
            InitialState = new[,]
            {
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Live, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Live, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Live, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Live, CellState.Live, CellState.Live, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Live, CellState.Live, CellState.Live, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Live, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Live, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Live, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead}
            }
        };

        /// <summary>
        /// Performs an explosion-like animation before settling in a steady-state
        /// </summary>
        public static readonly Demo Exploder = new Demo()
        {
            Iterations = 30,
            InitialState = new[,]
            {
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Live, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Live, CellState.Live, CellState.Live, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Live, CellState.Dead, CellState.Live, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Live, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead},
                {CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead, CellState.Dead}
            }
        };
    }
}