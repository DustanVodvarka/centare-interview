using System;

namespace GameOfLife.Console
{
    /// <summary>
    /// Manages and updates the state of cells on a board
    /// </summary>
    public class Board
    {
        public Board(CellState[,] initialState)
        {
            State = initialState ?? throw new ArgumentNullException(nameof(initialState));
        }

        /// <summary>
        /// Gets the current state of all cells on the board
        /// </summary>
        public CellState[,] State { get; private set; }

        /// <summary>
        /// Calculates the next generation of the board and updates the board <see cref="State" />
        /// </summary>
        public void Update()
        {
            var newState = new CellState[State.GetLength(0), State.GetLength(1)];

            for (var row = 0; row < State.GetLength(0); row++)
            {
                for (var col = 0; col < State.GetLength(1); col++)
                {
                    var liveCount = CountLiveNeighbors(row, col, State);

                    if (State[row, col] == CellState.Live)
                    {
                        if (liveCount < 2 || liveCount > 3)
                        {
                            newState[row, col] = CellState.Dead;
                        }
                        else
                        {
                            newState[row, col] = State[row, col];
                        }
                    }
                    else
                    {
                        if (liveCount == 3)
                        {
                            newState[row, col] = CellState.Live;
                        }
                        else
                        {
                            newState[row, col] = State[row, col];
                        }
                    }
                }
            }

            State = newState;
        }

        private int CountLiveNeighbors(int row, int col, CellState[,] state)
        {
            var count = 0;

            // one row above
            if (row > 0)
            {
                if (col > 0)
                {
                    count += state[row - 1, col - 1] == CellState.Live ? 1 : 0;
                }
                count += state[row - 1, col] == CellState.Live ? 1 : 0;
                if (col < state.GetLength(1) - 1)
                {
                    count += state[row - 1, col + 1] == CellState.Live ? 1 : 0;
                }
            }

            // current row
            if (col > 0)
            {
                count += state[row, col - 1] == CellState.Live ? 1 : 0;
            }
            if (col < state.GetLength(1) - 1)
            {
                count += state[row, col + 1] == CellState.Live ? 1 : 0;
            }

            // one row below
            if (row < state.GetLength(0) - 1)
            {
                if (col > 0)
                {
                    count += state[row + 1, col - 1] == CellState.Live ? 1 : 0;
                }
                count += state[row + 1, col] == CellState.Live ? 1 : 0;
                if (col < state.GetLength(1) - 1)
                {
                    count += state[row + 1, col + 1] == CellState.Live ? 1 : 0;
                }
            }

            return count;
        }
    }
}