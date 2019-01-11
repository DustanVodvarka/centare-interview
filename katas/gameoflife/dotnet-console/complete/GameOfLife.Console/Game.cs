using System.Threading;

namespace GameOfLife.Console
{
    public class Game
    {
        private const int SleepMs = 200;
        private const string LiveCellStateChar = "*";
        private const string DeadCellStateChar = ".";

        private readonly Board _board;

        public Game(CellState[,] initialState)
        {
            _board = new Board(initialState);
        }

        public void Start(int iterations)
        {
            System.Console.Clear();
            for (var i = 0; i < iterations; i++)
            {
                Render(_board.State);
                _board.Update();

                Thread.Sleep(SleepMs);
            }
        }

        public void Render(CellState[,] board)
        {
            System.Console.CursorLeft = System.Console.CursorTop = 0;

            for (var row = 0; row < board.GetLength(0); row++)
            {
                for (var col = 0; col < board.GetLength(1); col++)
                {
                    System.Console.Write(board[row, col] == CellState.Live ? LiveCellStateChar : DeadCellStateChar);
                }
                System.Console.WriteLine();
            }
        }
    }
}