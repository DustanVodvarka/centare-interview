using System.Threading;

namespace GameOfLife.Console
{
    public class Program
    {
        private const int SleepMs = 200;

        static void Main()
        {
            Start(new[,]
                {
                    {".", ".", ".", ".", "*", ".", ".", ".", "."},
                    {".", ".", ".", ".", "*", ".", ".", ".", "."},
                    {".", ".", ".", ".", "*", ".", ".", ".", "."},
                    {".", ".", ".", ".", ".", ".", ".", ".", "."},
                    {"*", "*", "*", ".", ".", ".", "*", "*", "*"},
                    {".", ".", ".", ".", ".", ".", ".", ".", "."},
                    {".", ".", ".", ".", "*", ".", ".", ".", "."},
                    {".", ".", ".", ".", "*", ".", ".", ".", "."},
                    {".", ".", ".", ".", "*", ".", ".", ".", "."}
                },
                10);

            System.Console.WriteLine("Hit any key to exit");
            System.Console.ReadKey();
        }

        private static void Start(string[,] cells, int iterations)
        {
            var board = new Board(cells);

            System.Console.Clear();
            for (var i = 0; i < iterations; i++)
            {
                Render(board.Cells);
                board.Update();

                Thread.Sleep(SleepMs);
            }
        }

        private static void Render(string[,] cells)
        {
            System.Console.CursorLeft = System.Console.CursorTop = 0;

            for (var row = 0; row < cells.GetLength(0); row++)
            {
                for (var col = 0; col < cells.GetLength(1); col++)
                {
                    System.Console.Write(cells[row, col]);
                }
                System.Console.WriteLine();
            }
        }
    }
}
