using GameOfLife.Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameOfLife.Tests
{
    /// <summary>
    /// Rules:
    /// 1. Any live cell with fewer than two live neighbors dies,
    ///    as if caused by underpopulation.
    /// 2. Any live cell with more than three live neighbors dies,
    ///    as if by overcrowding.
    /// 3. Any live cell with two or three live neighbors lives
    ///    on to the next generation.
    /// 4. Any dead cell with exactly three live neighbors becomes
    ///    a live cell.
    /// </summary>
    [TestClass]
    public class BoardTests
    {
        [TestMethod]
        public void It_should_not_crash()
        {
            var board = new Board(new string[0, 0]);
            board.Update();
        }

        [TestMethod]
        public void Constructor_should_set_state()
        {
            var board = new Board(new [,]
            {
                { ".", ".", "." },
                { "*", "*", "*" },
                { ".", ".", "." }
            });
            CollectionAssert.AreEquivalent(
                new[,]
                {
                    { ".", ".", "." },
                    { "*", "*", "*" },
                    { ".", ".", "." }
                },
                board.Cells);
        }

        // TODO: Add more tests
    }
}
